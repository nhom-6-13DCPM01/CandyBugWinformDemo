using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Object
{
    class Product
    {
        private int idPro;
        private string name;
        private string Category;
        private float price;
        private string image;
        public int IdPro { get => idPro; set => idPro = value; }
        public string Name { get => name; set => name = value; }
       
        public string Image { get => image; set => image = value; }
        public float Price { get => price; set => price = value; }

        public Product(DataRow row)
        {
            this.idPro = (int)row["idPro"];
            this.name = row["name"].ToString();
            this.Category = row["idCategory"].ToString();
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.image = row["image"].ToString();
        }
    }
}
