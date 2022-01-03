using System.Data;
using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class HistoryController
    {
        private HistoryModel _model;
        private HistoryPage _view;

        public HistoryController(HistoryPage view)
        {
            _model = new HistoryModel();
            _view = view;
        }

        public void DataHistory()
        {
            var ds = _model.ShowHistory();
            _view.DgHistory.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}