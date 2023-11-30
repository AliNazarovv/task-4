using System;
using System.Runtime.CompilerServices;

namespace task4_2
{
    internal class Program
    {
        class telebe
        {
            public string name;
            public string surname;
            public int age;
            public string speciality;
            public int groupNo;
        }
        static void Main(string[] args)
        { 
            //1 ci tapsiriq
            Console.WriteLine("1 ci ededi daxil edin");
            string num1 = Console.ReadLine();
            Console.WriteLine("2 ci ededi daxil edin");
            string num2 = Console.ReadLine();
            int number1;
            int number2;
            while (!(int.TryParse(num1, out number1) && (int.TryParse(num2, out number2))))
            {
                Console.WriteLine("Sehvdi yeniden daxil edin");
                num1 = Console.ReadLine();
                num2 = Console.ReadLine();
            }
         

            int.TryParse(num1, out number1);
            int.TryParse(num2, out number2);
            int result = number1 + number2;

            if (result %2 ==0)
            {
                Console.WriteLine("cem cut ededdir");
            }
            else
            {
                Console.WriteLine("Cem tek ededdir");    
            }
            //2 ci tapsiriq
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            for (int i = 0; i< num.Length;  i++)
            {
                if (num[i] %2 ==0)
                {
                    Console.WriteLine(num[i]);
                }
            }
            //3 cu tapsiriq
            int sum = 0;
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            for (int i = 0;i< number.Length; i++)
            {
                if (number[i] %2 !=0) {
                    sum += number[i];
                   

                }  
            }


            //4 cu tapsiriq
            //Double netice = Math.Round(a);
            int eded = 2356;
            String string_eded = eded.ToString();
            if (string_eded.Length == 4)
            {
                int number_1 = eded / 1000; //2
                int number_2 = eded % 1000; //356
                int number3 = number_2 / 100; //3
                int number4 = number_2 % 100; //56
                int number5 = number4 / 10; //5
                int number6 = number4 % 10; //6
                int netice = number_1 + number3 + number5 + number6;
                Console.WriteLine($" 4 reqimli ededin reqemlerinin cemi : {netice}");


            }
            else
            {
                Console.WriteLine("Zehmet olmasa 4 reqemli eded daxil edin.");
            }





            Console.WriteLine($"{sum} Tek ededlerin cemi");
            //5 ci tapsiriq
            telebe telebe = new telebe();
            telebe.name = "Ali";
            telebe.surname = "Nazarov";
            telebe.age = 18;
            telebe.speciality = "Full Stack ";
            telebe.groupNo = 419;


            Console.WriteLine($" AD: {telebe.name} Soyad: {telebe.surname} Yasi:{telebe.age} Ixtisasi:{telebe.speciality} GrupNomrsi:{telebe.groupNo}");







        }
    }
}