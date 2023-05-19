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
            /*
          Console.WriteLine(IsIsogram("moose"));
            var withdraw = CashWithdrawl(400);
            foreach(var item in withdraw)
            {
                Console.Write($"[{item}] ");
            }
            */

            // MoshExercise3 moshExercise3 = new MoshExercise3();
            //var result = moshExercise3.NameReverse();
            //Console.WriteLine(result);

          // moshExercise3.SortUserInput();

            //FileInfo info = new FileInfo(@"C:\Users\Decagon\OneDrive\Desktop\Victor\ALGORITHMS\ALGORITHMS\Experiment.cs");
            var path = @"Users\Decagon\OneDrive\Desktop\Victor\ALGORITHMS\ALGORITHMS\ALGO.cs";
             string fileName =  Path.GetFileName(path);
             var directoryName = Path.GetDirectoryName(path);
            var justFileName = Path.GetFileNameWithoutExtension(path);
            var getExtension =  Path.GetExtension(path);

                Console.WriteLine($" FileName: {fileName} \n DirectoryName:" +
                $" {directoryName} \n fileNameWithoutExtension: " +
                $"{justFileName} \n fileExtension: {getExtension} ");

            //info.MoveTo(path, true);
            
            
            //var file =  Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            
            //foreach( var item in file )
            //{
            //    Console.WriteLine(item);
            //}

            //File.Create(path);
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


    }
}
