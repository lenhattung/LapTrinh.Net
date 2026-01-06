using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
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
        public void show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }
    }

    class Tester
    {
        public static void Main(string[] args)
        {
            Student[] DSSV;
            int n;
            Console.Write("Nhap vao so luong SV:");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("\n ==== NHAP DS SINH VIEN ====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("Nhap MaSV {0}: ", i + 1);
                DSSV[i].StudentID = int.Parse((string)Console.ReadLine());
                Console.Write("Ho ten SV:");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap khoa:");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhap Diem TB:");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }
            // Xuat DS Sinh Vien
            Console.WriteLine("\n ==== XUAT DS SINH VIEN ====");
            foreach(Student sv in DSSV)
                sv.show();
            Console.ReadLine();
        }
    }
}
