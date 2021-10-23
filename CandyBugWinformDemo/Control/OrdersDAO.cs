using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Control
{
    class OrdersDAO
    {
        private static OrdersDAO instance;

        internal static OrdersDAO Intance
        {
            get 
            { if (instance == null) 
              instance = new OrdersDAO(); 
                return instance;
            }
            private set { instance = value; }
        }

        public void deleteOrderbyidProduct(int id)
        {
            string query = "DELETE Orders WHERE idProduct = " + id;
            DataProvider.Instance.ExecuteQuery(query);
            
        }
    }
}
