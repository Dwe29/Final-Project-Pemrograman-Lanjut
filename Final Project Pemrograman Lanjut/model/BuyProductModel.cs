using System.Data;

namespace Final_Project_Pemrograman_Lanjut.model
{
    public class BuyProductModel
    {
        private ModelTemplate _template;
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Jenis { get; set; }

        public BuyProductModel()
        {
            _template = new ModelTemplate();
        }

        public DataSet ShowData()
        {
            return _template.Select("produk", "id = '"+Id+"', nama = '"+Name+"', gambar = '"+Image+"', jenis = '"+Jenis+"'");
        }
    }
}