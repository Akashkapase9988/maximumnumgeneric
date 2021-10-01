using System;

namespace maximumno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);
            string strigoutput = MaximumNumberCheck.MaximumStringNumber("22", "33", "44");
            Console.WriteLine(strigoutput);
            //int[] intArray = { 112, 344, 432, 555, 678 };
            //uc3GenericMaximum<int> generic = new uc3GenericMaximum<int>(intArray);
            //generic.PrintMaxValue();
            //double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            //uc3GenericMaximum<double> genericDouble = new uc3GenericMaximum<double>(doubleArray);
            //genericDouble.PrintMaxValue();
            //string[] stringArray = { "111", "222", "333", "55", "999" };
            //uc3GenericMaximum<string> genericString = new uc3GenericMaximum<string>(stringArray);
            //GenericMaximum<Employee> genericString = new GenericMaximum<string>(stringArray);
            //genericString.PrintMaxValue();
            //Console.ReadKey();
            //int num = uc1integer.MaximumIntegerNumber(12, 25, 68);
            //Console.WriteLine(num);
            //uc2float.MaximumFloatNumber(123.2, 25.5, 65.58);
        }

    }

}