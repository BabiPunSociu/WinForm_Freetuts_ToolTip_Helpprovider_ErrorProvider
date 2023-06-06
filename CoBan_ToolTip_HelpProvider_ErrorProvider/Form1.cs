using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoBan_ToolTip_HelpProvider_ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar < 'a' || e.KeyChar > 'z') && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }    
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }    
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            btn.BackColor = Color.LightPink;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            btn.BackColor = Color.White;
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Bạn phải nhập username");
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Bạn phải nhập password nhiều hơn 8 kí tự");
                txtPassword.Focus();
                return;
            }
            MessageBox.Show("Đang đăng nhập");
        }

        private void ckbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPassword.Checked)
                txtPassword.PasswordChar = (char)0;     // Hiện mật khẩu
            else
                txtPassword.PasswordChar = '0';
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox) sender;
            t.BackColor = Color.LightPink;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtUsername, "Chỉ được nhập ký tự a-z và 0-9");
            toolTip1.SetToolTip(txtPassword, "Chỉ được nhập ký tự từ 0-9");
            helpProvider1.HelpNamespace = "https://www.facebook.com/tulien.thienxa";
        }
    }
}
