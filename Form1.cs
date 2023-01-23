using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        //constant values
        const decimal TICKET_A = 15m;
        const decimal TICKET_B = 12m;
        const decimal TICKET_C = 9m;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //on click calculate all revenue
            //clas a revenue
            //DEFINE CLASS TOTAL, if condition in case textbox is left empty
            decimal classATotal;
            if (string.IsNullOrEmpty(classATextBox.Text))
            {
                classATotal = 0m;
            }
            else
            {
                int classA = int.Parse(classATextBox.Text);

                classATotal = classA * TICKET_A;
            }


            //class B turn to int and find revenue

            decimal classBTotal;
            if (string.IsNullOrEmpty(classBTextBox.Text))
            {
                classBTotal = 0m;
            }
            else
            {
                int classB = int.Parse(classBTextBox.Text);

                classBTotal = classB * TICKET_B;
            }

            //class C turn to int and find its revenue
            //if condition in case there is an empty text box

            decimal classCTotal;
            if (string.IsNullOrEmpty(classCTextBox.Text))
            {
                classCTotal = 0m;
            }
            else
            {
                int classC = int.Parse(classCTextBox.Text);

                classCTotal = classC * TICKET_C;
            }
           

            //add these revenue totals to their corresponding label box
            //add "c" to use the currency format
            revenueALabel.Text  = classATotal.ToString("c");
            revenueBLabel.Text = classBTotal.ToString("c");
            revenueCLabel.Text = classCTotal.ToString("c");

            //get total revenue
        //add all the classes totals
         decimal total = classATotal + classBTotal+ classCTotal;
            //add the total to the label box
            totalRevenueLabel.Text = total.ToString("c");


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //on click clear the labels
            totalRevenueLabel.Text = "";
            revenueALabel.Text = "";
            revenueBLabel.Text = "";
            revenueCLabel.Text = "";

            //clear the text boxes
            classATextBox.Clear();
            classBTextBox.Clear();
            classCTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
