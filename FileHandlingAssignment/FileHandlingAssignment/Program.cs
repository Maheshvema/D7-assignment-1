using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string path = "C:\\Users\\Sai Yaswanth\\OneDrive\\Desktop\\simplilearn\\Day-7 Assignment-1";
            //    Console.WriteLine("Enter File Name:");
            //    string fname = Console.ReadLine();
            //    string fpath = path + fname;
            //    if (!File.Exists(fpath))
            //    {
            //        File.Create(fpath);
            //        Console.WriteLine($"File{fname} creation success");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"this file {fname} already exist");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error!!!" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finish");
            //    Console.ReadKey();
            //}
            //    Console.WriteLine("Enter file path");
            //    string fpath = Console.ReadLine();
            //    if(File.Exists(fpath)) 
            //    {
            //        Console.WriteLine("File Already there");
            //    }
            //    else
            //    {
            //        StreamWriter sw = File.AppendText(fpath);
            //        sw.WriteLine("welecome to c# assignment");
            //        sw.Dispose();
            //        sw.Close();
            //        Console.WriteLine("created and text is written");
            //    }
            //Console.ReadKey();
            //StreamReader sr;
            //try
            //{
            //    string fpath = "C:\\Users\\Sai Yaswanth\\OneDrive\\Desktop\\simplilearn\\Day-7 Assignment-1\\hello.txt";
            //    sr = new StreamReader(fpath);
            //    string text = " ";
            //    while ((text = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(text);
            //    }
            //    sr.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("error!!!" + ex.Message);
            //}
            //finally
            //{
            //    Console.ReadKey();
            //}

            //string fappend = "C:\\Users\\Sai Yaswanth\\OneDrive\\Desktop\\simplilearn\\Day-7 Assignment-1\\hello.txt";
            //using(StreamWriter sw = File.AppendText(fappend))
            //{
            //    sw.WriteLine("its a demo");
            //}
            //string readappend=File.ReadAllText(fappend);
            //Console.WriteLine(readappend);
            //Console.ReadKey();
            string path = "C:\\Users\\Sai Yaswanth\\OneDrive\\Desktop\\simplilearn\\Day-7 Assignment-1";
            Console.WriteLine("Enter file name to Delete");
            string fileName = Console.ReadLine();
            string dirPath = path + "\\" + fileName;
            DirectoryInfo di = new DirectoryInfo(dirPath);
            try
            {
                if (di.Exists)
                {
                    di.Delete();
                    Console.WriteLine("The Folder " + fileName + "deleted!!");

                }
                else
                {
                    Console.WriteLine("The folder " + fileName + " is doesn't exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
            Console.ReadKey();
        }
    }
}


