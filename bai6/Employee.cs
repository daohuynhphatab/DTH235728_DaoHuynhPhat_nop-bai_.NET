using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
     class Employee
    {
        int id;
        string name;
        int yearOfBirth;
        double salaryLevel;
        double basicSalary;
        //Hàm khởi tạo không có tham số
        public Employee()
        {
            id = 0;
            name = "";
            yearOfBirth = 0;
            salaryLevel = 0;
            basicSalary = 0;
        }
        //Hàm khởi tạo có tham số
        public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicSalary;
        }
        //Các phương thức Properties để get/set giá trị cho các thuộc tính
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }
        public double Income { get => salaryLevel * basicSalary; }
        public double SalaryLevel { get => salaryLevel; set => salaryLevel = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        //Phương thức nhập/xuất dữ liệu

        public void Input()
        {
            Console.Write(" \t -Nhap ma nhan vien: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap ho ten: ");
            Name = Console.ReadLine();
            Console.Write(" \t -Nhap nam sinh: ");
            YearOfBirth = int.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap he so luong: ");
            salaryLevel = double.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap luong co ban: ");
            basicSalary = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", Id, Name, YearOfBirth, Income);
        }
    }
}
