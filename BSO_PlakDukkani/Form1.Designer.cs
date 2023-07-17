namespace BSO_PlakDukkani
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
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPwd = new TextBox();
            button3 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            txtRePassword = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            txtLoginUsername = new TextBox();
            button4 = new Button();
            txtLoginPwd = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(177, 33);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(138, 29);
            txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 97);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 3;
            label2.Text = "Pwd : ";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(177, 89);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(138, 29);
            txtPwd.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(14, 211);
            button3.Name = "button3";
            button3.Size = new Size(301, 36);
            button3.TabIndex = 6;
            button3.Text = "Sign Up";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtRePassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(txtPwd);
            panel1.Location = new Point(23, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 260);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 154);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 8;
            label5.Text = "Re Pwd :";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(177, 146);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(138, 29);
            txtRePassword.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtLoginUsername);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(txtLoginPwd);
            panel2.Location = new Point(6, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 260);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 41);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 1;
            label3.Text = "User Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 105);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 3;
            label4.Text = "Pwd : ";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(177, 33);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(138, 29);
            txtLoginUsername.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(14, 211);
            button4.Name = "button4";
            button4.Size = new Size(301, 36);
            button4.TabIndex = 4;
            button4.Text = "Login";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtLoginPwd
            // 
            txtLoginPwd.Location = new Point(177, 97);
            txtLoginPwd.Name = "txtLoginPwd";
            txtLoginPwd.Size = new Size(138, 29);
            txtLoginPwd.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 306);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye Ol ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Location = new Point(470, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 306);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giriş Yap ";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.info;
            pictureBox1.Location = new Point(400, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(851, 335);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Giriş Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private TextBox txtPwd;
        private Button button3;
        private Panel panel1;
        private Label label5;
        private TextBox txtRePassword;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private TextBox txtLoginUsername;
        private Button button4;
        private TextBox txtLoginPwd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}