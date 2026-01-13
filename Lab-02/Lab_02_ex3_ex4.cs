using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_ex3_ex4
{
    public class Account
    {
        private string accountID;
        private string firstName;
        private string lastName;
        private decimal balance;

        public string AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account()
        {
            accountID = "";
            firstName = "";
            lastName = "";
            balance = 0;
        }

        public Account(string id, string fname, string lname, decimal bal)
        {
            accountID = id;
            firstName = fname;
            lastName = lname;
            balance = bal;
        }

        public void FillInfo()
        {
            Console.Write("Account ID: ");
            accountID = Console.ReadLine();

            Console.Write("First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Balance: ");
            balance = decimal.Parse(Console.ReadLine());
        }

        public void Query()
        {
            Console.WriteLine("Account ID: {0} | Name: {1} {2} | Balance: {3}",
                accountID, firstName, lastName, balance);
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", accountID, firstName, lastName, balance);
        }
    }

    public class AccountList
    {
        private ArrayList Accounts = new ArrayList();

        public void NewAccount()
        {
            Account acc = new Account();
            acc.FillInfo();
            Accounts.Add(acc);
            Console.WriteLine("Account added successfully!\n");
        }

        public void Report()
        {
            if (Accounts.Count == 0)
            {
                Console.WriteLine("No accounts in the list!\n");
                return;
            }

            Console.WriteLine("\n========== ACCOUNT LIST ==========");
            foreach (Account acc in Accounts)
            {
                acc.Query();
            }
            Console.WriteLine("==================================\n");
        }

        public void SaveFile()
        {
            try
            {
                Console.Write("Input file name to save:");
                string filename = Console.ReadLine();

                // Tạo FileStream để ghi file
                FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);

                // Tạo StreamWtiter
                StreamWriter writer = new StreamWriter(output);

                // Duyệt qua từng tài khoản và ghi vào file
                foreach (Account acc in Accounts)
                {
                    writer.WriteLine("{0},{1},{2},{3}",
                    acc.AccountID, acc.FirstName, acc.LastName, acc.Balance);
                }

                // Đóng kết nối
                writer.Close();
                output.Close();

                Console.WriteLine("File saved successfully!\n");
            }catch(IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void LoadFile()
        {
            try
            {
                Console.Write("Input file name to load:");
                string filename = Console.ReadLine();


                // Xóa danh sách hiện tại
                Accounts.Clear();

                // Tạo FileStream để đọc file
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);

                // Tạo StreamReader
                StreamReader reader = new StreamReader(input);

                // Đọc từng dòng
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    // Tách chuỗi thành các phần bởi dấu phẩy
                    string[] list = str.Split(',');

                    // Tạo đối tượng
                    Account acc = new Account(
                            list[0],                          // Account ID
                            list[1],                          // First Name
                            list[2],                          // Last Name
                            decimal.Parse(list[3])            // Balance
                        );


                    // Thêm vào danh sách
                    Accounts.Add(acc);
                }

                // Đóng kết nối
                reader.Close();
                input.Close();

                Console.WriteLine("File loaded successfully!\n");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AccountList accountList = new AccountList();
            string command;

            Console.WriteLine("========== ACCOUNT MANAGEMENT SYSTEM ==========\n");

            while (true)
            {
                Console.WriteLine("Commands: Add, Save, Load, Report, Exit");
                Console.Write("Enter command: ");
                command = Console.ReadLine().ToUpper();

                switch (command)
                {
                    case "ADD":
                        accountList.NewAccount();
                        break;

                    case "SAVE":
                        accountList.SaveFile();
                        break;

                    case "LOAD":
                        accountList.LoadFile();
                        break;

                    case "REPORT":
                        accountList.Report();
                        break;

                    case "EXIT":
                        Console.WriteLine("Program terminated!");
                        return;

                    default:
                        Console.WriteLine("Invalid command! Please try again.\n");
                        break;
                }
            }
        }
    }
}
