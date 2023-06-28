using System.Text.RegularExpressions;

namespace UC5_RegexValidFileName
{
    public class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([^\s]+(\.(?i)(jpe?g|png|gif|bmp))$)");

            Console.WriteLine("Enter filename with image file extension : ");
            string filename = Console.ReadLine();
            if (regex.IsMatch(filename))
            {
                Console.WriteLine("Valid file name");
            }
            else
            {
                Console.WriteLine("Invalid file name");
            }
        }
    }
}
