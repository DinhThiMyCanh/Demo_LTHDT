using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LTHDT
{
    class SVTH:SV
    {
        private string tenDT;
        private float diemDT;
        public SVTH() : base()
        {
            this.tenDT = "";
            this.diemDT = 0.0f;
        }
        public SVTH(string ht, int ns, float dtb, string tendt, float diemdt) : base(ht, ns, dtb)
        {
            this.tenDT = tendt;
            this.diemDT = diemdt;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhập tên đề tài:");
            this.tenDT = Console.ReadLine();
            Console.WriteLine("Nhập Điểm đề tài:");
            this.diemDT = float.Parse(Console.ReadLine());
        }
        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine("Tên đề tài:{0}", this.tenDT);
            Console.WriteLine("Điểm đề tài:{0}", this.diemDT);
        }
        public override string loaiSV()
        {
            return "TH";
        }
        public override bool duocTN()
        {
            return dTB >= 5 && diemDT >= 7;
        }

    }
}
