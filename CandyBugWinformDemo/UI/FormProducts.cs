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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            this.dataGridViewformProducts.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewformProducts.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.dataGridViewformProducts.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewformProducts.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void kryptonTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowProduct_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBKDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.qLBKDataSet.Product);

        }
    }
}
