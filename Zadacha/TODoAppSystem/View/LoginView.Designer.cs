namespace TODoAppSystem.View
{
    partial class LoginView
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
            this.Username = new System.Windows.Forms.Label();
            this.btn_Username = new System.Windows.Forms.TextBox();
            this.btn_Password = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username.Location = new System.Drawing.Point(32, 35);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(172, 37);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // btn_Username
            // 
            this.btn_Username.Location = new System.Drawing.Point(25, 93);
            this.btn_Username.Multiline = true;
            this.btn_Username.Name = "btn_Username";
            this.btn_Username.Size = new System.Drawing.Size(192, 43);
            this.btn_Username.TabIndex = 1;
            // 
            // btn_Password
            // 
            this.btn_Password.Location = new System.Drawing.Point(25, 240);
            this.btn_Password.Multiline = true;
            this.btn_Password.Name = "btn_Password";
            this.btn_Password.Size = new System.Drawing.Size(192, 43);
            this.btn_Password.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(32, 182);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(166, 37);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Login.Location = new System.Drawing.Point(423, 342);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(234, 65);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Register.Location = new System.Drawing.Point(65, 342);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(234, 65);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.btn_Username);
            this.Controls.Add(this.Username);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox btn_Username;
        private System.Windows.Forms.TextBox btn_Password;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
    }
}