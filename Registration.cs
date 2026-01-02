using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Training
{
    public partial class Registration : Form
    {
        
        protected string name;
        private float b = 99.5f; //4 bytes
        private double c = 99.55; //8 bytes
        private decimal d = 99.55m; //16 bytes

        private char alpha = 'a'; // 2 bytes

        private bool x = true;//false //1 byte

        private int a ; //4 bytes
        private short val = 3000; //2 bytes
        private long longVal = 88990099; // 8 bytes

        public Registration()
        {
            InitializeComponent();
            //RefrenceTypes objRef = new RefrenceTypes();
            //objRef.DisplayMarks();
        }

        public void DisplayInfo(string name, string address)
        {
            Console.WriteLine("Display the Information Enetered in Registration Form");
        }

        
    }

    //public : no restrictions
    //private : within the same class
    //protected : within the same class or derived class
    //internal : within the same project
    //protected internal : within the same project or derived class
    //private protected : Very restricted, Within the same class or derived classes

    //value types : int, float, char, bool, double, decimal, byte , short, long
    //refrence type : stores address : string, array. class
    //pointer types : 

    public class ChildForm : Registration
    {
        private void DisplayName() {
            Console.WriteLine(name);
        }

        public void DisplayInfo(string name, string address)
        {
            int a = 2 + 3;
            Console.WriteLine($"Sum is {a}");
        }
    }
}
