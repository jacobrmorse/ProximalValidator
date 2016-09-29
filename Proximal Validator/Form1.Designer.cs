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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MemberFileTxtbx = new System.Windows.Forms.TextBox();
            this.IndFileTxtbx = new System.Windows.Forms.TextBox();
            this.MemberFileLbl = new System.Windows.Forms.Label();
            this.IndFileLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.MemberGrid = new System.Windows.Forms.DataGridView();
            this.ColCount = new System.Windows.Forms.Label();
            this.memberFileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.memberFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColCount2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberFileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberFileBindingSource)).BeginInit();
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
            // ValidateBtn
            // 
            this.ValidateBtn.AutoSize = true;
            this.ValidateBtn.Location = new System.Drawing.Point(143, 160);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(79, 23);
            this.ValidateBtn.TabIndex = 6;
            this.ValidateBtn.Text = "Validate Files";
            this.ValidateBtn.UseVisualStyleBackColor = true;
            this.ValidateBtn.Visible = false;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // MemberGrid
            // 
            this.MemberGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MemberGrid.AllowUserToAddRows = false;
            this.MemberGrid.AllowUserToDeleteRows = false;
            this.MemberGrid.AllowUserToResizeColumns = false;
            this.MemberGrid.AllowUserToResizeRows = false;
            this.MemberGrid.AutoGenerateColumns = false;
            this.MemberGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MemberGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MemberGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.MemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberGrid.DataSource = this.memberFileBindingSource1;
            this.MemberGrid.Location = new System.Drawing.Point(126, 212);
            this.MemberGrid.Name = "MemberGrid";
            this.MemberGrid.ReadOnly = true;
            this.MemberGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberGrid.Size = new System.Drawing.Size(240, 150);
            this.MemberGrid.TabIndex = 7;
            this.MemberGrid.VisibleChanged += new System.EventHandler(this.MemberGrid_VisibleChanged);
            // 
            // ColCount
            // 
            this.ColCount.AutoSize = true;
            this.ColCount.Location = new System.Drawing.Point(404, 224);
            this.ColCount.Name = "ColCount";
            this.ColCount.Size = new System.Drawing.Size(50, 13);
            this.ColCount.TabIndex = 8;
            this.ColCount.Text = "ColCount";
            // 
            // memberFileBindingSource1
            // 
            this.memberFileBindingSource1.DataSource = typeof(Proximal_Validator.MemberFile);
            // 
            // memberFileBindingSource
            // 
            this.memberFileBindingSource.DataSource = typeof(Proximal_Validator.MemberFile);
            // 
            // ColCount2
            // 
            this.ColCount2.AutoSize = true;
            this.ColCount2.Location = new System.Drawing.Point(404, 249);
            this.ColCount2.Name = "ColCount2";
            this.ColCount2.Size = new System.Drawing.Size(56, 13);
            this.ColCount2.TabIndex = 9;
            this.ColCount2.Text = "ColCount2";
            // 
            // Form1
            // 
            this.AcceptButton = this.ValidateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(507, 396);
            this.Controls.Add(this.ColCount2);
            this.Controls.Add(this.ColCount);
            this.Controls.Add(this.MemberGrid);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IndFileLbl);
            this.Controls.Add(this.MemberFileLbl);
            this.Controls.Add(this.IndFileTxtbx);
            this.Controls.Add(this.MemberFileTxtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MemberGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberFileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberFileBindingSource)).EndInit();
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
        private System.Windows.Forms.Button ValidateBtn;
        private System.Windows.Forms.DataGridView MemberGrid;
        private System.Windows.Forms.BindingSource memberFileBindingSource1;
        private System.Windows.Forms.BindingSource memberFileBindingSource;
        private System.Windows.Forms.Label ColCount;
        public System.Windows.Forms.Label ColCount2;
    }
}

