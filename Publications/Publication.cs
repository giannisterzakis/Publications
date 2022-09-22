using System;
using System.Collections.Generic;
using System.Text;

namespace Publications
{
    class Publication
    {
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int copies;

        public int Copies
        {
            get { return copies; }
            set { copies = value; }
        }

        public Publication(String title, double price, int copies)
        {
            this.title = title;
            this.price = price;
            this.copies = copies;
        }

        // Sell one copy
        public void SellCopy()
        {
            copies--;
        }

        // ToString() method has been declared 
        public override String ToString()
        {
            return title;
        }
    }

    // Subclass of Publication is defined
    class Book : Publication
    {
        private String author;

        public String Author
        {
            get { return author; }
            set { author = value; }
        }

        // Constructor of this class 
        public Book(String title, double price, int copies, String author) : base(title, price, copies)
        {
            this.author = author;
        }

        public void OrderCopies(int copies)
        {
            Copies = Copies + copies;
        }

        // ToString() method has been declared 
        public override String ToString()
        {
            return base.ToString() + " by " + author;
        }
    }

    // Subclass of Publication is defined
    class Magazine : Publication
    {
        private int orderQty;

        public int OrderQty
        {
            get { return orderQty; }
            set { orderQty = value; }
        }

        private String currIssue;

        public String CurrIssue
        {
            get { return currIssue; }
            set { currIssue = value; }
        }

        // Constructor of this class 
        public Magazine(String title, double price, int copies, int orderQty,
                String currIssue)
            : base(title, price, copies)
        {
            this.orderQty = orderQty;
            this.currIssue = currIssue;
        }


        // Adjust quantity
        public void AdjustQty(int qty)
        {
            orderQty = qty;
        }

        // Receive new issue
        public virtual void RecvNewIssue(String newIssue)
        {
            Copies = orderQty;
            currIssue = newIssue;
        }

        // ToString() method has been declared 
        public override String ToString()
        {
            return base.ToString() + " (" + currIssue + ")";
        }
    }

    class DiscMag : Magazine
    {
        // Constructor of this class 
        public DiscMag(String title, double price, int copies, int orderQty,
                String currIssue)
            : base(title, price, copies, orderQty, currIssue)
        {

        }

        // Receive new issue
        public override void RecvNewIssue(String newIssue)
        {
            base.RecvNewIssue(newIssue);
            Console.WriteLine("Check discs attached to this magazine");
        }
    }

    class BulkBook : Book
    {
        const int BATCH_SIZE = 100;

        // Constructor of this class 
        public BulkBook(String title, double price, int copies, String author)
            : base(title, price, copies, author)
        {
        }

        public void BulkOrder()
        {
            Copies = Copies + BATCH_SIZE;
        }
    }
}
