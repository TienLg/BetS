using System.Data;
using System.Windows.Forms;
namespace BetS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerBrowser = new System.Windows.Forms.SplitContainer();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.gbErrorFilter = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rbAllError = new System.Windows.Forms.RadioButton();
            this.rbNegativeError = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPositiveError = new System.Windows.Forms.RadioButton();
            this.tbBelowRangeError = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUpperRangeError = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.tbFormula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumC = new System.Windows.Forms.TextBox();
            this.cbTextCapture = new System.Windows.Forms.CheckBox();
            this.tbNumB = new System.Windows.Forms.TextBox();
            this.tbNumA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBrowser)).BeginInit();
            this.splitContainerBrowser.Panel1.SuspendLayout();
            this.splitContainerBrowser.SuspendLayout();
            this.gbErrorFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitContainerBrowser);
            this.splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gbErrorFilter);
            this.splitContainer.Panel2.Controls.Add(this.btnExecute);
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Panel2.Controls.Add(this.rbC);
            this.splitContainer.Panel2.Controls.Add(this.rbB);
            this.splitContainer.Panel2.Controls.Add(this.rbA);
            this.splitContainer.Panel2.Controls.Add(this.tbFormula);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.tbNumC);
            this.splitContainer.Panel2.Controls.Add(this.cbTextCapture);
            this.splitContainer.Panel2.Controls.Add(this.tbNumB);
            this.splitContainer.Panel2.Controls.Add(this.tbNumA);
            this.splitContainer.Size = new System.Drawing.Size(826, 444);
            this.splitContainer.SplitterDistance = 526;
            this.splitContainer.TabIndex = 0;
            // 
            // splitContainerBrowser
            // 
            this.splitContainerBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBrowser.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerBrowser.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBrowser.Name = "splitContainerBrowser";
            this.splitContainerBrowser.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBrowser.Panel1
            // 
            this.splitContainerBrowser.Panel1.Controls.Add(this.btnGo);
            this.splitContainerBrowser.Panel1.Controls.Add(this.tbUrl);
            this.splitContainerBrowser.Size = new System.Drawing.Size(526, 444);
            this.splitContainerBrowser.SplitterDistance = 28;
            this.splitContainerBrowser.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(34, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(43, 5);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(480, 20);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUrl_KeyDown);
            // 
            // gbErrorFilter
            // 
            this.gbErrorFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbErrorFilter.Controls.Add(this.btnRefresh);
            this.gbErrorFilter.Controls.Add(this.rbAllError);
            this.gbErrorFilter.Controls.Add(this.rbNegativeError);
            this.gbErrorFilter.Controls.Add(this.label2);
            this.gbErrorFilter.Controls.Add(this.rbPositiveError);
            this.gbErrorFilter.Controls.Add(this.tbBelowRangeError);
            this.gbErrorFilter.Controls.Add(this.label3);
            this.gbErrorFilter.Controls.Add(this.tbUpperRangeError);
            this.gbErrorFilter.Location = new System.Drawing.Point(15, 241);
            this.gbErrorFilter.Name = "gbErrorFilter";
            this.gbErrorFilter.Size = new System.Drawing.Size(269, 70);
            this.gbErrorFilter.TabIndex = 25;
            this.gbErrorFilter.TabStop = false;
            this.gbErrorFilter.Text = "Error Filter";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(194, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rbAllError
            // 
            this.rbAllError.AutoSize = true;
            this.rbAllError.Checked = true;
            this.rbAllError.Location = new System.Drawing.Point(6, 21);
            this.rbAllError.Name = "rbAllError";
            this.rbAllError.Size = new System.Drawing.Size(36, 17);
            this.rbAllError.TabIndex = 22;
            this.rbAllError.TabStop = true;
            this.rbAllError.Text = "All";
            this.rbAllError.UseVisualStyleBackColor = true;
            // 
            // rbNegativeError
            // 
            this.rbNegativeError.AutoSize = true;
            this.rbNegativeError.Location = new System.Drawing.Point(121, 21);
            this.rbNegativeError.Name = "rbNegativeError";
            this.rbNegativeError.Size = new System.Drawing.Size(40, 17);
            this.rbNegativeError.TabIndex = 24;
            this.rbNegativeError.TabStop = true;
            this.rbNegativeError.Text = "< 0";
            this.rbNegativeError.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Range";
            // 
            // rbPositiveError
            // 
            this.rbPositiveError.AutoSize = true;
            this.rbPositiveError.Location = new System.Drawing.Point(57, 21);
            this.rbPositiveError.Name = "rbPositiveError";
            this.rbPositiveError.Size = new System.Drawing.Size(40, 17);
            this.rbPositiveError.TabIndex = 23;
            this.rbPositiveError.TabStop = true;
            this.rbPositiveError.Text = "> 0";
            this.rbPositiveError.UseVisualStyleBackColor = true;
            // 
            // tbBelowRangeError
            // 
            this.tbBelowRangeError.Location = new System.Drawing.Point(57, 44);
            this.tbBelowRangeError.Name = "tbBelowRangeError";
            this.tbBelowRangeError.Size = new System.Drawing.Size(42, 20);
            this.tbBelowRangeError.TabIndex = 19;
            this.tbBelowRangeError.Text = "-1";
            this.tbBelowRangeError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "-";
            // 
            // tbUpperRangeError
            // 
            this.tbUpperRangeError.Location = new System.Drawing.Point(121, 44);
            this.tbUpperRangeError.Name = "tbUpperRangeError";
            this.tbUpperRangeError.Size = new System.Drawing.Size(42, 20);
            this.tbUpperRangeError.TabIndex = 21;
            this.tbUpperRangeError.Text = "1";
            this.tbUpperRangeError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(209, 212);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(69, 23);
            this.btnExecute.TabIndex = 14;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 317);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(269, 64);
            this.dataGridView.TabIndex = 15;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(15, 153);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(32, 17);
            this.rbC.TabIndex = 12;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(15, 94);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 17);
            this.rbB.TabIndex = 11;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Checked = true;
            this.rbA.Location = new System.Drawing.Point(15, 35);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 17);
            this.rbA.TabIndex = 10;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // tbFormula
            // 
            this.tbFormula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFormula.Location = new System.Drawing.Point(15, 400);
            this.tbFormula.Multiline = true;
            this.tbFormula.Name = "tbFormula";
            this.tbFormula.Size = new System.Drawing.Size(269, 32);
            this.tbFormula.TabIndex = 8;
            this.tbFormula.Text = "((a+1)/3-(b+2)/10)/(b+2)/10";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Formula";
            // 
            // tbNumC
            // 
            this.tbNumC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumC.Location = new System.Drawing.Point(53, 153);
            this.tbNumC.Multiline = true;
            this.tbNumC.Name = "tbNumC";
            this.tbNumC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNumC.Size = new System.Drawing.Size(231, 53);
            this.tbNumC.TabIndex = 6;
            // 
            // cbTextCapture
            // 
            this.cbTextCapture.AutoSize = true;
            this.cbTextCapture.ForeColor = System.Drawing.Color.Blue;
            this.cbTextCapture.Location = new System.Drawing.Point(15, 12);
            this.cbTextCapture.Name = "cbTextCapture";
            this.cbTextCapture.Size = new System.Drawing.Size(87, 17);
            this.cbTextCapture.TabIndex = 4;
            this.cbTextCapture.Text = "Text Capture";
            this.cbTextCapture.UseVisualStyleBackColor = true;
            // 
            // tbNumB
            // 
            this.tbNumB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumB.Location = new System.Drawing.Point(53, 94);
            this.tbNumB.Multiline = true;
            this.tbNumB.Name = "tbNumB";
            this.tbNumB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNumB.Size = new System.Drawing.Size(231, 53);
            this.tbNumB.TabIndex = 1;
            // 
            // tbNumA
            // 
            this.tbNumA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumA.Location = new System.Drawing.Point(53, 35);
            this.tbNumA.Multiline = true;
            this.tbNumA.Name = "tbNumA";
            this.tbNumA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNumA.Size = new System.Drawing.Size(231, 53);
            this.tbNumA.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 444);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "BetS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerBrowser.Panel1.ResumeLayout(false);
            this.splitContainerBrowser.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBrowser)).EndInit();
            this.splitContainerBrowser.ResumeLayout(false);
            this.gbErrorFilter.ResumeLayout(false);
            this.gbErrorFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox tbNumB;
        private System.Windows.Forms.TextBox tbNumA;
        private System.Windows.Forms.CheckBox cbTextCapture;
        private System.Windows.Forms.TextBox tbNumC;
        private System.Windows.Forms.TextBox tbFormula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.SplitContainer splitContainerBrowser;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbUrl;
        private Gecko.GeckoWebBrowser browser;
        private DataTable statisticTable;
        private DataView dataView;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton rbNegativeError;
        private System.Windows.Forms.RadioButton rbPositiveError;
        private System.Windows.Forms.RadioButton rbAllError;
        private System.Windows.Forms.TextBox tbUpperRangeError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBelowRangeError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbErrorFilter;
        private System.Windows.Forms.Button btnRefresh;
    }
}

