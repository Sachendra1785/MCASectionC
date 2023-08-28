using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCASectionC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            secC calc=new secC();
            Console.WriteLine(" Sum of two integers"+ calc.sum(10,20));
            Console.WriteLine(" Sum of two integers" + calc.sum(10.30f, 20.20f));
            Console.Read();
        }
    }

    class secC { 
    public int sum(int num1,int num2)
        {

            return num1 + num2;
        }
        public float sum(float num1, float num2)
        {

            return num1 + num2;
        }
        public string sum(string str1, string str2)
        {

            return str2 + str1;
        }
    }
}
