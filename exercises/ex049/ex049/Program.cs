using System;
using System.IO;

namespace ex049
{
    class Program
    {
        //Creating functions to manage files
        static void CreateATextFile(string filename)
        {
            filename += ".txt";
            File.Create(filename).Close(); //.Create don't close the file, so we need to close manually.
            Console.WriteLine("'{0}' was created. Remember, it was created in ex049/bin/Debug/netcoreapp3.1", filename);
        }
        static void WriteFile(string filename)
        {
            filename += ".txt";
            string msg;
            Console.Write("What is the message? ");
            msg = Console.ReadLine();
            File.AppendAllText(filename, msg);
        }
        static void DeleteFile(string filename)
        {
            filename += ".txt";
            File.Delete(filename);
            Console.WriteLine("'{0}' was deleted.", filename);
        }
        static void PrintFileText(string filename)
        {
            filename += ".txt";
            Console.WriteLine(File.ReadAllText(filename));
        }
        static void Main(string[] args)
        {
            CreateATextFile("text");
            WriteFile("text");
            PrintFileText("text");
            DeleteFile("text");
        }
    }
}
