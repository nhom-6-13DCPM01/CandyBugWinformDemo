using CandyBugWinformDemo.Object;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public bool addProduct(string name,string Category, float price, byte[] image)
        {
            string query = "INSERT INTO Product ( name, Category, price , image ) VALUES ( @name , @Category , @price , @image )";
            
            int resulf = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name , Category , price , image });
            return resulf > 0;
        }
        public bool removeProduct(int idPro)
        {
            OrdersDAO.Intance.deleteOrderbyidProduct(idPro);
            string query = string.Format("DELETE Product Where idPro = {0}",idPro);
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public bool updateProduct(string name, string Category, float price, int idPro , byte[] image)
        {
            string query = "UPDATE Product SET name = @name , Category = @Category , price = @price , image = @image WHERE idPro = @idPro";
            int resulf = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, Category , price , image , idPro });
            return resulf > 0;
        }
        public void getProduct()
        {

        }
    }
}
