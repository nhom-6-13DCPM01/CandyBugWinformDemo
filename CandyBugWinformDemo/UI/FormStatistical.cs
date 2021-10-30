using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        //thuộc tính
        SqlConnection connection;
        String connectionString = "Data Source=nhomsix.database.windows.net;Initial Catalog=QLBK;User ID=nhom6;Password=123456789aA";
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();

        //load dữ liệu lên data grid view
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
        //Tính tổng tiền thu được
        public void load_data_tong_tien_so_lan_orders()
        {
            double payment = 0;
            for(int i = 0; i < dataGridViewStatistical.Rows.Count; i++)
            {
                payment += Convert.ToDouble(dataGridViewStatistical.Rows[i].Cells[4].Value);
            }
            textBoxTongTien.Text = String.Format(CultureInfo.CreateSpecificCulture("vi-vn"), "{0:C}", payment);
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
        }
        //chỉnh sửa bảng
        public void chinh_sua_bang()
        {
            //Chỉnh sửa header test
            dataGridViewStatistical.Columns[0].HeaderText = "ID sản phẩm";
            dataGridViewStatistical.Columns[1].HeaderText = "Sản phẩm";
            dataGridViewStatistical.Columns[2].HeaderText = "Số lượng";
            dataGridViewStatistical.Columns[3].HeaderText = "Giá sản phẩm";
            dataGridViewStatistical.Columns[4].HeaderText = "Tiền thanh toán";
            dataGridViewStatistical.Columns[5].HeaderText = "Ngày mua";
            //Chỉnh sửa width
            dataGridViewStatistical.Columns[0].Width = (int)(dataGridViewStatistical.Width * 0.15);
            dataGridViewStatistical.Columns[1].Width = (int)(dataGridViewStatistical.Width * 0.13);
            dataGridViewStatistical.Columns[2].Width = (int)(dataGridViewStatistical.Width * 0.14);
            dataGridViewStatistical.Columns[3].Width = (int)(dataGridViewStatistical.Width * 0.17);
            dataGridViewStatistical.Columns[4].Width = (int)(dataGridViewStatistical.Width * 0.17);
            dataGridViewStatistical.Columns[5].Width = (int)(dataGridViewStatistical.Width * 0.13);
        }
        private void FormStatistical_Load(object sender, EventArgs e)
        {
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro");
            load_data_tong_tien_so_lan_orders();
            chinh_sua_bang();
        }

        //Khu TextBox
        //Khi người dùng click vào ô viết tìm kiếm thì sẽ làm mất chữ và đổi màu chữ sang đen
        private void textBoxTimKiem_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = null;
            textBoxTimKiem.ForeColor = Color.Black;
        }
        //Khi người dùng nhấn enter thì sẽ tìm kiếm kết quả theo id và name
        private void textBoxTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                char c = Convert.ToChar(textBoxTimKiem.Text.ElementAt(1));
                if (c >= 48 && c <= 57)
                {
                    load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro where Product.idPro = '" + Convert.ToInt32(textBoxTimKiem.Text) + "'");
                }
                else 
                {
                    load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro where Product.name = N'" + textBoxTimKiem.Text + "'");
                }
            }
        }
        //Khi người dùng xóa hay nhấn chữ nào đó thì sẽ làm mới bảng
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        { 
            FormStatistical_Load(sender,e);
        }
        //Khi người dùng click phần ngoài trong khu phần thông tin thì sẽ đặt lại text cho ô tìm kiếm
        private void panelHienThiThongTIn_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
        }

        //Khu Button
        //Nhấn nút này sẽ làm mới dữ liệu bảng danh sách
        private void btnReset_Click(object sender, EventArgs e)
        {
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro");
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
        }

        //Khu date tim picker
        //thay đổi dữ liệu trên chọn ngày from thì sẽ hiển thị kết quả lên bảng danh sách
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro Where Orders.DateCheckOut >= '" + dateTimePickerFrom.Value + "' AND Orders.DateCheckOut <= '" + dateTimePickerTo.Value + "'");
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
            load_data_tong_tien_so_lan_orders();
        }
        //thay đổi dữ liệu trên chọn ngày to thì sẽ hiển thị kết quả lên bảng danh sách
        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            textBoxTimKiem.ForeColor = Color.DarkGray;
            load_data("SELECT Product.idPro, Product.name, Orders.quantity, CONVERT(nvarchar(50), CAST(Product.price as money),1), CONVERT(nvarchar(50), CAST(Product.price * Orders.quantity as money),1), Orders.DateCheckOut FROM Orders INNER JOIN Product ON Orders.idProduct = Product.idPro Where Orders.DateCheckOut <= '" + dateTimePickerTo.Value + "' AND Orders.DateCheckOut >= '" + dateTimePickerFrom.Value + "'");
            textBoxTongOrder.Text = Convert.ToString(dataGridViewStatistical.Rows.Count - 1);
            load_data_tong_tien_so_lan_orders();
        }
    }
}
