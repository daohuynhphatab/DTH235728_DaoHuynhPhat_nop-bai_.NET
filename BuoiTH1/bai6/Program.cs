using bai6;

class program
{
    static void Main(string[] args)
    {
       Employee employee = new Employee();
        Console.Write(" Nhap id Nhan vien: ");
        employee.Id = int.Parse(Console.ReadLine());
        Console.Write(" Nhap ten Nhan vien: ");
        employee.Name = Console.ReadLine();
        Console.Write(" Nhap nam sinh Nhan vien: ");
        employee.YearOfBirth = int.Parse(Console.ReadLine());
        Console.Write(" Nhap he so luong Nhan vien: ");
        employee.SalaryLevel = double.Parse(Console.ReadLine());
        Console.Write(" Nhap luong co ban Nhan vien: ");
        employee.BasicSalary = double.Parse(Console.ReadLine());
        Console.WriteLine(" Thong tin Nhan vien: ");
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "ID", "Ten", "Nam Sinh", "Thu Nhap");
        employee.Display();
        Console.ReadLine();
    }
}