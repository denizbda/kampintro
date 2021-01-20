using System;

namespace Antreman
{
    class Program
    {
        static void Add()
        {
            Console.WriteLine("added.");





        }
        //eğer hesap için 2. değer verilmezse Default değer kullanılır. 
        static int Add2(int number1, int number2 = 100)
        {
            var result = number1 + number2;
            return result;
        }




        static int Add3(ref int number1, int number2) //ref ve out = değer veri türünü referans veri türüne dünüştürür.
        {
            //out'un farkı = out kullanımında başlangıç değerinin verilmesine gerek yoktur.
            number1 = 30;
            return number1 + number2;
        }

        static int carpma(int number1, int number2)
        {
            return number1 * number2;
        }

        static int carpma(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;

        }

        static int Add4(params int[] numbers) //params= sınırsız değer alabilir.
        {
            return numbers.sum();
        }


        static void Main(string[] args)
        {

            //Add();
            // Add();
            // Add();
            //  Add();
            // var result = Add2(20);

            // int number1 = 20;
            // int number2 = 32;
            // var result2 = Add3(ref number1, number2);
            // Console.WriteLine(number1);



            // Console.WriteLine(result2);


            Console.WriteLine(carpma(2,4));
            Console.WriteLine(carpma(2,4,6));
            Console.WriteLine(Add4(2,3,4,5,6,7));
            Console.ReadLine();
            

           

            
        }
    }
}
