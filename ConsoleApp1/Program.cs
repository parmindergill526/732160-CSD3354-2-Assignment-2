﻿using System;
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
namespace DelegateAndEvents
{
    class program
    {
        static void Main(string[] args)
        {
            DelegateExercises a = new DelegateExercises();
            a.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {

            System.Console.WriteLine(MyDelegate.ToString());
        }
    }
}
