using CandyBugWinformDemo.Control;
using CandyBugWinformDemo.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyBugWinformDemo.NewFolder1
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            this.dataGridViewCurrentOrder.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewCurrentOrder.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.dataGridViewCurrentOrder.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewCurrentOrder.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void FormOrders_Load(object sender, EventArgs e)
        {
            addTab();
        }


        public void addTab()
        {
            List<Category> list = CategoryDAO.Instence.getListCategory();
            foreach (Category item in list)
            {
                TabPage tab = new TabPage(item.Name);
                FlowLayoutPanel flow = new FlowLayoutPanel() { Width = 630, Height = 550 };
                flow.AutoScroll = true;
                List<Product> listPro = ProductDAO.Intence.getListProductByCategory(item.Name);
                foreach (Product itemPro in listPro)
                {
                    Button btn = new Button() { Width = 190, Height = 190 };
                    Label lbName = new Label();
                    lbName.Text = itemPro.Name;
                    lbName.Location = new Point(2,2);
                    lbName.BackColor = Color.FromArgb(255, 224, 192);
                    lbName.Font = new Font("Microsoft Sans Serif",19,FontStyle.Bold);
                    lbName.ForeColor = Color.Black;
                    lbName.AutoSize = true;
                    Label lbPrice= new Label();
                    lbPrice.Text = itemPro.Price.ToString() + " ₫";
                    lbPrice.Location = new Point(3, 165);
                    lbPrice.ForeColor = Color.FromArgb(192, 64,0);
                    lbPrice.Font = new Font("Microsoft Sans Serif",13.8F,FontStyle.Bold);
                    lbPrice.BackColor = Color.LightGray;
                    lbPrice.AutoSize = true;
                    btn.Controls.Add(lbName);
                    btn.Controls.Add(lbPrice);
                    btn.Font = new Font(Font.FontFamily,16);
                    if (string.IsNullOrEmpty(Convert.ToString(itemPro.Image)) == false)
                    {
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = ByteArrayToImage(itemPro.Image);
                    }
                    flow.Controls.Add(btn);
                }
                tab.Controls.Add(flow);
                tabControl1.Controls.Add(tab);
            }
        }


        public Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }


        private void btnPrintBill_Click(object sender, EventArgs e)
        {

        }
    }
}
