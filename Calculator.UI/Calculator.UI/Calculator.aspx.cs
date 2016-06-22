using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculator.Lib;

namespace Calculator.UI
{
    public partial class Calculator : System.Web.UI.Page
    {
        private readonly CalculatorLib _calc = new CalculatorLib();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            var input1 = Convert.ToInt32(txtInput1.Text);
            var input2 = Convert.ToInt32(txtInput2.Text);

            var res = _calc.Add(input1, input2);
            lblResult.Text = res.ToString();
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            var input1 = Convert.ToInt32(txtInput1.Text);
            var input2 = Convert.ToInt32(txtInput2.Text);

            var res = _calc.Subtract(input1, input2);
            lblResult.Text = res.ToString();
        }

        protected void btnMult_Click(object sender, EventArgs e)
        {
            var input1 = Convert.ToInt32(txtInput1.Text);
            var input2 = Convert.ToInt32(txtInput2.Text);

            var res = _calc.Mult(input1, input2);
            lblResult.Text = res.ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            var input1 = Convert.ToInt32(txtInput1.Text);
            var input2 = Convert.ToInt32(txtInput2.Text);

            var res = _calc.Div(input1, input2);
            lblResult.Text = res.ToString();
        }
    }
}