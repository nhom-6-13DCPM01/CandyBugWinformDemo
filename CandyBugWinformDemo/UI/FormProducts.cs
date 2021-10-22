using CandyBugWinformDemo.Control;
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
    public partial class FormProducts : Form
    {
        private ContextMenuStrip _contextMenuAutoFill;
        public FormProducts()
        {
            InitializeComponent();
        }
        public void loadCategory()
        {
            _contextMenuAutoFill = new ContextMenuStrip();
            List<Category> list = CategoryDAO.Instence.getListCategory();
            foreach(Category item in list)
            {
                _contextMenuAutoFill.Items.Add(item.Name);
            }
            
            
            foreach (ToolStripMenuItem mItem in _contextMenuAutoFill.Items)
                mItem.Click +=
                new System.EventHandler(this.AutoFillToolStripMenuItem_Click);
        }

        private void dropdownCategoty_DropDown(object sender, ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs e)
        {
            dropdownCategoty.ContextMenuStrip = _contextMenuAutoFill;
            dropdownCategoty.ContextMenuStrip.Show(dropdownCategoty, new System.Drawing.Point(0,dropdownCategoty.Height));
        }
        private void AutoFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m = ((ToolStripMenuItem)sender).Text;
            dropdownCategoty.Text = m;
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBKDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.qLBKDataSet.Product);
            loadCategory();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
