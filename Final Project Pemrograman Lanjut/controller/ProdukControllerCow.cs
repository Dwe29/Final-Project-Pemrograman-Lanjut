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

        public void ShowProductCow()
        {
            _model.ShowProduct();
        }
    }
}