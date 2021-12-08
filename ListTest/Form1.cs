using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ListTest
{
    
    public partial class Form1 : Form
    {
        List<string> students = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //students.Add(inputBox.Text);

            //originalOutput.Text = "";

            //for (int i = 0; i< students.Count; i++)
            //{
            //    originalOutput.Text += $"{students[i]}\n";
            //}

            //students.Sort();

            //sortOutput.Text = "";

            //for (int i = 0; i < students.Count; i++)
            //{
            //    sortOutput.Text += $"{students[i]}\n";
            //}


        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // originalOutput.Text = "Original Order\n**************\n";

            students.Add(inputBox.Text);

            originalOutput.Text = "";

            for (int i = 0; i < students.Count; i++)
            {
                originalOutput.Text += $"{students[i]}\n";
            }

            students.Sort();

            sortOutput.Text = "";

            for (int i = 0; i < students.Count; i++)
            {
                sortOutput.Text += $"{students[i]}\n";
            }

            students.Reverse();

            reverseOutput.Text = "";

            for (int i = 0; i < students.Count; i++)
            {
                reverseOutput.Text += $"{students[i]}\n";
            }
        }

      
        private void reverseOutput_Click(object sender, EventArgs e)
        {
        //    if (students.Contains(inputBox.Text))
        //    {
        //        students.Remove(inputBox.Text);

        //        originalOutput.Text = "";
        //        sortOutput.Text = "Item Removed";
        //        reverseOutput.Text = "";
        //    }
        //    else
        //    {
        //        originalOutput.Text = "";
        //        sortOutput.Text = "Item does not Exist";
        //        reverseOutput.Text = "";
        //    }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (students.Contains(inputBox.Text))
            {
                students.Remove(inputBox.Text);

                originalOutput.Text = "";
                sortOutput.Text = "Item Removed";
                reverseOutput.Text = "";
            }
            else
            {
                originalOutput.Text = "";
                sortOutput.Text = "Item does not Exist";
                reverseOutput.Text = "";
            }
        }
    }
}
