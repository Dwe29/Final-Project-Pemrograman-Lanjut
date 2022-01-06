using System.Data;
using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class DataPembeliController
    {
        private DataPembeliModel _model;
        private DataPembeliPage _view;

        public DataPembeliController(DataPembeliPage view)
        {
            _model = new DataPembeliModel();
            _view = view;
        }

        public void DataHistory()
        {
            var ds = _model.ShowHistory();
            _view.DgPembelian.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}