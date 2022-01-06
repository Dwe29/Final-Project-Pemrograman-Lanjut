using System.Data;

namespace Final_Project_Pemrograman_Lanjut.model
{
    public class DataProdukModel
    {
        private ModelTemplate _template;

        public int id { get; set; }
        public string nama { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }
        public string jenis { get; set; }


        public DataProdukModel()
        {
            _template = new ModelTemplate();
        }

        public DataSet showData()
        {
            return _template.SelectData("produk", "SELECT nama, harga, gambar, jenis FROM produk");
        }
    }
}