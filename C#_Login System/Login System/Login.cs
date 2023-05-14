using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Login : Form
    {
        private string username;
        private string password;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ユーザー名とパスワード
            username = "Unknown";
            password = "1234567890";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ユーザー名とパスワードが合っているか判別
            if ((username_box.Text == username) && (password_box.Text == password))
            {
                MessageBox.Show("ログインに成功しました", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //間違っていたらエラー文を返す
            else 
            {
                MessageBox.Show("ユーザー名かパスワードまたはその両方が間違っています", "失敗", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //この場合ではどちらが間違っているか分からない一般的なシステムだが,以下のコードでどちらが分かっているか判別することも可
            //if (username_box.Text == username)
            //{
            //    if (password_box.Text == password)
            //    {
            //        MessageBox.Show("ログインに成功しました", "成功", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        MessageBox.Show("パスワードが間違っています", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("ユーザー名が間違っています", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
