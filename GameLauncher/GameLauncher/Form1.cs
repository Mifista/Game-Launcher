using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class Login_Form : Form
    {
        //public FileStream database = new FileStream()
        public string login;
        public string password;
        public string log;
        public string pass;
        public string pathway = @"C:\CSharp\GLauncher\GameLauncher\GameLauncher\password.txt";

        public Login_Form()
        {
            InitializeComponent();
        }

         private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void actBtn_Click(object sender, EventArgs e)
        {
            log = Login.Text;
            pass = textBox1.Text;

            if (File.Exists(pathway))
            {

                using (StreamReader input = new StreamReader(pathway))
                {
                    login = input.ReadLine();
                    password = input.ReadLine();
                }

                if ((log == login) && (pass == password))
                {
                    this.Hide();
                    Program.frm3.Show();
                    
                }

                else
                {
                    Program.frm2.StartPosition = FormStartPosition.CenterParent;
                    Program.frm2.ShowDialog();
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             if (checkBox1.Checked == true){
                textBox1.UseSystemPasswordChar = false;
            }

            else textBox1.UseSystemPasswordChar = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void labelCheck1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
