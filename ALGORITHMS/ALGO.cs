using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHMS
{
    internal class ALGO
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogram("moose"));
        }

        static bool IsIsogram(string param)
        {
            param = param.ToLower();
            for(int i = 0; i < param.Length; i++)
            {
                var picker = param.Substring(i, 1);
                for(int j = 0; j < param.Length; j++)
                {
                    var checker = param.Substring(j, 1);
                    if(picker ==  checker && i != j)
                    {
                        return false;
                    }
                }
            }
              return true;



        }
    }
}
