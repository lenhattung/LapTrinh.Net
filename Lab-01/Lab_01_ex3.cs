using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_ex3
{
    // Lớp cơ sở
    class Person
    {
        private string fullName;
        private int birthYear;
        private string degree;

        public string FullName { get => fullName; set => fullName = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public string Degree { get => degree; set => degree = value; }

        public Person() {
            FullName = "NO NAME";
            BirthYear = 1900;
            Degree = "Dai hoc";
        }

        public Person(string fullName, int birthYear, string degree)
        {
            FullName = fullName;
            BirthYear = birthYear;
            Degree = degree;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Họ tên: {FullName}");
            Console.WriteLine($"Năm sinh: {BirthYear}");
            Console.WriteLine($"Bằng cấp: {Degree}");
        }

        public override string ToString()
        {
            return $"{FullName} - {BirthYear} - {Degree}";
        }

    }


    // Lớp Student kế thừa Person
    class Student : Person
    {
        private int studentID;
        private string faculty;
        private float mark;

        public int StudentID { get => studentID; set => studentID = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public float Mark { get => mark; set => mark = value; }

        public Student() : base ()
        {
            StudentID = 1;
            Faculty = "A";
            Mark = 0;
        }

        public Student(int id, string fullName, int birthYear, string degree,
                       string faculty, float mark)
            : base(fullName, birthYear, degree)
        {
            StudentID = id;
            Faculty = faculty;
            Mark = mark;
        }

        public override void Display()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"MSSV: {StudentID}");
            base.Display();
            Console.WriteLine($"Khoa: {Faculty}");
            Console.WriteLine($"Điểm TB: {Mark}");
            Console.WriteLine("=================================");
        }

        public override string ToString()
        {
            return $"MSSV: {StudentID} - {FullName} - {Faculty} - {Mark}";
        }

        public void InputData()
        {
            Console.Write("  Mã số sinh viên: ");
            StudentID = int.Parse(Console.ReadLine());

            Console.Write("  Họ tên: ");
            FullName = Console.ReadLine();

            Console.Write("  Năm sinh: ");
            BirthYear = int.Parse(Console.ReadLine());

            Console.Write("  Bằng cấp: ");
            Degree = Console.ReadLine();

            Console.Write("  Khoa: ");
            Faculty = Console.ReadLine();

            Console.Write("  Điểm trung bình: ");
            Mark = float.Parse(Console.ReadLine());
        }
    }

    class Tester
    {
        // Phuong thuc nhap mot sinh vien
        private static Student InputOneStudent(int index)
        {
            Console.WriteLine($"Nhap thong tin sinh vien thu {0}", index);
            Student st = new Student();
            st.InputData();
            return st;
        }

        // Phương thức nhập danh sách sinh viên
        private static ArrayList InputStudentList(int n)
        {
            ArrayList students = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                students.Add(Tester.InputOneStudent(i));
            }
            return students;
        }

        // Phương thức xuất danh sách sinh viên
        private static void DisplayStudentList(ArrayList students)
        {
            Console.WriteLine("\n\n====== DANH SÁCH SINH VIÊN ======");
            int i = 1;
            foreach (Student student in students)
            {
                Console.WriteLine($"\n--- Sinh viên thứ {i++} ---");
                student.Display();
            }

        }

        // CalculateAverageMark of all students

        // Find Student by name (student / null)

        public static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so luong SV:");
            n = int.Parse(Console.ReadLine());

            // Gọi phương thức
            var DSSV = InputStudentList(n);
            DisplayStudentList(DSSV);

            Console.ReadLine();
        }
    }


}
