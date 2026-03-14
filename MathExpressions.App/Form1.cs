using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathExpressions.Core;

namespace MathExpressions.App
{
    

    public partial class Form1 : Form
    {

        private ExpressionEngine _engine;
        private HistoryManager _history;
        public Form1()
        {
            InitializeComponent();
          
            _engine = new ExpressionEngine();
            _history = new HistoryManager();
            lblResult.Text = "Result:";

            btn0.Click += BtnInsert_Click;
            btn1.Click += BtnInsert_Click;
            btn2.Click += BtnInsert_Click;
            btn3.Click += BtnInsert_Click;
            btn4.Click += BtnInsert_Click;
            btn5.Click += BtnInsert_Click;
            btn6.Click += BtnInsert_Click;
            btn7.Click += BtnInsert_Click;
            btn8.Click += BtnInsert_Click;
            btn9.Click += BtnInsert_Click;

            btnPlus.Click += BtnInsert_Click;
            btnMinus.Click += BtnInsert_Click;
            btnMultiply.Click += BtnInsert_Click;
            btnDivide.Click += BtnInsert_Click;

            btnDot.Click += BtnInsert_Click;
            btnLParen.Click += BtnInsert_Click;
            btnRParen.Click += BtnInsert_Click;

            btnSin.Click += BtnInsert_Click;
            btnCos.Click += BtnInsert_Click;
            btnLog.Click += BtnInsert_Click;
            btnSqrt.Click += BtnInsert_Click;

            btnEqual.Click += BtnEqual_Click;
            btnClearAll.Click += BtnClearAll_Click;
            btnClearEntry.Click += BtnClearEntry_Click;
            btnBackspace.Click += BtnBackspace_Click;
            btnClearHistory.Click += btnClearHistory_Click;

            this.AcceptButton = btnEqual;
            
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            AppendToExpression(btn.Text);
        }
        private void AppendToExpression(string text)
        {
            int pos = txtExpression.SelectionStart;

            txtExpression.Text = txtExpression.Text.Insert(pos, text);

            txtExpression.SelectionStart = pos + text.Length;
            txtExpression.Focus();
        }
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string expr = txtExpression.Text;
                double result = _engine.Evaluate(expr);

                lblResult.Text = "Result: " + result;

                _history.Add(expr, result);

                lstHistory.Items.Clear();
                foreach (HistoryItem item in _history.All)
                {
                    lstHistory.Items.Add(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            txtExpression.Clear();
            lblResult.Text = "Result:";
        }
        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Length > 0)
            {
                txtExpression.Text =
                    txtExpression.Text.Substring(0,
                    txtExpression.Text.Length - 1);
            }
        }
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Length > 0)
            {
                txtExpression.Text =
                    txtExpression.Text.Substring(0,
                    txtExpression.Text.Length - 1);
            }
        }
        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            string exprText = txtExpression.Text.Trim();

            if (string.IsNullOrWhiteSpace(exprText))
            {
                MessageBox.Show("Please enter an expression.", "Warning");
                return;
            }

            try
            {
                // 1. Evaluate
                double result = _engine.Evaluate(exprText);

                // 2. Show result
                lblResult.Text = "Result: " + result;

                // 3. Add to history
                _history.Add(exprText, result);

                // 4. Refresh listBox
                lstHistory.Items.Clear();
                foreach (var item in _history.All)
                {
                    lstHistory.Items.Add(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Evaluation error");
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            _history.Clear();
            lstHistory.Items.Clear();
            lblResult.Text = "Result:";
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lstHistory_Click(object sender, EventArgs e)
        {

        }

        private void txtExpression_Click(object sender, EventArgs e)
        {

        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpHistory_Enter(object sender, EventArgs e)
        {

        }

        private void lstHistory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnBackspace_Click_1(object sender, EventArgs e)
        {

        }
    }
}
