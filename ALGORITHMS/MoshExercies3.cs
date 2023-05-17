using System;

namespace ALGORITHMS
{
    class MoshExercise3
    {
        static void WhoLikesMe()
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
    }
}
