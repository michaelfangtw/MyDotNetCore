using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte byteValue = 16;
            short shortValue = -1024;
            int intValue = -1034000;
            long longValue = 1152921504606846976;
            ulong ulongValue = UInt64.MaxValue;

            decimal decimalValue;

            decimalValue = byteValue;
            Console.WriteLine("After assigning a {0} value, the Decimal value is {1}.", 
                            byteValue.GetType().Name, decimalValue); 

            decimalValue = shortValue;
            Console.WriteLine("After assigning a {0} value, the Decimal value is {1}.", 
                            shortValue.GetType().Name, decimalValue); 

            decimalValue = intValue;
            Console.WriteLine("After assigning a {0} value, the Decimal value is {1}.", 
                            intValue.GetType().Name, decimalValue); 

            decimalValue = longValue;
            Console.WriteLine("After assigning a {0} value, the Decimal value is {1}.", 
                            longValue.GetType().Name, decimalValue); 

            decimalValue = ulongValue;
            Console.WriteLine("After assigning a {0} value, the Decimal value is {1}.", 
                            longValue.GetType().Name, decimalValue); 
            // The example displays the following output:
            //    After assigning a Byte value, the Decimal value is 16.
            //    After assigning a Int16 value, the Decimal value is -1024.
            //    After assigning a Int32 value, the Decimal value is -1034000.
            //    After assigning a Int64 value, the Decimal value is 1152921504606846976.
            //    After assigning a Int64 value, the Decimal value is 18446744073709551615.
        }
    }
}
