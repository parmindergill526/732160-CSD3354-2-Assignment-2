using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Parminder Singh (732160)
//CSD3354 SECTION2
//ASSIGNMENT 2
//MARCH 6, 2019

//Ankita sharma (730066)
//CSD3354 SECTION2
//ASSIGNMENT 2
//MARCH 6, 2019
namespace DelegatesAndEvents
{
    class program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();

            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
    public delegate int MyDelegate(ref int intValue);
    public class DelegateExercises
    {
        int Method1(ref int intvalue)
        {
            int value = intvalue + 5;
                System.Console.WriteLine("Method1" + intValue);
        }
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        MyDelegate myDelegate1 = new MyDelegate(Method1);
        MyDelegate myDelegate2 = myDelegate + myDelegate1;
        int intParameter = 5; ;
        myDelegate2(ref intParmeter);
    }
}