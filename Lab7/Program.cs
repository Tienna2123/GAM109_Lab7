using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
    

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //a)
            List<int> nums = new List<int>() { 1, 3, 4, 5, 8, 9 };

            var result = nums.Where(num => num > 4).Select(num => num * num);

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("--------------");
            //b)
            string str = "chao mung den voi binh nguyen vo tan";
            var charCount = str.GroupBy(c => c)
                               .ToDictionary(g => g.Key, g => g.Count());

            foreach (var kvp in charCount)
            {
                Console.WriteLine($"'{kvp.Key}' xuất hiện {kvp.Value} lần");
            }
            Console.WriteLine("--------------");
            //c)
            string str1 = "CHAO mung DEN Voi binh nguyen vo tan";
            string[] words = str1.Split(' ');
            var upperWords = words.Where(word => word.All(char.IsUpper));
            foreach (var word in upperWords)
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
