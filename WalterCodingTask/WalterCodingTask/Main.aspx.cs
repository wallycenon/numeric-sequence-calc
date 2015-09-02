using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalterCodingTask
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewNumSequence_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);

            lblOutput.Text = "";

            NumericSequenceCalc calc = new NumericSequenceCalc();
            lblOutput.Text = "S3.1.1: ";
            lblOutput.Text += calc.AllNumbers(number);
            lblOutput.Text += "<br/>S3.1.2: ";
            lblOutput.Text += calc.AllOddNumbers(number);
            lblOutput.Text += "<br/>S3.1.3: ";
            lblOutput.Text += calc.AllEvenNumbers(number);
            lblOutput.Text += "<br/>S3.1.4.1: ";
            lblOutput.Text += calc.MultOfThree(number);
            lblOutput.Text += "<br/>S3.1.4.2: ";
            lblOutput.Text += calc.MultOfFive(number);
            lblOutput.Text += "<br/>S3.1.4.3: ";
            lblOutput.Text += calc.MultOfThreeFive(number);
            lblOutput.Text += "<br/>S3.1.5: ";
            lblOutput.Text += calc.Fibonacci(number);

            //Used to demonstrated Assertion in Coded UI Test
            lblSuccess.Text = "Success";

        }
 
    }
}