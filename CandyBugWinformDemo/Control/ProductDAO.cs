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
        public bool addProduct(string name,string Category, float price)
        {
            string query = string.Format("INSERT Product ( name, Category, price) VALUES ( N'{0}', N'{1}' ,{2})", name , Category , price );
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public bool addProductWithImage(string name, string Category, float price, string nameImage)
        {
            string query = string.Format("INSERT Product ( name, Category, price , image ) VALUES ( N'{0}', N'{1}' ,{2} , N'{3}')", name, Category, price, nameImage);
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public bool removeProduct(int idPro)
        {
            OrdersDAO.Intance.deleteOrderbyidProduct(idPro);
            string query = string.Format("DELETE Product Where idPro = {0}",idPro);
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public bool updateProduct(string name, string Category, float price, int idPro)
        {
            string query = string.Format("UPDATE Product SET name = N'{0}', Category = N'{1}' , price = {2} WHERE idPro = {3}", name, Category, price , idPro );
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public bool updateProductWithImage(string name, string Category, float price, int idPro, string nameImage)
        {
            string query = string.Format("UPDATE Product SET name = N'{0}', Category = N'{1}' , price = {2} , image = N'{4}' WHERE idPro = {3}", name, Category, price, idPro, nameImage);
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public void getProduct()
        {

        }
    }
}
