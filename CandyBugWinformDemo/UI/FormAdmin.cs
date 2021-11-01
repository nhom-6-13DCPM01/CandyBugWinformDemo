using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandyBugWinformDemo.Control;
using CandyBugWinformDemo.Object;
using ComponentFactory.Krypton.Toolkit;

namespace CandyBugWinformDemo.NewFolder1
{
    public partial class FormAdmin : Form
    {
        BindingSource accountList = new BindingSource();
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        //constructor
        public FormAdmin(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            Load();
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        void Load()
        {
            dataGridView1.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }

        public List<Account> SearchAccountByName(string name)
        {

            List<Account> listAccount = AccountDAO.Instance.SearchAccountByName(name);

            return listAccount;
        }

        void ChangeAccount(Account acc)
        {
            /*kryptonTextBox1.Text = LoginAccount.Username;
            kryptonTextBox2.Text = LoginAccount.Displayname;*/
        }

        void AddAccountBinding()
        {
            kryptonTextBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            kryptonTextBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            /*kryptonNumericUpDown1.DataBindings.Add(new Binding("Value", dataGridView1.DataSource, "Type", true, DataSourceUpdateMode.Never));*/
        }


        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string userName, string displayName, string passWord, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, passWord, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, string passWord, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.Username.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
    }
}
