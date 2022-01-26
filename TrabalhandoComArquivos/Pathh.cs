using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Pathh
    {
        static void Main(string[] args)
        {
            //Realiza operações com strings que contem informações de arquivos ou pastas
            string path = @"c:\temp\myFolder\file1.txt";

            Console.WriteLine("DirectorSeparatorChar" + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectorName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetfileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetfileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
