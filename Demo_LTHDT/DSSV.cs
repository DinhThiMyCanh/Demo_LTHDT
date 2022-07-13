using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_LTHDT
{
    class DSSV
    {
        private ArrayList ds;
        //Phương thức khởi tạo
        public DSSV()
        {
            ds = new ArrayList();
        }
        //Thêm sinh viên
        public void themSV(SV a)
        {
            if (!ds.Contains(a))
                ds.Add(a);
        }
        //Hiển thị danh sách sv
        public void lietKe()
        {
            foreach (SV a in ds)
                a.hienThi();
        }
        //Hiển thị danh sách sv theo loại
        public void lietKe(string loai)
        {
            foreach (SV a in ds)
                if (a.loaiSV().Equals(loai))
                    a.hienThi();
        }
        //Hiển thị danh sách sv được tốt nghiệp
        public void lietKeTN()
        {
            foreach (SV a in ds)
                if (a.duocTN())
                    a.hienThi();
        }
    }
}
