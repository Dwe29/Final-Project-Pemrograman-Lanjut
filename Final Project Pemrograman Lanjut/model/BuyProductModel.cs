using System.Data;
using System.Windows.Media;

namespace Final_Project_Pemrograman_Lanjut.model
{
    public class BuyProductModel
    {
        private ModelTemplate _template;

        public string nama_pembeli { get; set; }
        public string alamat_pembeli { get; set; }
        public string nama_produk { get; set; }
        public int harga_produk { get; set; }

        public string no_telp { get; set; }
        // public int Id { get; set; }
        // public string Name { get; set; }
        // public string Image { get; set; }
        // public string Jenis { get; set; }

        public BuyProductModel()
        {
            _template = new ModelTemplate();
        }

        // public DataSet ShowData()
        // {
        //     DataSet ds;
        //     ds = _template.Select("produk",
        //         "id_produk = '" + Id + "', nama = '" + Name + "', gambar = '" + Image + "', jenis = '" + Jenis + "'");
        //
        //     return ds;
        // }

        public bool AddPurchase()
        {
            var data = "'" + nama_pembeli + "','" + alamat_pembeli + "','" + nama_produk + "','" + harga_produk +
                       "','" + no_telp + "'";
            return _template.Insert("pembelian", data);
        }
    }
}