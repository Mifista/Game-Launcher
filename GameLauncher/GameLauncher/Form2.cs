using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            label2.Text = DefaultPath;
        }

        string DefaultPath = "G:/Anomaly/bin/AnomalyDX10AVX.exe";
        string path;

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            if (path == null)
            {
                process.StartInfo.FileName = DefaultPath;
            }

            else
            {
                process.StartInfo.FileName = path;
            }

            process.Start();
            Environment.Exit(0);
            //if (process. == true)
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Program.frm3.openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            label2.Text = path;

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void Launcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
