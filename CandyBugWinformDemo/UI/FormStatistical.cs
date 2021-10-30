using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyBugWinformDemo.NewFolder1
{
    public partial class FormStatistical : Form
    {
       
            
        public FormStatistical()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        String connectionString = "Data Source=nhomsix.database.windows.net;Initial Catalog=QLBK;User ID=nhom6;Password=123456789aA";
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();

        //load các data lên data grid view
        public void load_data(String cmd)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            //cmd này là một câu lệnh query
            command.CommandText = cmd;
            //adapter sẽ chọn lệnh từ cmd để excute
            adapter.SelectCommand = command;
            //xóa bảng cũ
            dataTable.Clear();
            //đổ dữ liệu vào bảng
            adapter.Fill(dataTable);
            dataGridViewStatistical.DataSource = dataTable;
            connection.Close();
        }

        public void load_data_tong_tien()
        {
            double payment = 0;
            for(int i = 0; i < dataGridViewStatistical.Rows.Count; i++)
            {
                payment += Convert.ToDouble(dataGridViewStatistical.Rows[i].Cells[4].Value);
            }
            textBoxTongTien.Text = payment.ToString();
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, Product.price, Product.price * Orders.quantity AS Payment, Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro");
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
            load_data_tong_tien();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = null;
            textBoxTimKiem.ForeColor = Color.Black;
        }

        private void textBoxTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                char c = Convert.ToChar(textBoxTimKiem.Text.ElementAt(1));
                if (c >= 48 && c <= 57)
                {
                    load_data("SELECT Product.idPro, Product.name, Orders.quantity, Product.price, Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro where Product.idPro = '" + Convert.ToInt32(textBoxTimKiem.Text) + "'");
                }
                else 
                {
                    load_data("SELECT Product.idPro, Product.name, Orders.quantity, Product.price, Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro where Product.name = N'" + textBoxTimKiem.Text + "'");
                }
            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        { 
            FormStatistical_Load(sender,e);
        }

        private void panelHienThiThongTIn_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, Product.price, Product.price * Orders.quantity AS Payment, Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro");
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, Product.price, Product.price * Orders.quantity AS Payment, Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro Where Orders.DateCheckOut >= '" + dateTimePickerFrom.Value + "' AND Orders.DateCheckOut <= '" + dateTimePickerTo.Value + "'");
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
            load_data_tong_tien();
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, Product.price, Product.price * Orders.quantity AS Payment, Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro Where Orders.DateCheckOut <= '" + dateTimePickerTo.Value + "' AND Orders.DateCheckOut >= '" + dateTimePickerFrom.Value + "'");
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
            load_data_tong_tien();
        }
    }
}
