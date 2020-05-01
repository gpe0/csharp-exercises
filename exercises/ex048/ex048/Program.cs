using System;
using System.IO; //To work with files, we should use System.IO

namespace ex048
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working with files | The file will be created in ex048/bin/Debug/netcoreapp3.1
            string msg = "Hi, today i'm creating files with some code!";
            File.WriteAllText("text.txt", msg);

            //Some information:
            //AppendAllText() - appends text to the end of the file.
            //Create() - creates a file in the specified location.
            //Delete() - deletes the specified file.
            //Exists() - determines whether the specified file exists.
            //Copy() - copies a file to a new location.
            //Move() - moves a specified file to a new location
        }
    }
}
