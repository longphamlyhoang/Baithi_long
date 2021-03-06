using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace B3
{
    class Bank
    {
        private const int min = 1;
        private const int max = 4;
        private const int create = 1;
        private const int pay = 2;
        private const int show = 3;
        private const int exit = 4;
        public static AccountList acclist = new AccountList();
        static void Main(string[] args)
        {

        }

        public static void CreateAccount(int accountId, string firstName, string lastName, string gender, float balance)
        {
            Account acc = new Account();
            acc.AccountId = accountId;
            acc.FirstName = firstName;
            acc.LastName = lastName;
            acc.Gender = gender;
            acc.Balance = balance;
            acclist.account.Add(acc);
        }

        public static void PayInto()
        {
            Console.WriteLine("Enter Account Id: ");
            int accId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of money: ");
            float amount = float.Parse(Console.ReadLine());
            foreach (Account item in acclist.account)
            {
                if (item.AccountId == accId)
                {
                    item.PayInto(amount);
                }
                else
                {
                    Console.WriteLine("Account doesn't exist in system.");
                }
            }
        }

        public void ShowData()
        {
            foreach (Account item in acclist.account)
            {
                item.ShowInfo();
            }
        }
        public static void Process()
        {
            int selected = 0;
            do
            {
                BuildMenu(out selected);
                switch (selected)
                {
                    case create:
                        Console.WriteLine("Enter Acount Id: ");
                        int accountId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter first name: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter last name: ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter gender: ");
                        string gender = Console.ReadLine();
                        Console.WriteLine("Enter your current balacne: ");
                        float balance = float.Parse(Console.ReadLine());
                        CreateAccount(accountId, firstName, lastName, gender, balance);
                        break;
                    case pay:
                        PayInto();
                        break;
                    case show:
                        break;
                }
            } while (selected != exit);
        }
        public static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Bank Management System");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Pay Into");
                Console.WriteLine("3. Show Customers Data");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose a function: ");
                selected = Int32.Parse(Console.ReadLine());
            } while (selected < min || selected > max);
        }

    }

}