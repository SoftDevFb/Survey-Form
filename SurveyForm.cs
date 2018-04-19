using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace Proj7SurveyForm
{
    public partial class SurveyForm : Form
    {
        //private static object secondStatement;

        public SurveyForm()
        {
            InitializeComponent();
        }

        //Name Textbox
        private void txtBxName_TextChanged(object sender, EventArgs e)
        {
            this.txtBxName.Text = txtBxName.Text;
        }

        //C# Radio Button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Web Dev Radio Button
        private void radWebDev_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Systems radio button
        private void radSystems_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Advisor Checkbox
        private void chkBxAdvisor_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Submit Button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for completing this survey "
                + txtBxName.ToString() + ". Your appointment with your advisor is set for "
                + dateTimePicker1.ToString() + ". You are currently registered for "
                + numericUpDown1.Value.ToString() + " classes this semester. Good luck!");
            //ReturnSubmitButtonString;
            if (chkBxAdvisor.Checked)
                MessageBox.Show("Also, good job speaking with your advisor!");
            if (radSystems.Checked)
                MessageBox.Show("You're Going To Love Systems Design!");
            if (radWebDev.Checked)
                MessageBox.Show("Have Fun In Web Dev!");
            if (radCSharp.Checked)
                MessageBox.Show("Good Luck in C#!");
        }

        //Calendar
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
        }

        //Numeric Up Down Scroll Box
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString();
        }

        //Clear Button
        private void button2_Click(object sender, EventArgs e)
        {
            txtBxName.Text = "";
            radCSharp.Checked = false;
            radWebDev.Checked = false;
            radSystems.Checked = false;
            numericUpDown1.TextAlign = 0;
            chkBxAdvisor.Text = "";
        }
        #region/* //Delegate to replace Submit Button string   */    
   //static void Main(string[] args)
   //     {            
   //         ReturnSubmitButtonString saying1 = new
   //             ReturnSubmitButtonString(AHeading);
   //         ReturnSubmitButtonString saying2 = new
   //             ReturnSubmitButtonString(txtBxName.ToString());
   //         ReturnSubmitButtonString saying3 = new
   //             ReturnSubmitButtonString(secondStatement);
   //         ReturnSubmitButtonString saying4 = new
   //             ReturnSubmitButtonString(dateTimePicker1.ToString());
   //         ReturnSubmitButtonString saying5 = new
   //             ReturnSubmitButtonString(ThirdStatement);
   //         ReturnSubmitButtonString saying6 = new
   //             ReturnSubmitButtonString(numericUpDown1.Value.ToString());
   //         ReturnSubmitButtonString saying7 = new
   //             ReturnSubmitButtonString(EndStatement);
   //         WriteLine(AHeading() + saying2() + saying3() + saying4() + saying5() + saying6() + saying7());
   //         ReadLine();
   //     }

   //     private class ReturnSubmitButtonString
   //     {   //Intellisense generated code
   //         private Func<string> aHeading;
   //         private object secondStatement;

   //         public ReturnSubmitButtonString(Func<string> aHeading)
   //         {
   //             this.aHeading = aHeading;
   //         }

   //         public ReturnSubmitButtonString(object secondStatement)
   //         {
   //             this.secondStatement = secondStatement;
   //         }
   //     }
    

   //     //Method to return string
   //     static string AHeading()
   //     {
   //         return "Thank you for completing this survey ";
   //     }

   //     //Method to return 2nd statement in submit button string sequence
   //     static string SecondStatement()
   //     {
   //         return ". Your appointment with your advisor is set for ";
   //     }

   //     //Method to return third statement in sequence
   //     static string ThirdStatement()
   //     {
   //         return ". You are currently registered for ";
   //     }

   //     //Method to return end statement in sequence
   //     static string EndStatement()
   //     {
   //         return " classes this semester. Good luck!";
   //     }
        #endregion 
    }//End of Class

}//End of Solution
