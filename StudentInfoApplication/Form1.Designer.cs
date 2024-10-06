namespace StudentInfoApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TBStudentID = new TextBox();
            TBLastName = new TextBox();
            TBFirstName = new TextBox();
            button1 = new Button();
            LBStudentID = new ListBox();
            LBFirstName = new ListBox();
            LBLastName = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Constantia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 48);
            label1.Name = "label1";
            label1.Size = new Size(119, 26);
            label1.TabIndex = 0;
            label1.Text = "Student ID*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkCyan;
            label2.Font = new Font("Constantia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(285, 48);
            label2.Name = "label2";
            label2.Size = new Size(113, 26);
            label2.TabIndex = 1;
            label2.Text = "Last name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkCyan;
            label3.Font = new Font("Constantia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(511, 48);
            label3.Name = "label3";
            label3.Size = new Size(116, 26);
            label3.TabIndex = 2;
            label3.Text = "First name*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkCyan;
            label4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 184);
            label4.Name = "label4";
            label4.Size = new Size(122, 19);
            label4.TabIndex = 3;
            label4.Text = "Student ID List*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkCyan;
            label5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(250, 184);
            label5.Name = "label5";
            label5.Size = new Size(124, 19);
            label5.TabIndex = 4;
            label5.Text = "First Name List*";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkCyan;
            label6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(469, 184);
            label6.Name = "label6";
            label6.Size = new Size(121, 19);
            label6.TabIndex = 5;
            label6.Text = "Last Name List*";
            // 
            // TBStudentID
            // 
            TBStudentID.BackColor = Color.Silver;
            TBStudentID.Location = new Point(35, 94);
            TBStudentID.Name = "TBStudentID";
            TBStudentID.Size = new Size(180, 23);
            TBStudentID.TabIndex = 6;
            // 
            // TBLastName
            // 
            TBLastName.BackColor = SystemColors.ScrollBar;
            TBLastName.Location = new Point(250, 94);
            TBLastName.Name = "TBLastName";
            TBLastName.Size = new Size(188, 23);
            TBLastName.TabIndex = 7;
            // 
            // TBFirstName
            // 
            TBFirstName.BackColor = Color.Silver;
            TBFirstName.Location = new Point(469, 94);
            TBFirstName.Name = "TBFirstName";
            TBFirstName.Size = new Size(183, 23);
            TBFirstName.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(601, 141);
            button1.Name = "button1";
            button1.Size = new Size(124, 32);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LBStudentID
            // 
            LBStudentID.BackColor = Color.Silver;
            LBStudentID.FormattingEnabled = true;
            LBStudentID.ItemHeight = 15;
            LBStudentID.Location = new Point(35, 229);
            LBStudentID.Name = "LBStudentID";
            LBStudentID.Size = new Size(180, 199);
            LBStudentID.TabIndex = 10;
            // 
            // LBFirstName
            // 
            LBFirstName.BackColor = Color.Silver;
            LBFirstName.FormattingEnabled = true;
            LBFirstName.ItemHeight = 15;
            LBFirstName.Location = new Point(250, 229);
            LBFirstName.Name = "LBFirstName";
            LBFirstName.Size = new Size(188, 199);
            LBFirstName.TabIndex = 11;
            LBFirstName.SelectedIndexChanged += LBFirstName_SelectedIndexChanged;
            // 
            // LBLastName
            // 
            LBLastName.BackColor = Color.Silver;
            LBLastName.FormattingEnabled = true;
            LBLastName.ItemHeight = 15;
            LBLastName.Location = new Point(469, 229);
            LBLastName.Name = "LBLastName";
            LBLastName.Size = new Size(183, 199);
            LBLastName.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(LBLastName);
            Controls.Add(LBFirstName);
            Controls.Add(LBStudentID);
            Controls.Add(button1);
            Controls.Add(TBFirstName);
            Controls.Add(TBLastName);
            Controls.Add(TBStudentID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Info";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TBStudentID;
        private TextBox TBLastName;
        private TextBox TBFirstName;
        private Button button1;
        private ListBox LBStudentID;
        private ListBox LBFirstName;
        private ListBox LBLastName;
    }
}
