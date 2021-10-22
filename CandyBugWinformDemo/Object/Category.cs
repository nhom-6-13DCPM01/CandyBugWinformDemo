using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Object
{
    class Category
    {
        private int idCate;
        private string name;

        
        public int IdCate { get => idCate; set => idCate = value; }
        public string Name { get => name; set => name = value; }

        public Category(DataRow row)
        {
            this.idCate = (int)row["idCate"];
            this.name = row["name"].ToString();
        }
    }
}
