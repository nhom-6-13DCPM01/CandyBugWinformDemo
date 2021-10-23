using CandyBugWinformDemo.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Control
{
    class ProductDAO
    {
        private static ProductDAO instence;

        public static ProductDAO Intence 
        {
            get
            {
                if (instence == null)
                {
                   
                        if (instence == null)
                        {
                        instence = new ProductDAO();
                        }
                    
                }
                return ProductDAO.instence;
            }

            set => instence = value; 
        }

        private ProductDAO() { }
        public List<Product> getListProduct()
        {
            return null;
        }
        public List<Product> getListProductByCategory()
        {
            return null;
        }
        public bool addProduct(string name,int idCategory, float price)
        {
            string query = string.Format("INSERT Product (name, idCategory,price) VALUES (N'0',1,2)", name , idCategory , price );
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public void removeProduct()
        {

        }
        public void updateProduct()
        {

        }
        public void getProduct()
        {

        }
    }
}
