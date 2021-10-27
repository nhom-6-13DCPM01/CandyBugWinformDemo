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
    public partial class FormProducts : Form
    {
        private ContextMenuStrip _contextMenuAutoFill;

        public FormProducts()
        {
            InitializeComponent();
            this.dataGridViewformProducts.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewformProducts.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.dataGridViewformProducts.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewformProducts.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }
        //
        //FUNTION CLEAR
        //
        public void ClearTxt()
        {
            txtIDProduct.Clear();
            txtItemProduct.Clear();
            dropdownCategoty.Text = " ";
            updownPrice.Text = " ";
            pictureBox1.Image = null;
        }

        //-------------------------------------------------------------//
        //FUNTION DROP DOWN LOAD BUTTON
        //
        //FUNTION LOAD CATEGORY
        //
        public void loadCategory()
        {
            _contextMenuAutoFill = new ContextMenuStrip();
            List<Category> list = CategoryDAO.Instence.getListCategory();
            foreach (Category item in list)
            {
                _contextMenuAutoFill.Items.Add(item.Name);
            }

            foreach (ToolStripMenuItem mItem in _contextMenuAutoFill.Items)
                mItem.Click +=
                new System.EventHandler(this.AutoFillToolStripMenuItem_Click);
        }
        //
        //
        private void dropdownCategoty_DropDown(object sender, ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs e)
        {
            dropdownCategoty.ContextMenuStrip = _contextMenuAutoFill;
            dropdownCategoty.ContextMenuStrip.Show(dropdownCategoty, new System.Drawing.Point(0, dropdownCategoty.Height));
        }
        private void AutoFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m = ((ToolStripMenuItem)sender).Text;
            dropdownCategoty.Text = m;
        }
        //
        public void loadGridData()
        {
            this.productTableAdapter1.Fill(this.qLBKDataSet1.Product);
        }
        //
        //----------------------------------------------------------//
        //FORM LOAD
        //
        private void FormProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBKDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.qLBKDataSet1.Product);
            loadCategory();
            loadGridData();
        }
        //----------------------------------------------------------------//
        //
        //--------------------------------------------------------------//
        //CLICK ON DATAGRIDVIEW
        //
        private void dataGridViewformProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDProduct.Text = dataGridViewformProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtItemProduct.Text = dataGridViewformProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                dropdownCategoty.Text = dataGridViewformProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                updownPrice.Text = dataGridViewformProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (string.IsNullOrEmpty(dataGridViewformProducts.Rows[e.RowIndex].Cells[4].Value.ToString()))
                {
                    if(pictureBox1.Image == null)
                    {
                        ImageNow = null;
                        showPicture(null);
                    }
                    else
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        ImageNow = null;
                        showPicture(null);
                    }
                    
                }
                else
                {
                    if (pictureBox1.Image == null)
                    {
                        oldImage = dataGridViewformProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                        ImageNow = dataGridViewformProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                        showPicture(ImageNow);
                    }
                    else
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        oldImage = dataGridViewformProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                        ImageNow = dataGridViewformProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                        showPicture(ImageNow);
                    }
                      
                }
            }
            catch (Exception)
            {

            }



        }
        //---------------------------------------------------------------//
        //
        //----------------------------------------------------------------//
        //CELL CLICK IS NOT VALUE
        //

        //-------------------------------------------------------------//
        //
        //--------------------------BUTTON-----------------------------//
        //
        //CLICK ADD PRODUCT
        //
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                string name = txtItemProduct.Text;
                string idCate = CategoryDAO.Instence.getCategory(dropdownCategoty.Text);
                float price = (float)Convert.ToDouble(updownPrice.Text);
                string nameImage = addImage(startImage);
                if (string.IsNullOrEmpty(name))
                {
                    if (ProductDAO.Intence.addProduct(name, idCate, price))
                    {
                        MessageBox.Show("Thêm Thành công");
                        loadGridData();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo");
                    }
                }
                else
                {
                    if (ProductDAO.Intence.addProductWithImage(name, idCate, price, nameImage))
                    {
                        MessageBox.Show("Thêm Thành công");
                        loadGridData();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo");
                    }
                }

            }

        }
        //
        //DELETE BUTTON
        //
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int idPro;
            if (Int32.TryParse(txtIDProduct.Text, out idPro))
            {
                if (ProductDAO.Intence.removeProduct(idPro))
                {
                    deleteImage(ImageNow);
                    MessageBox.Show("Xóa Thành công");
                    loadGridData();
                    ClearTxt();
                }
                else
                {
                    MessageBox.Show("Thông báo", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Pleace choose a product", "Lỗi");
            }


        }
        //
        //UPDATE PRODUCT
        //
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(ImageNow))
            {
                if (checkInput())
                {
                    string name = txtItemProduct.Text;
                    string idCate = CategoryDAO.Instence.getCategory(dropdownCategoty.Text);
                    float price = (float)Convert.ToDouble(updownPrice.Text);
                    int idPro = Convert.ToInt32(txtIDProduct.Text);
                    if (ProductDAO.Intence.updateProduct(name, idCate, price, idPro))
                    {
                        MessageBox.Show("Update Thành công");
                        loadGridData();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo");
                    }
                }
            }
            else
            {   
                if (checkInput())
                {
                    string name = txtItemProduct.Text;
                    string idCate = CategoryDAO.Instence.getCategory(dropdownCategoty.Text);
                    float price = (float)Convert.ToDouble(updownPrice.Text);
                    int idPro = Convert.ToInt32(txtIDProduct.Text);
                    if (ProductDAO.Intence.updateProductWithImage(name, idCate, price, idPro,updateImage(oldImage,ImageNow)))
                    {
                        MessageBox.Show("Update Thành công");
                        loadGridData();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông báo");
                    }
                }
            }
        }
        //----------------------------------------------------------
        //---------------------CHECK INPUT VALUE--------------------//
        public bool checkInput()
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                return true;
            }
            return false;
        }

        private void txtItemProduct_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemProduct.Text))
            {
                e.Cancel = true;
                txtIDProduct.Focus();
                errorProvider.SetError(txtItemProduct, "Please enter name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtItemProduct, null);
            }
        }

        private void updownPrice_Validating(object sender, CancelEventArgs e)
        {
            Double a;
            if (Double.TryParse(updownPrice.Text, out a) == false)
            {
                e.Cancel = true;
                updownPrice.Focus();
                errorProvider.SetError(updownPrice, "Please enter true");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(updownPrice, null);
            }
        }

        private void dropdownCategoty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dropdownCategoty.Text))
            {
                e.Cancel = true;
                txtIDProduct.Focus();
                errorProvider.SetError(dropdownCategoty, "Please choose a Category");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dropdownCategoty, null);
            }
        }
        //-----------------------Picture Problem----------------------.//
        //-------------------------------------------------------------//
        public string startImage = null;
        public string ImageNow = null;
        public string oldImage = null;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files() | *.jpg; *.jpeg; *.bmp; ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    pictureBox1.Image = Image.FromFile(open.FileName);
                    startImage = open.FileName;
                    ImageNow = Path.GetFileName(open.FileName);
                }
                pictureBox1.Image = Image.FromFile(open.FileName);
                startImage = open.FileName;
                ImageNow = Path.GetFileName(open.FileName);
            }
        }

        public string addImage(string Image)
        {
            string nameImage = null;
            if (string.IsNullOrEmpty(Image) == false)
            {
                if (testImage(Path.GetFileName(Image)) == false)
                {
                    File.Copy(Image, Path.Combine(Application.StartupPath + "\\picture\\", Path.GetFileName(Image)), true);
                    nameImage = Path.GetFileName(Image);
                    return nameImage;
                }
                else
                {
                    return null;
                }
            }
            return nameImage;
        }

        public void deleteImage(string nameImage)
        {
            if (string.IsNullOrEmpty(nameImage) == false)
            {
                if (testImage(nameImage))
                {
                    
                    string deleteImage = System.IO.Path.Combine(Application.StartupPath + "\\picture\\", nameImage);
                    File.Delete(deleteImage);
                }
            }
        }

        public string updateImage(string oldNameImage, string newNameImage)
        {
            pictureBox1.Dispose();
            pictureBox1.Image = null;
            if (string.IsNullOrEmpty(newNameImage) == false && string.IsNullOrEmpty(oldImage)==false )
            {
                if (oldNameImage.Equals(newNameImage))
                {
                    return oldNameImage;
                }
                deleteImage(oldNameImage);
                addImage(startImage);
                return newNameImage;
            }else if(string.IsNullOrEmpty(newNameImage) == false && string.IsNullOrEmpty(oldImage) == true)
            {
                addImage(startImage);
                return newNameImage;
            }
            return newNameImage;
        }

        public void showPicture(string nameImage)
        {
            if (string.IsNullOrEmpty(nameImage) == false)
            {
                if (testImage(nameImage))
                {
                    string showImage = System.IO.Path.Combine(Application.StartupPath + "\\picture\\", nameImage);
                    pictureBox1.Image = Image.FromFile(showImage);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        public bool testImage(string image)
        {
            string path = System.IO.Path.Combine(Application.StartupPath + "\\picture\\", image);
            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }
    }
}
