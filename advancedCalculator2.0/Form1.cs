using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advancedCalculator2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bt_div.Tag = calculate.Operations.div;
            bt_mul.Tag = calculate.Operations.mul;
            bt_sub.Tag = calculate.Operations.sub;
            bt_sum.Tag = calculate.Operations.sum;
            bt_sqr.Tag = calculate.Operations.sqr;
            bt_1delx.Tag = calculate.Operations.fr;
            bt_sqrt.Tag = calculate.Operations.sqrt;
            Width = 340;
        }

        bool f_znak = false;
        bool f_ravno = false;
        bool change = false;
        calculate calc = new calculate();
        string error = "Ошибка";

        private void InputOperation(calculate.Operations operation)
        {
            try
            {
                f_znak = true;
                resultLabel.Text = calc.Inp_op(double.Parse(resultLabel.Text), operation, change);
                opLabel.Text = calc.History;
                change = false;
            }
            catch (Exception)
            {
                resultLabel.Text = error;
            }
        }

        private void InputUnaryOperation(calculate.Operations operation)
        {
            try
            {
                resultLabel.Text = calc.UnaryOperation(operation, double.Parse(resultLabel.Text));
            }
            catch (Exception)
            {
                resultLabel.Text = error;
            }
        }

        private void Input(string st)
        {
            if (!f_ravno)
            {
                if (resultLabel.Text.Length >= 8) return;
                if (resultLabel.Text == "0" || resultLabel.Text == "-0")
                {
                    resultLabel.Text = "";
                }
                resultLabel.Text += st;
            }
            else
            {
                f_ravno = false;
                resultLabel.Text = "";
                resultLabel.Text = st;
            }
        }

        private void OperationClick(object sender, EventArgs e)
        {
            //opLabel.Text = (sender as Button).Text;
            InputOperation((calculate.Operations)(sender as Button).Tag);
        }

        private void UnaryOperationClick(object sender, EventArgs e)
        {
            InputUnaryOperation((calculate.Operations)(sender as Button).Tag);
        }

        private void DigitClick(object sender, EventArgs e)
        {
            InputDigit((sender as Button).Text);
        }

        private void InputDigit(string text)
        {
            // тут поменяли
            if (resultLabel.Text == error || f_ravno) Clear();
            if (f_znak)
            {
                resultLabel.Text = "0";
                f_znak = false;
            }
            Input(text);
            change = true;
        }

        private void RavnoClick(object sender, EventArgs e)
        {
            if (resultLabel.Text == error)
            {
                Clear();
            }
            f_ravno = true;

            try
            {
                resultLabel.Text = calc.Out(double.Parse(resultLabel.Text));
                opLabel.Text = calc.History;
                change = false;
                if (resultLabel.Text == "∞") Clear();
                history_list.Items.Add(resultLabel.Text);
            }
            catch (Exception)
            {
                resultLabel.Text = error;
            }
        }
        private void CClick(object sender, EventArgs e)
        {
            opLabel.Text = "";
            opLabel.Text = "";
            resultLabel.Text = "0";
            calc.Sbros();
            f_ravno = false;
            change = false;
        }

        private void BackspaceClick(object sender, EventArgs e)
        {
            Backspace();
        }
        private void Backspace()
        {
            if (resultLabel.Text == error || resultLabel.Text == "∞") Clear();
            else
            {
                // тут поменяли
                if (!f_ravno && !f_znak && !resultLabel.Text.Contains('E'))
                {
                    resultLabel.Text = resultLabel.Text.Substring(0, resultLabel.Text.Length - 1);
                    if (resultLabel.Text == "" || resultLabel.Text == "-") resultLabel.Text = "0";
                }
            }
        }

        private void Clear()
        {
            calc.Sbros();
            resultLabel.Text = "0";
            opLabel.Text = "";
            f_znak = false;
        }
        private void pointClick(object sender, EventArgs e)
        {
            InputSeparator();
        }
        private void InputSeparator()
        {
            if (f_ravno) Clear();
            if (f_znak)
            {
                resultLabel.Text = "0";
                f_znak = false;
            }
            if (resultLabel.Text == error) Clear();
            if (resultLabel.Text.Contains(',')) return;
            resultLabel.Text += ",";
            change = true;
        }
        private void hz_click(object sender, EventArgs e)
        {
            if (resultLabel.Text == error) { Clear(); }
            if (resultLabel.Text[0] == '-')
                resultLabel.Text = resultLabel.Text.Substring(1);
            else
                resultLabel.Text = "-" + resultLabel.Text;
            if (f_ravno) calc.ChangeSign();
            change = true;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') InputDigit(e.KeyChar.ToString());
            if (e.KeyChar == '+') InputOperation(calculate.Operations.sum);
            if (e.KeyChar == '-') InputOperation(calculate.Operations.sub);
            if (e.KeyChar == '*') InputOperation(calculate.Operations.mul);
            if (e.KeyChar == '/') InputOperation(calculate.Operations.div);
            if (e.KeyChar == ',') InputSeparator();
            if (e.KeyChar == (char)Keys.Back) Backspace();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about about1 = new about();
            about1.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resultLabel_DragDrop(object sender, DragEventArgs e)
        {
            resultLabel.Text = e.Data.GetData(typeof(string)).ToString();
            change = true;
        }

        private void resultLabel_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void history_list_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox h = (ListBox)sender;
            if (h.SelectedItem == null) return;
            h.DoDragDrop(h.SelectedItem, DragDropEffects.Copy);
            calc.FromHistory(resultLabel.Text, f_ravno);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            history_list.Items.Clear();
        }

        private void toAdvancedClick(object sender, EventArgs e)
        {
            if (Width > 340)
            {
                toAdvanced.Text = "=>";
                Width = 340;
            }
            else 
            {
                toAdvanced.Text = "<=";
                Width = 600; 
            }
        }
    }
}
