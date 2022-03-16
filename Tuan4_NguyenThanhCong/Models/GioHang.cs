using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tuan4_NguyenThanhCong.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masach { set; get; }

        [Display(Name = "Tên sách")]
        public string tensach { set; get; }

        [Display(Name = "Ảnh bìa")]
        public string hinh { set; get; }

        [Display(Name = "Giá bán")]
        public double giaban { set; get; }
        [Display(Name = "Số lượng")]
        public int iSoluong { set; get; }
        [Display(Name = "Thành tiền")]
        public double dThanhtien
        {
            get { return iSoluong * giaban; }
        }

        public GioHang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            iSoluong = 1;
        }

    }
}