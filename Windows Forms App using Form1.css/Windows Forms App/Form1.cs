using System;
using System.Windows.Forms;

namespace Windows_Forms_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("<name> here, this is my Slidely AI task");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // This method can be left empty or used to handle label2 click events
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // This method can be left empty or used to handle groupBox1 enter events
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // This method can be left empty or used to handle label3 click events
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = tb_firstname.Text;
            string lastname = tb_lastname.Text;
            string selected = "";

            foreach (RadioButton rb in gb_option.Controls)
            {
                if (rb.Checked)
                {
                    selected = rb.Text;
                }
            }

            Console.WriteLine("First Name is: " + firstname);
            Console.WriteLine("Last Name is: " + lastname);
            Console.WriteLine("Radio Value is: " + selected);

            // Show message box with the entered information
            MessageBox.Show("First Name: " + firstname + "\nLast Name: " + lastname + "\nSelected Option: " + selected, "User Information");
        }
    }
}
