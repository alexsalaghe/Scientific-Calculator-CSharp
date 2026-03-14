namespace MathExpressions.App
{
    partial class Form1
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnLParen = new System.Windows.Forms.Button();
            this.btnRParen = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.lblExpression = new System.Windows.Forms.Label();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.pnlHistoryBottom = new System.Windows.Forms.Panel();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpHistory.SuspendLayout();
            this.pnlHistoryBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tblButtons);
            this.splitMain.Panel1.Controls.Add(this.pnlTop);
            this.splitMain.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.grpHistory);
            this.splitMain.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitMain.Size = new System.Drawing.Size(992, 681);
            this.splitMain.SplitterDistance = 560;
            this.splitMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 5;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.Controls.Add(this.btnBackspace, 2, 0);
            this.tblButtons.Controls.Add(this.btnClearEntry, 0, 0);
            this.tblButtons.Controls.Add(this.btnClearAll, 1, 0);
            this.tblButtons.Controls.Add(this.btnLParen, 3, 0);
            this.tblButtons.Controls.Add(this.btnRParen, 4, 0);
            this.tblButtons.Controls.Add(this.btnSin, 0, 1);
            this.tblButtons.Controls.Add(this.btnCos, 1, 1);
            this.tblButtons.Controls.Add(this.btnLog, 2, 1);
            this.tblButtons.Controls.Add(this.btnSqrt, 3, 1);
            this.tblButtons.Controls.Add(this.btnDivide, 4, 1);
            this.tblButtons.Controls.Add(this.btn8, 1, 2);
            this.tblButtons.Controls.Add(this.btn9, 2, 2);
            this.tblButtons.Controls.Add(this.btnMultiply, 3, 2);
            this.tblButtons.Controls.Add(this.btnEqual, 2, 5);
            this.tblButtons.Controls.Add(this.btnDot, 1, 5);
            this.tblButtons.Controls.Add(this.btn0, 0, 5);
            this.tblButtons.Controls.Add(this.btnPlus, 3, 4);
            this.tblButtons.Controls.Add(this.btn3, 2, 4);
            this.tblButtons.Controls.Add(this.btn2, 1, 4);
            this.tblButtons.Controls.Add(this.btn1, 0, 4);
            this.tblButtons.Controls.Add(this.btnMinus, 3, 3);
            this.tblButtons.Controls.Add(this.btn6, 2, 3);
            this.tblButtons.Controls.Add(this.btn5, 1, 3);
            this.tblButtons.Controls.Add(this.btn4, 0, 3);
            this.tblButtons.Controls.Add(this.btn7, 0, 2);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(0, 120);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.Padding = new System.Windows.Forms.Padding(10);
            this.tblButtons.RowCount = 6;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblButtons.Size = new System.Drawing.Size(560, 561);
            this.tblButtons.TabIndex = 1;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackspace.Location = new System.Drawing.Point(231, 15);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(98, 80);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "<--";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click_1);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearEntry.Location = new System.Drawing.Point(15, 15);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(5);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(98, 80);
            this.btnClearEntry.TabIndex = 0;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearAll.Location = new System.Drawing.Point(123, 15);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(98, 80);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnLParen
            // 
            this.btnLParen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLParen.Location = new System.Drawing.Point(339, 15);
            this.btnLParen.Margin = new System.Windows.Forms.Padding(5);
            this.btnLParen.Name = "btnLParen";
            this.btnLParen.Size = new System.Drawing.Size(98, 80);
            this.btnLParen.TabIndex = 3;
            this.btnLParen.Text = "(";
            this.btnLParen.UseVisualStyleBackColor = true;
            // 
            // btnRParen
            // 
            this.btnRParen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRParen.Location = new System.Drawing.Point(447, 15);
            this.btnRParen.Margin = new System.Windows.Forms.Padding(5);
            this.btnRParen.Name = "btnRParen";
            this.btnRParen.Size = new System.Drawing.Size(98, 80);
            this.btnRParen.TabIndex = 4;
            this.btnRParen.Text = ")";
            this.btnRParen.UseVisualStyleBackColor = true;
            // 
            // btnSin
            // 
            this.btnSin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSin.Location = new System.Drawing.Point(15, 105);
            this.btnSin.Margin = new System.Windows.Forms.Padding(5);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(98, 80);
            this.btnSin.TabIndex = 5;
            this.btnSin.Text = "sin(";
            this.btnSin.UseVisualStyleBackColor = true;
            // 
            // btnCos
            // 
            this.btnCos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCos.Location = new System.Drawing.Point(123, 105);
            this.btnCos.Margin = new System.Windows.Forms.Padding(5);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(98, 80);
            this.btnCos.TabIndex = 6;
            this.btnCos.Text = "cos(";
            this.btnCos.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLog.Location = new System.Drawing.Point(231, 105);
            this.btnLog.Margin = new System.Windows.Forms.Padding(5);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(98, 80);
            this.btnLog.TabIndex = 7;
            this.btnLog.Text = "log(";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqrt.Location = new System.Drawing.Point(339, 105);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(5);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(98, 80);
            this.btnSqrt.TabIndex = 8;
            this.btnSqrt.Text = "sqrt(";
            this.btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Location = new System.Drawing.Point(447, 105);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(5);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(98, 80);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(123, 195);
            this.btn8.Margin = new System.Windows.Forms.Padding(5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(98, 80);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(231, 195);
            this.btn9.Margin = new System.Windows.Forms.Padding(5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(98, 80);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.Location = new System.Drawing.Point(339, 195);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(98, 80);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Location = new System.Drawing.Point(231, 465);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(5);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(98, 81);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDot.Location = new System.Drawing.Point(123, 465);
            this.btnDot.Margin = new System.Windows.Forms.Padding(5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(98, 81);
            this.btnDot.TabIndex = 23;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(15, 465);
            this.btn0.Margin = new System.Windows.Forms.Padding(5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(98, 81);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Location = new System.Drawing.Point(339, 375);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(98, 80);
            this.btnPlus.TabIndex = 21;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(231, 375);
            this.btn3.Margin = new System.Windows.Forms.Padding(5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(98, 80);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(123, 375);
            this.btn2.Margin = new System.Windows.Forms.Padding(5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(98, 80);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(15, 375);
            this.btn1.Margin = new System.Windows.Forms.Padding(5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 80);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Location = new System.Drawing.Point(339, 285);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(98, 80);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(231, 285);
            this.btn6.Margin = new System.Windows.Forms.Padding(5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(98, 80);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(123, 285);
            this.btn5.Margin = new System.Windows.Forms.Padding(5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(98, 80);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(15, 285);
            this.btn4.Margin = new System.Windows.Forms.Padding(5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(98, 80);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(15, 195);
            this.btn7.Margin = new System.Windows.Forms.Padding(5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(98, 80);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblResult);
            this.pnlTop.Controls.Add(this.txtExpression);
            this.pnlTop.Controls.Add(this.lblExpression);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(560, 120);
            this.pnlTop.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(10, 75);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(520, 30);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExpression
            // 
            this.txtExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpression.Font = new System.Drawing.Font("Segoe UI", 11.2F);
            this.txtExpression.Location = new System.Drawing.Point(10, 35);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(520, 32);
            this.txtExpression.TabIndex = 1;
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(10, 10);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(90, 23);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.Text = "Expression";
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.pnlHistoryBottom);
            this.grpHistory.Controls.Add(this.lstHistory);
            this.grpHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHistory.Location = new System.Drawing.Point(0, 0);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(428, 681);
            this.grpHistory.TabIndex = 0;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "History";
            this.grpHistory.Enter += new System.EventHandler(this.grpHistory_Enter);
            // 
            // pnlHistoryBottom
            // 
            this.pnlHistoryBottom.Controls.Add(this.btnClearHistory);
            this.pnlHistoryBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHistoryBottom.Location = new System.Drawing.Point(3, 633);
            this.pnlHistoryBottom.Name = "pnlHistoryBottom";
            this.pnlHistoryBottom.Size = new System.Drawing.Size(422, 45);
            this.pnlHistoryBottom.TabIndex = 1;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearHistory.Location = new System.Drawing.Point(323, 6);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(90, 30);
            this.btnClearHistory.TabIndex = 0;
            this.btnClearHistory.Text = "Clear";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            // 
            // lstHistory
            // 
            this.lstHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.HorizontalScrollbar = true;
            this.lstHistory.ItemHeight = 23;
            this.lstHistory.Location = new System.Drawing.Point(3, 26);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(422, 652);
            this.lstHistory.TabIndex = 0;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 681);
            this.Controls.Add(this.splitMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Expression Evaluator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tblButtons.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpHistory.ResumeLayout(false);
            this.pnlHistoryBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Panel pnlHistoryBottom;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnLParen;
        private System.Windows.Forms.Button btnRParen;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
    }
}

