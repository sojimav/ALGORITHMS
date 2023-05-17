﻿using System;
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
            /*
            Console.WriteLine(IsIsogram("moose"));
            var withdraw = CashWithdrawl(400);
            foreach(var item in withdraw)
            {
                Console.Write($"{item} ");
            }

             Cash_Register cash_Register = new Cash_Register();
             cash_Register.Register(230);

            */

             WhoLikesMe();
           // Console.WriteLine(result);
            
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


        static List<int> CashWithdrawl(int amount)
        {
            int hundred = amount/100;
            amount %= 100;
            int fifty = amount / 50;
            amount %= 50;
            int twenty = amount / 20;
            var list = new List<int> { hundred, fifty, twenty };

            return list;
            
        }


        static void WhoLikesMe()
        {

            string name = "";
           string result = "";
            var list = new List<string>();
            do
            {
                Console.Write("Enter a name: ");
                name = Console.ReadLine()!;
                if (!String.IsNullOrEmpty(name))
                {
                    list.Add(name);
                }
                
            }
            while (!String.IsNullOrWhiteSpace(name));

           
            Console.WriteLine();
            //list.Remove("");
            if(list.Count > 0)
            {
                for(int i = 0; i < list.Count; i++)
                {
                result = (list.Count == 1) ? $"{list[0]} likes this" : (list.Count == 2) ?
                        $"{list[0]} and {list[1]} like your post" 
                        : $"{list[0]}, {list[1]} and {list.Count - 2} others like your post.";

                }
                Console.WriteLine(result);
            }
            else
            Console.WriteLine(" no one likes this");
        
        }


    }
}

