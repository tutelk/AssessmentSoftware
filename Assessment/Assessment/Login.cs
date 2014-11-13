using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Assessment
{
    public partial class Login : Form
    {
        public string userName;

        public Login()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = nameTextBox.Text.ToString().Trim();
            string userPwd = pwdTextBox.Text.ToString().Trim();
            string selectStr = "Select 姓名,密码 from _tbUser where  姓名= '" + userName + "'";

            string connStr = PublicParms.ConnStr;
            MySqlConnection conn = new MySqlConnection(connStr);
            
            MySqlCommand cmd = new MySqlCommand(selectStr, conn);
            try
            {
                conn.Open();                    //打开连接
                MySqlDataReader sdr = cmd.ExecuteReader(); //执行查询
                if (sdr.Read() && sdr.GetString(0)== userName)            //必选在执行sdr.Read()之后才能GetString     
                {
                    if (sdr.GetString(1)==userPwd) //密码正确
                    {
                        this.DialogResult = DialogResult.OK;
                        PublicParms.Uname = userName;
                    }
                    else                        //密码错误，给出提示信息！
                    {
                        MessageBox.Show("密码错误！");
                    }
                }
                else                            //用户不存在或用户名输入错误
                {
                    MessageBox.Show("用户名错误！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
