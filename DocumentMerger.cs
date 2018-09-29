using System;

namespace DocumentMerger
{
    class public class Program
    {
        public static void Main(string[] args)
        {
            String file1, file3, name1, name2, merge, answer;

            Console.WriteLine("Document Merger");
            Console.WriteLine();

            do
            {

            Console.WriteLine("Enter name of file: ");
            name1=Console.ReadLine();

            while(File.Exists(name1)==false)
            {
                Console.Write("Try again");
                name1=Console.ReadLine();
            }

            Console.WriteLine("Enter secondname of file: ");
            name2=Console.ReadLine();

            while(File.Exists(name2)==false)
            {
                Console.Write("Try again");
                name2=Console.ReadLine();
            }
            
            doc1=name1 + ".txt";
            doc2=name2 + ".txt";

            merge= doc1 + doc2;
            merge += ".txt";

            int count=0;
            
            StreamWriter writer=null;
            StreamReader Doc1= null;
            StreamReader Doc2= null;
            
            string line1, line2, merger;

            try
            {
                 while((line1=Doc1.ReadLine()!=null))
                 {
                     count += line1.Length;
                     merger += Doc1;

                 }


                 while((line2=Doc2.ReadLine()!=null))
                 {
                     count +=line2.Length;
                     merger+= Doc2;
                 }

                 writer.WriteLine(merger);
                 Console.WriteLine(merge + "was successfully saved. The document containts" +count+ "characters");

                  catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

                Console.WriteLine("Do you want to merge more files? 1=yes 2=no ");
                answer=Console.ReadLine();
                if(answer!=1)
                {
                  System.Environment.Exit(1);
                }
            }
                while(answer==1);
            }
            
        }
    }
}