using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Example.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Didn't Working.");
                Console.WriteLine("Problema no 1");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Didn't Working.");
                Console.WriteLine("Problema no 2");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Didn't Working.");
                Console.WriteLine("Problema no 3");
            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing Application now..");
            }
            Console.ReadLine();

        }
    }
}
