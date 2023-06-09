using System;

namespace ALGORITHMS
{
    class MoshExercise3
    {
        public int id;
        public string name;
        public List<string> list;
        public MoshExercise3()
        {

        }

        public MoshExercise3(int id)
            :this()
        {
            this.id = id;
        }

        public MoshExercise3(string name,  List<string> list)
        {
             this.id = id;
            this.name = name;
            this.list = list;
        }
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

        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        public void Exercise4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }


        public static string NumberToOrdinal(int number)
        {
            switch (number % 100)
            {
                case 11:
                case 12:
                case 13:
                    return number + "th";
            }
            if (number <= 0)
            {
                return "0";
            }
            else if (number.ToString().EndsWith("1"))
            {
                return number + "st";
            }
            else if (number.ToString().EndsWith("2"))
            {
                return number + "nd";
            }
            else if (number.ToString().EndsWith("3"))
            {
                return number + "rd";
            }
            else
            {
                return number + "th";
            }
        }

    }
}
