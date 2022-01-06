using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class DataProdukController
    {
        private DataProdukModel _model;
        private DataProdukPage _view;

        public DataProdukController(DataProdukPage view)
        {
            _model = new DataProdukModel();
            _view = view;
        }

        public void ShowDataProduk()
        {
            var ds = _model.showData();
            _view.DgProduk.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}