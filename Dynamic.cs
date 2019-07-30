using System;
using System.Collections.Generic;
using System.Text;

namespace practicecsharp
{

    class Dynamic
    {
        static void Main(string[] args)
        {
            dynamic something = 100;
            Console.WriteLine(something);
            something = "string";
            Console.WriteLine(something);
            something = new { name = "shubho", age = 30 };
            Console.WriteLine(something);
        }
    }
           

}
