Step 1:

using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}

Step 2:

using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Sithamshu!");
        }
    }
}

Step 3:

using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            var name = "Sithamshu";
            Console.WriteLine("Hello " + name + "!");
        }
    }
}

Step 4:

using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            var name = "Sithamshu";
            Console.WriteLine($"Hello {name}!");
        }
    }
}

Step 5:

using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            var name = "Sithamshu";
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    }
}

Step 6:

using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            var names = new List<string> {"Sithamshu","Felipe","Emillia"};
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    }
}
}