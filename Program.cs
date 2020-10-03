using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcı ok yazana kadar sayı girişi yapsın. Ok dedikten sonra girdiği tüm sayılar küçükten büyüğe sıralanarak yazılsın.

            string value = string.Empty;
            int[] numbers = new int[0];
            int checkNumber = 0;
            bool check = false;

            for (int i = 0; value != "ok"; i++)
            {
                Console.Write("Sayı : ");
                value = Console.ReadLine();
                check = int.TryParse(value, out checkNumber); //girilen değer sayı mı kontrolü
                if (check)
                {
                    Array.Resize(ref numbers, i + 1);
                    numbers[i]= checkNumber;
                }
                else
                {
                    i--;
                }
            }
            Array.Sort(numbers);

            Array.Reverse(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();



        }
    }
        
    
}

