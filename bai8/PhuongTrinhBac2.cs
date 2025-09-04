using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
     class PhuongTrinhBac2
    {
        private int Soa;
        private int Sob;
        private int Soc;

        public PhuongTrinhBac2()
        {
            Soa = 0;
            Sob = 0;
            Soc = 0;
        }
        public PhuongTrinhBac2(int a, int b, int c)
        {
            Soa = a;
            Sob = b;
            Soc = c;
        }
        public int A { get => Soa; set => Soa = value; }
        public int B { get => Sob; set => Sob = value; }
        public int C { get => Soc; set => Soc = value; }
        public void Nhap() 
        {
            Console.Write(" \t -Nhap so a: ");
            Soa = int.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap so b: ");
            Sob = int.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap so c: ");
            Soc = int.Parse(Console.ReadLine());
        }
        public double TinhNghiem() 
        {
            double delta = Sob * Sob - 4 * Soa * Soc;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
                return 0;
            }
            else if (delta == 0)
            {
                double x = -Sob / (2 * Soa);
                Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = {0}", x);
                return x;
            }
            else
            {
                double x1 = (-Sob + Math.Sqrt(delta)) / (2 * Soa);
                double x2 = (-Sob - Math.Sqrt(delta)) / (2 * Soa);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = {0}, x2 = {1}", x1, x2);
                return 1;
            }
        }
        public void Xuat() 
        {
            Console.WriteLine("Phuong trinh bac 2: {0}x^2 + {1}x + {2} = 0", Soa, Sob, Soc);
            TinhNghiem();
        }
    }
}
