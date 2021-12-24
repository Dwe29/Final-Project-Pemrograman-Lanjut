using Final_Project_Pemrograman_Lanjut.model;
using Final_Project_Pemrograman_Lanjut.view;

namespace Final_Project_Pemrograman_Lanjut.controller
{
    public class ProdukControllerGoath
    {
        private ProdukModelGoath _model;
        private GoathPage _view;

        public ProdukControllerGoath(GoathPage goathPage)
        {
            _model = new ProdukModelGoath();
            _view = goathPage;
        }
    }
}