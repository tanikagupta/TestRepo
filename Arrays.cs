using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    internal class Arrays
    {
        string[] names = { "Melodie", "John", "Ryan", "Ernie", "Colran" };

        int[] marks = { 98, 78, 88, 78, 90 };

        int[] updatedMarks = new int[5];

        int[,] matrix = {
        { 2,3}, // [0,0] = 2, [0,1] = 3
        {4,5 } // [1,0] = 4, [1,1] = 5
        };

        int[,,] numbers = { //layer, row, col
                {
                    {2,3,4 },
                    {5,6,7 }
                },
                {
                    { 8,9,10},
                    {11,12,13 }
                }

            };

        int[][] jaggedArray = new int[3][];


        public void defineJaggedArray() {
            jaggedArray[0] = new int[] { 1, 2 }; //row1 at index0
            jaggedArray[1] = new int[] { 3, 4, 5 }; //row2 at index1
            jaggedArray[2] = new int[] { 7, 8, 9, 10 }; //row3 at index2
        }

        public void PrintJaggedArray() {
            defineJaggedArray();
            for (int i = 0; i < jaggedArray.Length; i++) { //length : 3
                for (int j = 0; j < jaggedArray[i].Length; j++) { 
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
        }

        public void Print3DArrayValues() {
            Console.WriteLine();
            for (int l = 0; l < numbers.GetLength(0); l++) { //looping through layers

                for (int r = 0; r < numbers.GetLength(1); r++) { //looping through rows
                    for (int c = 0; c < numbers.GetLength(2); c++) {
                        Console.WriteLine(numbers[l, r, c]);
                    }
                }
            }

        }

        public void printMarks() 
        {
            int j = marks.GetLength(1);
            int a = getMarksatLastIndex();
            Console.WriteLine($"Value at last index is {a}");
        }
       // ==, !=, ||, >=, <=, > , < , !
        public int getMarksatLastIndex() {
            object clonedArray = marks.Clone();

            updatedMarks = (int[])clonedArray;

            int marksatLastIndex = marks[marks.Length - 1]; //marks[5-1] --> marks[4]

            string val =  Convert.ToString(marksatLastIndex);
            return marksatLastIndex;
        }

        public void Read2DArray()
        {
            int colLength = matrix.GetLength(1); //2


            for (int i = 0; i < matrix.GetLength(0) ; i++) {
                //nested loops
                Console.Write("[");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]); //2,3 [2,3,4] [5,6,7]
                    if (j != (colLength - 1)){
                        Console.Write(",");
                    }
                }
                Console.Write("]");
            }

            bool marksgreaterthan50 = false;

            if (!marksgreaterthan50) { 
            //Mark the student as failed
            }
        }//[2,3]

        //RunTime Polymorphism(overriding)/compile-time(overloading)
        public void EnterSubjects(string maths, string cs, int c)
        { 
        
        }

        public void EnterSubjects(string maths, string cs, string english)
        {

        }

        public void UserLogin(string username, string password)
        { 
        //validate the credentials
        }

        public FootballPlayer EnterDetailsofFootballPlayer(string name, string team, int Goalsscored ) {

            FootballPlayer objPlayer = new FootballPlayer();
            objPlayer.Name = name;
            objPlayer.Team = team;
            objPlayer.GoalsScored = Goalsscored;

            return objPlayer;
        }
    }
}
