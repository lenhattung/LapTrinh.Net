using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_ex4
{
    // Lớp trừu tượng cơ sở
    abstract class Employee
    {
        public string FullName { get; set; }
        public int BirthYear { get; set; }
        public string Degree { get; set; }

        protected Employee()
        {
            FullName = "Tran Van A";
            BirthYear = 1980;
            Degree = "Dai hoc";
        }

        protected Employee(string fullName, int birthYear, string degree)
        {
            FullName = fullName;
            BirthYear = birthYear;
            Degree = degree;
        }

        // Phương thức trừu tượng - bắt buộc lớp con phải triển khai
        public abstract float CalculateSalary();

        // Phương thức ảo
        public virtual void Display()
        {
            Console.WriteLine($"Họ tên: {FullName}");
            Console.WriteLine($"Năm sinh: {BirthYear}");
            Console.WriteLine($"Bằng cấp: {Degree}");
            Console.WriteLine($"Lương: {CalculateSalary():N0}");
        }
    }

    // Nhà quản lý (Lớp cơ sở)
    class Manager : Employee
    {
        public string Position { get; set; }
        public int WorkDaysPerMonth { get; set; }
        public float SalaryGrade { get; set; }

        public Manager() : base()
        {
            Position = "Truong phong";
            WorkDaysPerMonth = 20;
            SalaryGrade = 600000;
        }

        public Manager(string fullName, int birthYear, string degree,
                       string position, int workDaysPerMonth, float salaryGrade)
            : base(fullName, birthYear, degree)
        {
            Position = position;
            WorkDaysPerMonth = workDaysPerMonth;
            SalaryGrade = salaryGrade;
        }

        public virtual void InputData()
        {
            Console.Write("    Họ tên: ");
            FullName = Console.ReadLine();
            Console.Write("    Năm sinh: ");
            BirthYear = int.Parse(Console.ReadLine());
            Console.Write("    Bằng cấp: ");
            Degree = Console.ReadLine();
            Console.Write("    Chức vụ: ");
            Position = Console.ReadLine();
            Console.Write("    Số ngày công trong tháng: ");
            WorkDaysPerMonth = int.Parse(Console.ReadLine());
            Console.Write("    Bậc lương: ");
            SalaryGrade = float.Parse(Console.ReadLine());
        }

        public override float CalculateSalary()
        {
            return WorkDaysPerMonth * SalaryGrade;
        }

        public override void Display()
        {
            Console.WriteLine("========= NHÀ QUẢN LÝ =========");
            base.Display();
            Console.WriteLine($"Chức vụ: {Position}");
            Console.WriteLine($"Ngày công: {WorkDaysPerMonth}");
            Console.WriteLine("================================");
        }
    }

    // Nhà khoa học - kế thừa từ Nhà quản lý
    // (Nhà khoa học cũng có thể làm công tác quản lý)
    class Scientist : Manager
    {
        public int PapersPublished { get; set; }

        public Scientist() : base()
        {
            Position = "Nhan vien";
            PapersPublished = 0;
            WorkDaysPerMonth = 20;
            SalaryGrade = 500000;
        }

        public Scientist(string fullName, int birthYear, string degree,
                        string position, int papersPublished,
                        int workDaysPerMonth, float salaryGrade)
            : base(fullName, birthYear, degree, position, workDaysPerMonth, salaryGrade)
        {
            PapersPublished = papersPublished;
        }

        // Ghi đè InputData để thêm nhập số bài báo
        public override void InputData()
        {
            Console.Write("    Họ tên: ");
            FullName = Console.ReadLine();
            Console.Write("    Năm sinh: ");
            BirthYear = int.Parse(Console.ReadLine());
            Console.Write("    Bằng cấp: ");
            Degree = Console.ReadLine();
            Console.Write("    Chức vụ: ");
            Position = Console.ReadLine();
            Console.Write("    Số bài báo đã công bố: ");
            PapersPublished = int.Parse(Console.ReadLine());
            Console.Write("    Số ngày công trong tháng: ");
            WorkDaysPerMonth = int.Parse(Console.ReadLine());
            Console.Write("    Bậc lương: ");
            SalaryGrade = float.Parse(Console.ReadLine());
        }

        // Tính lương: ngày công * bậc lương (giống Manager)
        // (Có thể thêm thưởng dựa trên số bài báo)
        public override float CalculateSalary()
        {
            float baseSalary = WorkDaysPerMonth * SalaryGrade;
            // Có thể thêm bonus: +50,000 cho mỗi bài báo
            float bonus = PapersPublished * 50000;
            return baseSalary + bonus;
        }

        // Ghi đè Display
        public override void Display()
        {
            Console.WriteLine("========= NHÀ KHOA HỌC (CÓ QUẢN LÝ) =========");
            Console.WriteLine($"Họ tên: {FullName}");
            Console.WriteLine($"Năm sinh: {BirthYear}");
            Console.WriteLine($"Bằng cấp: {Degree}");
            Console.WriteLine($"Chức vụ: {Position}");
            Console.WriteLine($"Số bài báo: {PapersPublished}");
            Console.WriteLine($"Ngày công: {WorkDaysPerMonth}");
            Console.WriteLine($"Bậc lương: {SalaryGrade:N0}");
            Console.WriteLine($"Lương cơ bản: {WorkDaysPerMonth * SalaryGrade:N0}");
            Console.WriteLine($"Thưởng (bài báo): {PapersPublished * 50000:N0}");
            Console.WriteLine($"Tổng lương: {CalculateSalary():N0}");
            Console.WriteLine("==========================================");
        }
    }

    // Nhân viên phòng thí nghiệm
    class LabTechnician : Employee
    {
        public float MonthlySalary { get; set; }

        public LabTechnician() : base()
        {
            MonthlySalary = 3000000;
        }

        public LabTechnician(string fullName, int birthYear, string degree,
                            float monthlySalary)
            : base(fullName, birthYear, degree)
        {
            MonthlySalary = monthlySalary;
        }

        public void InputData()
        {
            Console.Write("    Họ tên: ");
            FullName = Console.ReadLine();
            Console.Write("    Năm sinh: ");
            BirthYear = int.Parse(Console.ReadLine());
            Console.Write("    Bằng cấp: ");
            Degree = Console.ReadLine();
            Console.Write("    Lương trong tháng: ");
            MonthlySalary = float.Parse(Console.ReadLine());
        }

        public override float CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void Display()
        {
            Console.WriteLine("===== NHÂN VIÊN PHÒNG THÍ NGHIỆM =====");
            base.Display();
            Console.WriteLine("========================================");
        }
    }

    // Lớp Tester
    class Tester
    {
        private static List<Employee> employees = new List<Employee>();

        private static void ShowMenu()
        {
            Console.WriteLine("\n===== QUẢN LÝ NHÂN SỰ VIỆN KHOA HỌC =====");
            Console.WriteLine("1. Thêm nhà khoa học");
            Console.WriteLine("2. Thêm nhà quản lý");
            Console.WriteLine("3. Thêm nhân viên phòng thí nghiệm");
            Console.WriteLine("4. Hiển thị danh sách nhân viên");
            Console.WriteLine("5. Tính tổng lương từng loại");
            Console.WriteLine("6. Thoát chương trình");
            Console.Write("Chọn chức năng (1-6): ");
        }

        private static void AddScientist()
        {
            Console.WriteLine("\nNhập thông tin nhà khoa học:");
            var scientist = new Scientist();
            scientist.InputData();
            employees.Add(scientist);
            Console.WriteLine("✓ Thêm nhà khoa học thành công!");
        }

        private static void AddManager()
        {
            Console.WriteLine("\nNhập thông tin nhà quản lý:");
            var manager = new Manager();
            manager.InputData();
            employees.Add(manager);
            Console.WriteLine("✓ Thêm nhà quản lý thành công!");
        }

        private static void AddLabTechnician()
        {
            Console.WriteLine("\nNhập thông tin nhân viên phòng thí nghiệm:");
            var technician = new LabTechnician();
            technician.InputData();
            employees.Add(technician);
            Console.WriteLine("✓ Thêm nhân viên phòng thí nghiệm thành công!");
        }

        private static void DisplayAllEmployees()
        {
            Console.WriteLine("\n===== DANH SÁCH NHÂN VIÊN =====");
            if (employees.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }

            int index = 1;
            foreach (var employee in employees)
            {
                Console.WriteLine($"\n--- Nhân viên thứ {index} ---");
                employee.Display();
                index++;
            }
        }

        private static void CalculateTotalSalaries()
        {
            float scientistSalary = 0;
            float managerSalary = 0;
            float technicianSalary = 0;

            foreach (var employee in employees)
            {
                if (employee is Scientist)
                {
                    scientistSalary += employee.CalculateSalary();
                }
                else if (employee is Manager)
                {
                    managerSalary += employee.CalculateSalary();
                }
                else if (employee is LabTechnician)
                {
                    technicianSalary += employee.CalculateSalary();
                }
            }

            Console.WriteLine("\n===== TỔNG LƯƠNG CHI TRẢ =====");
            Console.WriteLine($"Tổng lương nhà khoa học: {scientistSalary:N0}");
            Console.WriteLine($"Tổng lương nhà quản lý: {managerSalary:N0}");
            Console.WriteLine($"Tổng lương nhân viên phòng thí nghiệm: {technicianSalary:N0}");
            Console.WriteLine($"{'=',-30}");
            Console.WriteLine($"Tổng cộng: {scientistSalary + managerSalary + technicianSalary:N0}");
        }

        public static void Main()
        {
            int choice;

            do
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddScientist();
                        break;
                    case 2:
                        AddManager();
                        break;
                    case 3:
                        AddLabTechnician();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    case 5:
                        CalculateTotalSalaries();
                        break;
                    case 6:
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (choice != 6);

            Console.ReadLine();
        }
    }
}
