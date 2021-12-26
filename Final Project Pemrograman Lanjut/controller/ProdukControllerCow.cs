using System;
using System.Data;
using System.Collections.Generic;
using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class ProdukControllerCow
    {
        private ProdukModelCow _model;
        private CowPage _view;

        public ProdukControllerCow(CowPage cowPage)
        {
            _model = new ProdukModelCow();
            _view = cowPage;
        }

        public List<DataProduct> ShowProductCow()
        {
            var ds = _model.ShowProduct();
            var goathProducts = new List<DataProduct>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var imageURI = String.Concat("/img/", Convert.ToString(dr["gambar"]));
                goathProducts.Add(
                    new DataProduct(Convert.ToInt32(dr["id"]),Convert.ToString(dr["nama"]), Convert.ToInt32(dr["harga"]),
                    imageURI));
            }

            return goathProducts;
        }
    }
}