using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterrrrr
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "Big" && (txtPassword.Text == "Chikwa")))//login
            {
                using (StreamWriter sw = new StreamWriter("Username1.txt"))
                {
                    sw.WriteLine(txtUsername.Text);

                }
                //hide login form then go to main form
                this.Hide();
                Form1 fm = new Form1();
                fm.Show();

            }


            else if ((txtUsername.Text == "Mr" && txtPassword.Text == "Man"))

            {
                //hide the form after the user has signed in and transfer to another form.
                this.Hide();
                Form1 fm = new Form1();
                fm.Show();

            }


            //error message and clear of inputs if incorrect.
            else
            { MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            txtUsername.Clear();
            txtPassword.Clear();

        }


        //show previous username.
        private void Login_Load(object sender, EventArgs e)
        {

            using (StreamWriter ffg = new StreamWriter("Username1.txt")) 
            {

                ffg.WriteLine(txtUsername.Text);



            }
        }
    }
}

