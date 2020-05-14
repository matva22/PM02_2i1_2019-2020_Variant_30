using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;

namespace ConsoleApplication1
{
    class sampleClass
    {
        // Переменные         
        public int x, y;
        public sampleClass(int x = 0, int y = 0)
        {
            this.x = x;             
            this.y = y;         
        }
        // Перегрузка +
        public static sampleClass operator +(sampleClass o1, sampleClass o2)         
        {
            sampleClass res = new sampleClass();             
            res.x = o1.x + o2.x;             
            res.y = o1.y + o2.y;             
            return res;
        }
        // Перегрузка - 
        public static sampleClass operator -(sampleClass o1, sampleClass o2)
        {
            sampleClass res = new sampleClass();             
            res.x = o1.x - o2.x;             
            res.y = o1.y - o2.y;             
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sampleClass j = new sampleClass(100, 64);
            sampleClass obj2 = new sampleClass(-74, 28);
            Console.WriteLine("First object: " + j.x + " " + j.y);
            Console.WriteLine("Second object: " + obj2.x + " " + obj2.y);
            sampleClass obj3 = j + obj2;
            Console.WriteLine("j + obj2: " + obj3.x + " " + obj3.y);
            obj3 = j - obj2;
            Console.WriteLine("j - obj2: " + obj3.x + “ “ + obj3.y);
        }
    }
}