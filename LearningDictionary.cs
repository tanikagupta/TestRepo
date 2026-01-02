using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    public class LearningDictionary
    {
        Dictionary<int, string> dictStudents = new Dictionary<int, string>();
        
        int i = 10;
        public LearningDictionary()
        {          
            object num = i; //boxing
            int j = (int)num; //unboxing

            //strongly-typed List<>, Dictionary<>, ArrayList<>
            //Stack :LIFO Push() Pop()
            //Heap/queue Enqueue(), Dequeue() FIFO
        }

        public void AddStudent(string name, int rollNo)
        {
            dictStudents.Add(rollNo, name);
        }


        //Boxing and Unboxing
    }
}
