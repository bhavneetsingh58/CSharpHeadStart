using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessions
{
    class Generics<T>
    {
        T a;
        public void show(T b)
        {
            a = b;
            Console.WriteLine(a);
        }

        public static void main()
        {
            Generics<int> genInt = new Generics<int>();
            genInt.show(22);

            Generics<string> genString = new Generics<string>();
            genString.show("Singh");
        }
    }
}
