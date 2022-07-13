using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LTHDT
{
    abstract class SV
    {
        protected string hoTen;
        protected int namSinh;
        protected float dTB;
        public SV()
        {
            this.hoTen = "";
            this.namSinh = 0;
            this.dTB = 0.0f;
        }
        public SV(string ht, int ns, float dtb)
        {
            this.hoTen = ht;
            this.namSinh = ns;
            this.dTB = dtb;
        }
        public virtual void nhap()
        {
            Console.WriteLine("Nhập họ tên:");
            this.hoTen = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh:");
            this.namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm TB:");
            this.dTB = float.Parse(Console.ReadLine());
        }
        public virtual void hienThi()
        {
            Console.WriteLine("Họ và tên:{0}", this.hoTen);
            Console.WriteLine("Năm sinh:{0}", this.namSinh);
            Console.WriteLine("Điểm trung bình:{0}", this.dTB);
        }
        public virtual string loaiSV()
        {
            return "";
        }
        public abstract bool duocTN();
    }
}
