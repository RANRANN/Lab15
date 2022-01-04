using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart();
            arithProgression.getNext();
            arithProgression.reset();
            Console.ReadKey();
        }
    }
}
