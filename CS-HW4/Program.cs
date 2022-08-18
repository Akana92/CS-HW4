using LibraryPrinter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW4
{
    class Program
    {
        struct Account
        {
            public string Login;
            public string Password;
            public void loadFromFile(string filename)
            {
                filename = "..\\..\\" + filename;
                StreamReader sr = new StreamReader(filename);

                Login = sr.ReadLine();

                Password = sr.ReadLine();

                sr.Close();
            }

        }

        static bool CheckLogAndPass(Account toCheck)
        {
            if (toCheck.Login == "root" && toCheck.Password == "GeekBrains")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Library.PrintInfo(4);

            Console.WriteLine("Вас приветствует программа проверки логина и пароля, считанных из файла.");
            int AmountOfTries = 3;

            string[] fileName = { "data.txt" };

            Account account;
            account.Login = "";
            account.Password = "";

            int i = 0;

            do
            {
                Console.WriteLine("\nГрузим файл: " + fileName[i]);
                account.loadFromFile(fileName[i]);

                Console.Write("Попытка авторизации: ");

                if (CheckLogAndPass(account))
                {

                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина или пароля." +
                        Environment.NewLine + "У Вас осталось " + AmountOfTries + " попытка(ок)");
                }
                i++;
            } while (AmountOfTries > 0);

            Console.Write("Авторизация успешна!");

            Console.ReadKey();
        }
    }
}
