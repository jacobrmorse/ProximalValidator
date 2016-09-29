using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proximal_Validator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog1.FileName;
            procMemFileName(fileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        void procMemFileName(string FileName)
        {
            MemberFileTxtbx.Text = FileName;
        }

        void procIndFileName(string FileName)
        {
            IndFileTxtbx.Text = FileName;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog1.FileName;
            procIndFileName(fileName);
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            // Validate character lengths where required

            // Validate character type where required

            // Validate empty fields for 
        }
    }
}
