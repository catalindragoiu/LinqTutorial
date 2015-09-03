using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExamples;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicExamples basicExamples = new BasicExamples();
            basicExamples.LinqQueryIntro();
            
            Console.Read();
        }
    }
}
