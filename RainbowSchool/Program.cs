using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RainbowSchool
{
    class TeacherClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int classno { get; set; }
        public string Sectoin { get; set; }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<TeacherClass> teachers = new List<TeacherClass>();
            char ch = ' ';
            do
            {
                Console.WriteLine(" 1-Add\n 2-Display All\n 3-Update\n 4-Exite");
                ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                {
                    case '1':

                        {
                            string path = @"C:\Users\LENOVO\Documents\Teacher";
                            StreamWriter sw = File.AppendText(path);
                            TeacherClass t = new TeacherClass();
                            Console.WriteLine("Enter Teacher ID:");
                            t.ID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Teacher Name:");
                            t.Name = Console.ReadLine();
                            Console.WriteLine("Enter Class no.:");
                            t.classno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Teacher Section:");
                            t.Sectoin = Console.ReadLine();
                            sw.WriteLine($"ID :{t.ID}, Name :{t.Name}, Class no.:{t.classno}, Section :{t.Sectoin}");
                            sw.Close();
                        }
                        break;

                    case '2':
                        { string line;
                        StreamReader sr = new StreamReader(@"C:\Users\LENOVO\Documents\Teacher");
                        //Read the first line of text
                        line = sr.ReadLine();
                        //Continue to read until you reach end of file
                        while (line != null)
                        {
                            //write the lie to console window
                            Console.WriteLine(line);
                            //Read the next line
                            line = sr.ReadLine();
                        }
                        //close the file
                        sr.Close();
                        Console.ReadLine(); 
                }
                        break;

                    case '3':
                        {
                            string filepath = @"C:\Users\LENOVO\Documents\Teacher";
                            Console.WriteLine("Write word you want to replace:  ");
                            string first = Console.ReadLine();
                            Console.WriteLine("Write word you want to Add:  ");
                            string second = Console.ReadLine();
                            StreamReader reader = new StreamReader(filepath);
                            string content = reader.ReadToEnd();
                            reader.Close();
                            content = Regex.Replace(content, first, second);
                            StreamWriter writer = new StreamWriter(filepath);
                            writer.Write(content);
                            writer.Close();
                        }
                        break;
                }
            
            } while (ch != '4');
           
        }
    }
}
                  
