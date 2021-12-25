using System;
using System.Collections.Generic;
using System.Data;
using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class ProdukControllerChicken
    {
        private ProdukModelChicken _model;
        private ChickenPage _view;

        public ProdukControllerChicken(ChickenPage chickenPage)
        {
            _model = new ProdukModelChicken();
            _view = chickenPage;
        }
        
        public List<DataProduct> ShowProductChicken()
        {
            var ds = _model.ShowProduct();
            var dataProducts = new List<DataProduct>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var imageURI = string.Concat("/img/", Convert.ToString(dr["gambar"]));
                dataProducts.Add(
                    new DataProduct(Convert.ToString(dr["nama"]), Convert.ToInt32(dr["harga"]),
                        imageURI));
            }

            return dataProducts;
        }
    }
}