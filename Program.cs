using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Анатолий", 30);
         
            Console.WriteLine("Имя - {0}", name);
            Console.WriteLine("Возраст - {0}", age);

            Console.WriteLine("Введите имя");
            Console.WriteLine("Введите возраст");

            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вас зовут {0}", name);
            Console.WriteLine("Ваш возраст {0}", age);

            Console.ReadKey();
        }
    }
}
