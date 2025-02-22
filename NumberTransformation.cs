using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3
{
    public class NumberTransformation
    {
        public static void NumberTransformationMain()
        {
            
            List<int> numbers = new List<int> { 1, 5, 10, 15, 3, 8, 12, 4 };

            Console.WriteLine("Original numbers: " + string.Join(", ", numbers));

            
            var transformedNumbers = numbers
                .Select(n => n * 2) 
                .Where(n => n >= 10) 
                .ToList();

            Console.WriteLine("Transformed numbers: " + string.Join(", ", transformedNumbers));
        }
    }
}
