using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool flag_break = false;
            Dictionary<char, int> dict = new()
            {
                {'L', 0},
                {'O', 0},
                {'E', 0},
                {'R', 0},
                {'G', 0},
            };

            var set_cnt = Convert.ToInt32(Console.ReadLine());
            List<string> list_str = new();

            for (int i = 0; i < set_cnt; i++)
            {
                list_str.Add(Console.ReadLine());
            }

            list_str.ForEach(str => {
                if (str.Any(x => !dict.Keys.Contains(x)))
                {
                    Console.WriteLine("No");
                    return;
                }
                foreach (var pair in dict) //специально сделал через foreach, хотя удобнее через for
                {
                    dict[pair.Key] = str.Count(x => x == pair.Key);
                }
                for (int i=0;i<dict.Count-1;i++)
                {
                    if (dict.ElementAt(i).Value != 1)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                if (dict.ElementAt(dict.Count-1).Value != 2)
                {
                    Console.WriteLine("No");
                    return;
                }
                Console.WriteLine("Yes");
            });
        }
    }
}
