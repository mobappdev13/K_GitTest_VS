using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\myTemp\myFile.txt";
            string path = @"C:\myTemp";
            string rootPath = @"C:\";
            string directoryName;
            Console.WriteLine();
            Console.WriteLine($"*************************************");
            Console.WriteLine();
            Console.WriteLine($"*** Using file,  path,  creating text files");

            //using Path of System.IO
            //Path.GetDirectoryName;
            directoryName = Path.GetDirectoryName(fileName);
            Console.WriteLine($"GetDirectoryName of ({fileName}) returns {directoryName}");

            directoryName = Path.GetDirectoryName(path);
            Console.WriteLine($"GetDirectoryName of ({path}) returns {directoryName}");


            directoryName = Path.GetDirectoryName(rootPath);
            Console.WriteLine($"GetDirectoryName of ({rootPath}) returns *{directoryName}*");

            Console.WriteLine();
            Console.WriteLine();
            //

            //Console.WriteLine(File.Exists(fileName) ? $"File {fileName} exists." : $"File {fileName} does not exist.");
            //Console.ReadLine();

            //File.Exist; Directory.Exist; Directory.CreateDirectory; File.Create;
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"the file {fileName} does not Exist");
                Console.WriteLine();
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"the directory {path} has been created ");                   
                }
                else
                {
                    Console.WriteLine($"the directory {path} Exist");
                }
                File.Create(fileName);
                Console.WriteLine($"the file {fileName} has been created into {path} ");
            }
            else
            {
                Console.WriteLine($"the file {fileName} Exist into {path}");
            }
            Console.ReadLine();
        }
       
    }
}

