using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    enum days
    {
        sumday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }

    class enums
    {
        enum names {
        nived ,
        james,
        clara,
        karlson
        
        }

        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Red;//these are pre defined enums
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("my name is Nived K");
            //Console.WriteLine(days.friday);
            days birthday = days.friday;
            Console.WriteLine(birthday);

        }
    }
}
