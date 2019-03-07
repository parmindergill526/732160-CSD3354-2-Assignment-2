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
    class Program
    {
        static void Main(string[]args)
        {
            DelegateExercises newDel = new DelegateExercises();
            newDel.Method2();
            Console.ReadLine();
        }
    }
    public class DelegateExercises
    {
        public delegate void MyDelegate();

        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
