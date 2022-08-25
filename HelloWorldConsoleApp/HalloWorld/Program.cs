using HalloWorld.NamespaceEx;
using System.Collections;

namespace HalloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 20;
            string myName = "Marija";
            bool myBool = false;
            DateTime myDateTime = DateTime.Now;
            object myObject = new { name = "Marija", age = 23, code = true};
            double[] myArray = new double[] { 3.2, 2.66, 10.5 } ;
            List<double> myArray2 = new List<double>() { 3.2, 2.66, 10.5 };

            Console.WriteLine("myNumber: " +  myNumber);
            Console.WriteLine("myName: " +  myName);
            Console.WriteLine("myBool: " + myBool);
            Console.WriteLine("myDateTime: " + myDateTime);
            Console.WriteLine("myObject: " +  myObject);

            foreach (double numbers in myArray)
            {
                Console.WriteLine("numbers: " + numbers);
            }

            foreach (double numbers in myArray2)
            {
                Console.WriteLine("numbers: " + numbers);
            }

            Class1.MyName = "Marija";
            Class1.myMethod();

            // bool isHot = true;
            int myNum = 56;
            long myLongNumber = myNum;

            int myNum2 = Convert.ToInt32(myLongNumber);
            int myNum3 = (int)myLongNumber;

            int i = 75;
            float f = 53.003f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());

            // string myString = d.ToString();

            char c = Convert.ToChar("f");
            char c2 = 'F';
            // char c3 = "F";
            Console.WriteLine(c);
            Console.WriteLine(c2);

            int userNumber;
            Console.WriteLine("Enter a number from 1 to 100 :");
            // userNumber = Console.ReadLine();
            userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(userNumber.GetType());
        }
    }
}