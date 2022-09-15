using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_15_9_22
{
    internal class Properties
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter ISBN : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Book Name : ");
            string book_name = Console.ReadLine();

            Console.WriteLine("Enter the Title : ");
            string book_title = Console.ReadLine();

            Console.WriteLine("Enter the Author Name : ");
            string book_author = Console.ReadLine();

            Console.WriteLine("Enter Quantity of Book : ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Price of one Book : ");
            double price = double.Parse(Console.ReadLine());

            BookStore book = new BookStore();
            book.ISBN = n;
            book.BOOKNAME = book_name;
            book.BOOKTITLE = book_title;
            book.BOOKAUTHOR = book_author;
            book.QUANTITYOFBOOKS = quantity;
            book.BOOKPRICE = price;

            Console.WriteLine("\n\nBill Amount = "+book.QUANTITYOFBOOKS*book.BOOKPRICE+ " Rs");
        }
    }

    public class BookStore
    {
        private int isbn;
        private string bookName;
        private string bookTitle;
        private string bookAuthor;
        private int quantityOfBooks;
        private double bookPrice;

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string  BOOKNAME
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public string BOOKTITLE
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }

        public string BOOKAUTHOR
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        public int QUANTITYOFBOOKS
        {
            get { return quantityOfBooks; }
            set { quantityOfBooks = value; }
        }

        public double BOOKPRICE
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }
    }
}
