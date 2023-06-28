using System.Text.RegularExpressions;

namespace UC6_ValidateWebAddressFormat
{
    public class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?");
            Console.WriteLine("Enter a url ");
            string Website = Console.ReadLine();
            if (regex.IsMatch(Website))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }

        }
    }

}
