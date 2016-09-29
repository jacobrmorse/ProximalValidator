namespace Proximal_Validator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MemberFileTxtbx = new System.Windows.Forms.TextBox();
            this.IndFileTxtbx = new System.Windows.Forms.TextBox();
            this.MemberFileLbl = new System.Windows.Forms.Label();
            this.IndFileLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.Filter = "CSV files|*.csv";
            this.openFileDialog1.InitialDirectory = "%userprofile%\\documents";
            this.openFileDialog1.Title = "Member File Validation";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MemberFileTxtbx
            // 
            this.MemberFileTxtbx.Location = new System.Drawing.Point(16, 40);
            this.MemberFileTxtbx.Name = "MemberFileTxtbx";
            this.MemberFileTxtbx.Size = new System.Drawing.Size(206, 20);
            this.MemberFileTxtbx.TabIndex = 0;
            this.MemberFileTxtbx.Text = "Choose a Member File";
            // 
            // IndFileTxtbx
            // 
            this.IndFileTxtbx.Location = new System.Drawing.Point(16, 112);
            this.IndFileTxtbx.Name = "IndFileTxtbx";
            this.IndFileTxtbx.Size = new System.Drawing.Size(206, 20);
            this.IndFileTxtbx.TabIndex = 1;
            this.IndFileTxtbx.Text = "Choose an Individual File";
            // 
            // MemberFileLbl
            // 
            this.MemberFileLbl.AutoSize = true;
            this.MemberFileLbl.Location = new System.Drawing.Point(24, 24);
            this.MemberFileLbl.Name = "MemberFileLbl";
            this.MemberFileLbl.Size = new System.Drawing.Size(108, 13);
            this.MemberFileLbl.TabIndex = 2;
            this.MemberFileLbl.Text = "Member File Location";
            // 
            // IndFileLbl
            // 
            this.IndFileLbl.AutoSize = true;
            this.IndFileLbl.Location = new System.Drawing.Point(24, 96);
            this.IndFileLbl.Name = "IndFileLbl";
            this.IndFileLbl.Size = new System.Drawing.Size(115, 13);
            this.IndFileLbl.TabIndex = 3;
            this.IndFileLbl.Text = "Individual File Location";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(228, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open Member File...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(228, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Open Individual File...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "csv";
            this.openFileDialog2.Filter = "CSV files|*.csv";
            this.openFileDialog2.InitialDirectory = "%userprofile%\\documents";
            this.openFileDialog2.Title = "Individual File Validation";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.AutoSize = true;
            this.ValidateBtn.Location = new System.Drawing.Point(143, 160);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(79, 23);
            this.ValidateBtn.TabIndex = 6;
            this.ValidateBtn.Text = "Validate Files";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.UseWaitCursor = true;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.ValidateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(507, 307);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IndFileLbl);
            this.Controls.Add(this.MemberFileLbl);
            this.Controls.Add(this.IndFileTxtbx);
            this.Controls.Add(this.MemberFileTxtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox MemberFileTxtbx;
        private System.Windows.Forms.TextBox IndFileTxtbx;
        private System.Windows.Forms.Label MemberFileLbl;
        private System.Windows.Forms.Label IndFileLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button ValidateBtn;
    }
}

