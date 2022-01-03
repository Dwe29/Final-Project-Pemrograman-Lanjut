using System;
using System.Data;
using System.Windows;
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
            _view = view;
            _model = new BuyProductModel();
        }

        //     public DataSet ShowData()
        //     {
        //         var ds = _model.ShowData();
        //         return ds;
        //     }

        public void Purchase()
        {
            _model.nama_produk = _view.LblProduct.Content.ToString();
            _model.nama_pembeli = _view.TbName.Text;
            _model.no_telp = _view.TbNomor.Text;
            _model.alamat_pembeli = _view.TbAlamat.Text;
            _model.harga_produk = Convert.ToInt32(_view.TbHarga.Text);
            var result = _model.AddPurchase();
            if (result)
            {
                MessageBox.Show("Pembelian Berhasil");
                _view.Close();
            }
            else
            {
                MessageBox.Show("Pembelian Gagal");
            }
        }
    }
}