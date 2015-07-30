using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using info.lundin.math;
using System.Text.RegularExpressions;

namespace BetS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            createTable();
            // Init Gecko Browser
            initTabPages();
        }

        private void initTabPages()
        {
            TabControl.TabPageCollection tabpages = tabControl.TabPages;
            foreach (TabPage page in tabpages)
            {
                BetBrowser browserControl = new BetBrowser();
                browserControl.Dock = DockStyle.Fill;
                browserControl.TextCaptured += onBrowserTextCaptured;
                page.Controls.Add(browserControl);
            }
        }

        private void createTable()
        {
            statisticTable = new DataTable("BetS");

            DataColumn workCol = statisticTable.Columns.Add("ID", typeof(Int32));
            workCol.AllowDBNull = false;
            workCol.Unique = true;
            workCol.AutoIncrement = true;
            workCol.AutoIncrementSeed = 1;
            workCol.AutoIncrementStep = 1;

            statisticTable.Columns.Add("NumberA", typeof(Double));
            statisticTable.Columns.Add("NumberB", typeof(Double));
            statisticTable.Columns.Add("Result", typeof(Double));

            // setup datagridview
            dataGridView.AutoGenerateColumns = false;
            //Set Columns Count
            dataGridView.ColumnCount = 3;

            //Add Columns
            dataGridView.Columns[0].Name = "numberA";
            dataGridView.Columns[0].HeaderText = "A";
            dataGridView.Columns[0].DataPropertyName = "NumberA";
            dataGridView.Columns[0].Width = 50;

            dataGridView.Columns[1].HeaderText = "B";
            dataGridView.Columns[1].Name = "numberB";
            dataGridView.Columns[1].DataPropertyName = "NumberB";
            dataGridView.Columns[1].Width = 50;

            dataGridView.Columns[2].Name = "Result";
            dataGridView.Columns[2].HeaderText = "Result";
            dataGridView.Columns[2].DataPropertyName = "Result";
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // setup DataView
            dataView = statisticTable.DefaultView;
            dataGridView.DataSource = dataView;
            //dataView.RowFilter = "Error < 0.02";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onBrowserTextCaptured(object sender, TextCapturedEventArgs e)
        {
            if (!cbTextCapture.Checked)
                return;
            if (sender == null || e == null)
                return;
            
            TextBox tb = null;
            if (rbA.Checked)
                tb = tbNumA;
            if (rbB.Checked)
                tb = tbNumB;
            if (rbC.Checked)
                tb = tbNumC;
            if (tb != null)
            {
                if (!double.IsNaN(e.Odd))
                {
                    tb.Text += e.Odd + ";   ";
                }
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // get Numbers collection
            List<double[]> collectSet = collectNumbers();
            // Parse Expression
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("a", 10);
            parser.Values.Add("b", 7);
            string func = tbFormula.Text;
            parser.Parse(func);
            Expression expression = parser.Expressions[func];

            // Reset
            if (statisticTable.Rows.Count > 0)
                statisticTable.Rows.Clear();
            dataView.RowFilter = "1=1";

            foreach (double[] arr in collectSet)
            {
                parser.Values["a"].SetValue(arr[0]);
                parser.Values["b"].SetValue(arr[1]);
                double result = parser.EvalExpression(expression);

                DataRow row = statisticTable.NewRow();
                row["NumberA"] = arr[0];
                row["NumberB"] = arr[1];
                row["Result"] = Math.Round(result, 4);
                statisticTable.Rows.Add(row);
            }

            // Fetch to DataGridView
            //dataGridView.DataSource = statisticTable;
        }

        private List<double[]> collectNumbers()
        {
            // return value
            List<double[]> collectSet = new List<double[]>();
            // Set Regx
            string pattern = @"\d+([.,]\d{1,3})?;";
            
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            // collect numbers A
            MatchCollection matchesA = rgx.Matches(tbNumA.Text);
            if (matchesA.Count <= 0)
            {
                MessageBox.Show("Please enter A.");
                return collectSet;
            }
            // collect numbers B
            MatchCollection matchesB = rgx.Matches(tbNumB.Text);
            if (matchesB.Count <= 0)
            {
                MessageBox.Show("Please enter B.");
                return collectSet;
            }
            // collect numbers C
            // To-Do
            // Do combine sets
            foreach (Match matchA in matchesA) {
                double nA, nB;
                Double.TryParse(Regex.Replace(matchA.Value, ";", string.Empty), out nA);

                foreach (Match matchB in matchesB)
                {
                    Double.TryParse(Regex.Replace(matchB.Value, ";", string.Empty), out nB);
                    double[] arr = new double[] { nA, nB};
                    collectSet.Add(arr);
                }
            }

            // Return sets
            return collectSet;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataView = statisticTable.DefaultView;
            double nUpper, nBelow;
            Double.TryParse(tbUpperRangeError.Text, out nUpper);
            Double.TryParse(tbBelowRangeError.Text, out nBelow);
            dataView.RowFilter = String.Format("Result >= {1} AND Result <= {0}", nUpper, nBelow);
            if (rbPositiveError.Checked)
                dataView.RowFilter += " AND Result > 0";
            if (rbNegativeError.Checked)
                dataView.RowFilter += " AND Result <= 0";
        }
    }
}
