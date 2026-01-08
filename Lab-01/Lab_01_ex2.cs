using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_ex2
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        // Constructor mac dinh
        public Student()
        {
            SID = 1;
            TenSV = "Nguyen Van A";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        // Constructor sao chep
        public Student(Student stu)
        {
            SID = stu.SID;  
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        // Constructor tham so
        public Student(int id, string ten, string khoa, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = khoa;
            DiemTB = dtb;
        }
        // Cac property cho tung thuoc tinh cua lop
        public int StudentID
        {
            get { return SID; }
            set { SID = value; }
        }

        public String Name
        {
            get { return TenSV; }
            set { TenSV = value.ToUpper(); }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }

        // Phuong thuc hien thi du lieu
        public void Display()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }

        public void InputData()
        {
            Console.Write("Nhap MaSV: ");
            StudentID = int.Parse((string)Console.ReadLine());
            Console.Write("Ho ten SV:");
            Name = Console.ReadLine();
            Console.Write("Nhap khoa:");
            Faculty = Console.ReadLine();
            Console.Write("Nhap Diem TB:");
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
        private static Student[] InputStudentList(int n)
        {
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = Tester.InputOneStudent(i);
            }
            return students;
        }

        // Phương thức xuất danh sách sinh viên
        private static void DisplayStudentList(Student[] students)
        {
            Console.WriteLine("\n\n====== DANH SÁCH SINH VIÊN ======");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\n--- Sinh viên thứ {i + 1} ---");
                students[i].Display();
            }
        }
        /*

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

        */
    }


}
