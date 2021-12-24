using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class ProdukControllerChicken
    {
        private ProdukModelChicken _model;
        private ChickenPage _view;

        public ProdukControllerChicken(ChickenPage chickenPage)
        {
            _model = new ProdukModelChicken();
            _view = chickenPage;
        }
    }
}