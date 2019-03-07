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
    public delegate int MyDelegate(out int i);
    public class DelegateExercises
    {
        int Method1(out int i)
        {
            System.Console.WriteLine("Method1" + i);
            i = 10;
            return 0;
        }
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        MyDelegate myDelegate1 = null;
        MyDelegate myDelegate2 = myDelegate + myDelegate1;
        int intValue;
        myDelegate2(out intValue);
    }

}