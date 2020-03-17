using System.IO;
using static System.Console;
using static System.IO.File;
namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Fun with StreamWriter / StreamReader *****\n");

            // Get a StreamWriter and write string data.
            using (StreamWriter writer = CreateText("reminders.txt"))
            {
                writer.WriteLine("Don't forget Mother's Day this year...");
                writer.WriteLine("Don't forget Father's Day this year...");
                writer.WriteLine("Don't forget these numbers:");
                for (int i = 0; i < 10; i++)
                    writer.Write(i + " ");

                // Insert a new line.
                writer.Write(writer.NewLine);
            }

            WriteLine("Created file and wrote some thoughts...");

            WriteLine("Here are your thoughts:\n");
            using (StreamReader sr = OpenText("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                    WriteLine(input);
            }
            ReadLine();
        }
    }
}
