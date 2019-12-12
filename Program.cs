using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = 2;
            //var count = 10;
            //var totalPrice = 20.95f;
            //var character = 'A';
            //var firstName = "ryan";
            //var isWorking = false;

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(firstName);
            //Console.WriteLine(character);
            //Console.WriteLine(isWorking);

            // format string below - 0 is the first argument and 1 is the second argument


            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // declaring a constant
            //const float Pi = 3.14f;

            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);
            // compiles correctly above

            //int i = 1;
            //byte b = (byte) i;
            //Console.WriteLine(b);
            // compiles correctly with the (byte)

            //int i = 1000;
            //byte b = (byte)i;
            //Console.WriteLine(b);
            //// will display 232 because that is the limit of the byte
            ///
            //    var number = "1234";
            //    int i = Convert.ToInt32(number);
            //    Console.WriteLine(i);
            try
            {
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }


           
        }
    }
}
