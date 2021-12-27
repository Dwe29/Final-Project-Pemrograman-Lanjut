using System.Data;
using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class BuyProductController
    {
        private BuyProductModel _model;
        private BuyProductWindow _view;

        public BuyProductController(BuyProductWindow view)
        {
            _model = new BuyProductModel();
            _view = view;
        }

        public DataSet ShowData()
        {
            var ds = _model.ShowData();
            return ds;
        }
    }
}