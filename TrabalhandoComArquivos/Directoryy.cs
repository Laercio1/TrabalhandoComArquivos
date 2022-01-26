using System;
using System.IO;
using System.Collections.Generic;

namespace TrabalhandoComArquivos
{
    class Directoryy
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myFolder";

            try
            {
                //Para listar todas as pastas 
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //Para listar todos os arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Para criar uma nova pasta
                Directory.CreateDirectory(path + "\\newFolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
