using System;

namespace Operators
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
            //try
            //{
            //    //var number = "1234";
            //    //byte b = Convert.ToByte(number);
            //    //Console.WriteLine(b);
            //    string str = "true";
            //    bool b = Convert.ToBoolean(str);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted to a byte");
            //}

            //var a = 1;
            //var b = 2;
            //var c = 3;

            //// b should multiple by c and then add to a
            //Console.WriteLine(a + b * c);
            //// if you want to add a plus b then multiple by c
            //Console.WriteLine((a+b)*c);

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine((float)a / (float)b);

            // Comparison operator

            //var a = 1;
            //var b = 2;

            //Console.WriteLine(!(a !=b)); // double negative or 2 negative
            //Console.WriteLine(a > b);
            //Console.WriteLine(a == b); // are equal - false
            //Console.WriteLine(a != b); // not equal a and b

            // Logical operators

            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(c > b && c > a); // true return - use and operator
            Console.WriteLine(c > b && c == a); // false since both statements do not equate
            Console.WriteLine(c > b || c == a); // true -- or operator - true or false
            Console.WriteLine(!(c > b || c ==a )); // false 
           
        }
    }
}
