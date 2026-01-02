using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    class RefrenceTypes
    {
        string strName = "Tanika";
        int a = 3;
        float b = 55.4f;

      

        //int[] marks = new int[5] { 40, 59, 78, 45, 78 };

        int[] marks = { 40, 59, 78, 45, 78 };

        int[,] matrix = {
            { 2,3,7},
            { 8,9,7}
        };

        public RefrenceTypes() { 
         
        }

        //Displaying the names of Refrence Types in c#
        public void DisplayNameofRefTypes() {
            strName = "Hello";
            Console.Write("Refrenece Types are : class, object, string, array, list, pointers etc.");
        }

        public void Dispose() {
            strName = null;
        }

        public void DisplayMarks() {

            Console.WriteLine("The marks of Student is :");
            int len = marks.Rank;
            marks[0] = 88;

            for (int i = 0; i < len; i++) {
                Console.WriteLine($"Marks in sub {i + 1} : " + marks[i]);
                
            }

        }
    }
}
