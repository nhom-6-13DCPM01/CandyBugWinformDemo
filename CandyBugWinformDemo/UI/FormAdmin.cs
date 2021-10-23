﻿using CandyBugWinformDemo.Control;
using CandyBugWinformDemo.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public FormAdmin(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            Load();
        }

        void Load()
        {
            dataGridView1.DataSource = accountList;            
            LoadAccount();
            AddAccountBinding();
        }

        void ChangeAccount(Account acc)
        {
            kryptonTextBox1.Text = LoginAccount.Username;
            kryptonTextBox2.Text = LoginAccount.Displayname;
        }

        void AddAccountBinding()
        {
            kryptonTextBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            kryptonTextBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            kryptonNumericUpDown1.DataBindings.Add(new Binding("Value", dataGridView1.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }


        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
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

        
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = kryptonTextBox1.Text;
            string displayName = kryptonTextBox2.Text;
            int type = (int)kryptonNumericUpDown1.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {

            string userName = kryptonTextBox1.Text;
            string displayName = kryptonTextBox2.Text;
            int type = (int)kryptonNumericUpDown1.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

            string userName = kryptonTextBox1.Text;

            DeleteAccount(userName);

        }

        private void btbResetPassword_Click(object sender, EventArgs e)
        {
            string userName = kryptonTextBox1.Text;
            ResetPass(userName);
        }
    }
}
