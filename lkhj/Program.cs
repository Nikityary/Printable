using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lkhj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Printable[] printables = new Printable[5];
            printables[1] = new Book("Книга первая");
            printables[2] = new Magazine("Журнал первый");
            printables[3] = new Book("Книга вторая");
            printables[4] = new Magazine("Журнал второй");

            foreach (Printable printable in printables)
            {
                printable.Print();
            }
            
                Book.PrintBooks(printables);
                Console.WriteLine("Это книга");
            
            
                Magazine.PrintMagazine(printables);
                Console.WriteLine("Это журнал");
            
            Console.ReadKey();
        }
    }
}
