using System.Text.RegularExpressions;

namespace UC2_Regex
{
    namespace RegularExpressionPracticeProblem
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a string: ");
                string input = Console.ReadLine();

                string pattern = @"\b[a-z]+(?:_[a-z]+)+\b";
                MatchCollection matches = Regex.Matches(input, pattern);

                if (matches.Count > 0)
                {
                    Console.WriteLine("Found the  sequences of lowercase letters joined by an underscore:");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine(match.Value);
                    }
                }
                else
                {
                    Console.WriteLine("No sequences of lowercase found by letters joined by an underscore.");
                }

                Console.ReadKey();
            }
        }

    }

}