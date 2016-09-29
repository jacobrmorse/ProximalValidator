using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace Proximal_Validator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        { }

        bool ValidateBtnBool1 { get; set; }
        bool ValidateBtnBool2 { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MemberFileTxtbx.Text = openFileDialog1.FileName;
            ValidateBtnBool1 = true;

            if (ValidateBtnBool2 == true)
            { ValidateBtn.Visible = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            IndFileTxtbx.Text = openFileDialog1.FileName;
            ValidateBtnBool2 = true;

            if (ValidateBtnBool1 == true)
            { ValidateBtn.Visible = true; }
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            // Read files to tables
            MemberFile.FileName = MemberFileTxtbx.Text;
            IndividualFile.FileName = IndFileTxtbx.Text;
            MemberFile.setup();
            IndividualFile.setup();

            MemberGrid.DataSource = MemberFile.MemFile;
            MemberGrid.AutoGenerateColumns = true;
            MemberGrid.Update();

            ColCount.Text = MemberGrid.ColumnCount.ToString();
            ColCount2.Text = MemberFile.MemFile.Columns.Count.ToString();

            // Validate character lengths where required
            MemberFile.ValidFieldLength();
            IndividualFile.ValidFieldLength();

            // Validate character type where required
            MemberFile.CharacterType();
            IndividualFile.CharacterType();

            // Validate empty fields to ensure not required
            MemberFile.RequiredFields();
            IndividualFile.RequiredFields();

            // Validate comparison btwn files
            Comparison.CompareFiles();
        }

        private void MemberGrid_VisibleChanged(object sender, EventArgs e)
        {}
    }
}