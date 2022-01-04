using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class ArithProgression : ISeries
    {
        public int setStart()
        {
            return Convert.ToInt32(Console.ReadLine());//устанавливает начальное значение
        }

        public int getNext()
        {
            int x = setStart();
            int n = Convert.ToInt32(Console.ReadLine());//устанавливает количество членов прогресии
            int d = Convert.ToInt32(Console.ReadLine());//определяет шаг прогрессии
            for (int i = 0; i < n; i++)
            {
                x += d;
                Console.WriteLine(x);
            }
            return x ;
        }

        public void reset()
        {
            int x = setStart();
            Console.WriteLine(x);
        }
    }
}
