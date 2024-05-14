using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMaket_project
{
    class proProducts
    {
        string nameprod;
        string[] typeUnit;
        double price;
        int id,barcode, qoulty;

        //public proProducts() { };
        public proProducts(int id,string nameprod, string[] typeUnit, double price, int barcode, int qoulty)
        {
            this.Id = id;
            this.nameprod = nameprod;
            this.typeUnit = typeUnit;
            this.price = price;
            this.barcode = barcode;
            this.qoulty = qoulty;
        }

        public string Nameprod { get => nameprod; set => nameprod = value; }
        public string[] TypeUnit { get => typeUnit; set => typeUnit = value; }
        public double Price { get => price; set => price = value; }
        public int Barcode { get => barcode; set => barcode = value; }
        public int Qoulty { get => qoulty; set => qoulty = value; }
        public int Id { get => id; set => id = value; }
    }
}
