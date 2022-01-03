using System.Data;

namespace Final_Project_Pemrograman_Lanjut.model
{
    public class HistoryModel
    {
        private ModelTemplate _template;

        public int id_pembelian { get; set; }
        public string nama_pembeli { get; set; }
        public string alamat_pembeli { get; set; }

        public HistoryModel()
        {
            _template = new ModelTemplate();
        }

        public DataSet ShowHistory()
        {
            var ds = _template.SelectData("pembelian",
                "SELECT nama_pembeli, no_telp, alamat_pembeli, nama_produk, harga_produk FROM pembelian");
            return ds;
        }
    }
}