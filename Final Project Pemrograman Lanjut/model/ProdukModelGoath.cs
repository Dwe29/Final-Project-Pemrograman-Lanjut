using System.Data;

namespace Final_Project_Pemrograman_Lanjut.model
{
    public class ProdukModelGoath
    {
        private ModelTemplate _template;
        
        public int id { get; set; }
        public string nama { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }
        public string jenis { get; set; }

        public ProdukModelGoath()
        {
            _template = new ModelTemplate();
        }

        public DataSet ShowProduct()
        {
            return _template.Select("produk", "SELECT * FROM produk WHERE jenis='kambing'");
        }
    }
}