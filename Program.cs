using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        delegate int findcube(int x);
        //findcube cube=x => x * x * x;
        static void Main(string[] args)
        {
            Func<int,int> cube = z => z * z * z;//findcube cube=z=>z*z*z;
            int x = cube(5);
            Console.WriteLine(x);
            List<int> ListObject = new List<int> { 10,20,30,40,50,60,70,80,90,100};
            //ListObject.Select(y=>y==60)
            Console.WriteLine(ListObject.Select(y => y == 60));
            Console.ReadKey();
        }
    }
}
