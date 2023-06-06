namespace CoBan_ToolTip_HelpProvider_ErrorProvider
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.ckbPassword = new System.Windows.Forms.CheckBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(191, 18);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(361, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cửa sổ đăng nhập";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên đăng nhập:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật khẩu:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(267, 85);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(521, 22);
			this.txtUsername.TabIndex = 3;
			this.toolTip1.SetToolTip(this.txtUsername, "Chỉ được nhập kí tự a-z và 0-9");
			this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
			this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
			this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(267, 165);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '0';
			this.txtPassword.Size = new System.Drawing.Size(521, 22);
			this.txtPassword.TabIndex = 4;
			this.toolTip1.SetToolTip(this.txtPassword, "Chỉ được nhập kí tự từ 0-9");
			this.txtPassword.Enter += new System.EventHandler(this.txtUsername_Enter);
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
			this.txtPassword.Leave += new System.EventHandler(this.txtUsername_Leave);
			// 
			// ckbPassword
			// 
			this.ckbPassword.AutoSize = true;
			this.ckbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbPassword.Location = new System.Drawing.Point(267, 232);
			this.ckbPassword.Name = "ckbPassword";
			this.ckbPassword.Size = new System.Drawing.Size(235, 33);
			this.ckbPassword.TabIndex = 5;
			this.ckbPassword.Text = "Hiển thị mật khẩu";
			this.ckbPassword.UseVisualStyleBackColor = true;
			this.ckbPassword.CheckedChanged += new System.EventHandler(this.ckbPassword_CheckedChanged);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(40, 301);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(320, 51);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "&Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
			this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(468, 301);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(320, 51);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "&Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(821, 383);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.ckbPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tooltip HelpProvider ErorProvider";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox ckbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

