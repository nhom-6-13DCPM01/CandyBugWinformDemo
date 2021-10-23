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

        }

        

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCurrentOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
