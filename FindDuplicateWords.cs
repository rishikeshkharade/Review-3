using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_3
{
    internal class FindDuplicateWords
    {
        public static void DuplicateWords()
        {
            Console.WriteLine("Enter a sentence to find duplicate words:");
            string input = Console.ReadLine();

            List<string> words = GetDuplicateWords(input);

            if (words.Count > 0)
            {
                Console.WriteLine("Duplicate words found: " + string.Join(", ", words));
            }
            else
            {
                Console.WriteLine("No duplicate words found.");
            }
        }

        static List<string> GetDuplicateWords(string input)
        {
            Regex regex = new Regex(@"\b(\w+)\b(?=.*\b\1\b)", RegexOptions.IgnoreCase);

            HashSet<string> result = new HashSet<string>();

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
                result.Add(match.Value);

            return new List<string>(result);
        }        
        }
    }
