using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
     class TamGiac
    {
        private int a;
        private int b;
        private int c;
        private int Chuvi;
        private string loaiTamGiac;
        private float dienTich;
        public TamGiac()
        {
            a = 2;
            b = 3;
            c = 5;
            Chuvi = 0;
            loaiTamGiac = "";
            dienTich = 0;
        }
        public TamGiac(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
        public int Chuvi1 { get => Chuvi; }
        public string LoaiTamGiac { get => loaiTamGiac; }
        public float DienTich1 { get => dienTich; }


        public int ChuVi() 
        {
            return Chuvi = a + b + c;
        }
        public float DienTich() 
        {
            float p = ChuVi()/ 2;
            return dienTich = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public void Output() 
        {
            Console.WriteLine("Canh 1: {0}", a);
            Console.WriteLine("Canh 2: {0}", b);
            Console.WriteLine("Canh 3: {0}", c);
            Console.WriteLine("Chu vi tam giac: {0}", ChuVi());
            Console.WriteLine("Dien tich tam giac: {0}", DienTich());
        }
    }
}
