using System;

namespace ALGORITHMS
{
    class MoshExercise3
    {
        public void WhoLikesMe()
        {

            string name = "", result = "";
            List<string> list = new List<string>();
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

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
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

        public string NameReverse()
        {
            string result = "";
            Console.Write("Enter your name: ");
           string collectName = Console.ReadLine()!;
            char[] convert = collectName.ToCharArray();   
                
            Array.Reverse(convert);

            foreach (char item in convert)
            {
                result +=  item;
            }


            return result;
        }


        public void SortUserInput()
        {
            List <int> numbers = new List<int> ();
           
            int num = 0;
            while(num < 5)
            {
            repeat:
                Console.Write("Enter 5 numbers: ");
                int input = int.Parse(Console.ReadLine()!);
                if (numbers.Contains(input))
                { 
                    Console.Clear();
                    goto repeat;
                }
                numbers.Add(input);
                num++;  
            } 
            
             numbers.Sort ();
            foreach (int input in numbers)
            {
                Console.Write($"{input} ");
            }
        }



    }
}
