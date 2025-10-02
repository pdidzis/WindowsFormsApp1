namespace Seminar3
{
    partial class Register
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
            this.txt_usernamereg = new System.Windows.Forms.TextBox();
            this.txt_passwordregister = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nameregister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_emailregister = new System.Windows.Forms.TextBox();
            this.bt_register = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usernamereg
            // 
            this.txt_usernamereg.Location = new System.Drawing.Point(45, 138);
            this.txt_usernamereg.Name = "txt_usernamereg";
            this.txt_usernamereg.Size = new System.Drawing.Size(235, 20);
            this.txt_usernamereg.TabIndex = 0;
            this.txt_usernamereg.TextChanged += new System.EventHandler(this.txt_usernamereg_TextChanged);
            // 
            // txt_passwordregister
            // 
            this.txt_passwordregister.Location = new System.Drawing.Point(45, 194);
            this.txt_passwordregister.Name = "txt_passwordregister";
            this.txt_passwordregister.PasswordChar = '*';
            this.txt_passwordregister.Size = new System.Drawing.Size(235, 20);
            this.txt_passwordregister.TabIndex = 1;
            this.txt_passwordregister.TextChanged += new System.EventHandler(this.txt_passwordregister_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nameregister
            // 
            this.txt_nameregister.Location = new System.Drawing.Point(45, 81);
            this.txt_nameregister.Name = "txt_nameregister";
            this.txt_nameregister.Size = new System.Drawing.Size(235, 20);
            this.txt_nameregister.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(39, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(39, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(44, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txt_emailregister
            // 
            this.txt_emailregister.Location = new System.Drawing.Point(45, 251);
            this.txt_emailregister.Name = "txt_emailregister";
            this.txt_emailregister.Size = new System.Drawing.Size(235, 20);
            this.txt_emailregister.TabIndex = 7;
            // 
            // bt_register
            // 
            this.bt_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bt_register.Location = new System.Drawing.Point(45, 332);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(235, 68);
            this.bt_register.TabIndex = 8;
            this.bt_register.Text = "Register";
            this.bt_register.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Seminar3.Properties.Resources.hide;
            this.pictureBox1.Location = new System.Drawing.Point(286, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.txt_emailregister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nameregister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_passwordregister);
            this.Controls.Add(this.txt_usernamereg);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usernamereg;
        private System.Windows.Forms.TextBox txt_passwordregister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nameregister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_emailregister;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

