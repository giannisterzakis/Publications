using System;

namespace Publications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Publications";
            Console.ForegroundColor = ConsoleColor.Yellow;


            Book book1 = new Book("Software Development", 10.99, 3, "Liz Gandy");
            BulkBook book2 = new BulkBook("Programming in C#", 20.5, 1, "Linda White");

            Magazine mag1 = new Magazine("C# monthly", 2.5, 10, 10, "September");
            DiscMag dmag1 = new DiscMag("C# programming", 2.5, 10, 10, "September");

            // Display the Title, Author and the copies of the book
            Console.WriteLine(book1.Title + " " + book1.Author + " " + book1.Copies);
            Console.WriteLine(book2.Title + " " + book2.Author + " " + book2.Copies);
            Console.WriteLine(mag1.Title + " " + mag1.CurrIssue + " " + mag1.Copies);
            Console.WriteLine(dmag1.Title + " " + dmag1.CurrIssue + " " + dmag1.Copies);
            Console.WriteLine();

            book2.SellCopy();
            mag1.SellCopy();
            mag1.SellCopy();

            // Display the Title, Author and the new amount of copies of the book
            Console.WriteLine(book1.Title + " " + book1.Author + " " + book1.Copies);
            Console.WriteLine(book2.Title + " " + book2.Author + " " + book2.Copies);
            Console.WriteLine(mag1.Title + " " + mag1.CurrIssue + " " + mag1.Copies);
            Console.WriteLine(dmag1.Title + " " + dmag1.CurrIssue + " " + dmag1.Copies);
            Console.WriteLine();

            mag1.RecvNewIssue("October");

            Console.WriteLine("Receiving a new issue of the DiscMag");
            dmag1.RecvNewIssue("October");
            Console.WriteLine();

            book2.BulkOrder();

            // Display the Title, Author and the new amount of copies of the book
            Console.WriteLine(book1.Title + " " + book1.Author + " " + book1.Copies);
            Console.WriteLine(book2.Title + " " + book2.Author + " " + book2.Copies);
            Console.WriteLine(mag1.Title + " " + mag1.CurrIssue + " " + mag1.Copies);
            Console.WriteLine(dmag1.Title + " " + dmag1.CurrIssue + " " + dmag1.Copies);
            Console.WriteLine();

            // ToString() methods have been invoked for the output of the details
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
            Console.WriteLine(mag1.ToString());
            Console.WriteLine(dmag1.ToString());


            //Exit from application
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press any key to exit: ");
            Console.ReadKey();
        }
    }
}
