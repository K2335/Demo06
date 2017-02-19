using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teht01FileApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string data = " ";
            while (true) { 
            
            using (StreamWriter w = File.AppendText("data.txt"))
            {

                if (data == "end") { 
                    w.Close();
                    break;
                    }
                    else { 
                    Console.WriteLine("Type the lines here, type end to stop writing");
                    data = Console.ReadLine();
                    w.WriteLine(data);
                    }

                }
            }


            
            try
            {
                string text = System.IO.File.ReadAllText("data.txt");
                System.Console.WriteLine("Contents of data.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }


        }
        }

    }

