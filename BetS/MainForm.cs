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
            browser = new GeckoWebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.DomClick += onDomClick;
            browser.Navigate(@"https://www.tipico.com/en/online-sports-betting/");
            splitContainerBrowser.Panel2.Controls.Add(browser);
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
            statisticTable.Columns.Add("Error", typeof(Double));

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

            dataGridView.Columns[2].Name = "Error";
            dataGridView.Columns[2].HeaderText = "Error";
            dataGridView.Columns[2].DataPropertyName = "Error";
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // setup DataView
            dataView = statisticTable.DefaultView;
            dataGridView.DataSource = dataView;
            //dataView.RowFilter = "Error < 0.02";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onDomClick(object sender, DomEventArgs e)
        {
            if (!cbTextCapture.Checked)
                return;
            if (sender == null || e == null || e.Target == null)
                return;
            GeckoHtmlElement element = (GeckoHtmlElement)e.Target.CastToGeckoElement();
            if (element == null)
                return;
            // MessageBox.Show(element.TextContent.Trim());
            
            TextBox tb = null;
            if (rbA.Checked)
                tb = tbNumA;
            if (rbB.Checked)
                tb = tbNumB;
            if (rbC.Checked)
                tb = tbNumC;
            if (tb != null)
            {
                double number;
                if (Double.TryParse(element.TextContent.Trim().Replace(',','.'), out number))
                {
                    tb.Text += number + ";   ";
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            browser.Navigate(tbUrl.Text);
        }

        private void tbUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser.Navigate(tbUrl.Text);
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

            // Execute
            if (statisticTable.Rows.Count > 0)
                statisticTable.Rows.Clear();
            if (dataGridView.Rows.Count > 1)
                dataGridView.Rows.Clear();

            foreach (double[] arr in collectSet)
            {
                parser.Values["a"].SetValue(arr[0]);
                parser.Values["b"].SetValue(arr[1]);
                double result = parser.EvalExpression(expression);

                DataRow row = statisticTable.NewRow();
                row["NumberA"] = arr[0];
                row["NumberB"] = arr[1];
                row["Error"] = Math.Round( result, 4);
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
            string pattern = @"\d+([.,]\d{1,3})*;";
            
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
            dataView.RowFilter = "Error < " + tbUpperRangeError.Text + " and Error > " + tbBelowRangeError.Text;
            if (rbPositiveError.Checked)
                dataView.RowFilter += " and Error > 0";
            if (rbNegativeError.Checked)
                dataView.RowFilter += " and Error < 0";
        }
    }
}
