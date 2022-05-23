
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            List linkedlist = new List();
            Console.WriteLine("Enter a choice to perform Linked List Operation:\n");
            Console.WriteLine("1. Add elements\n2. Append element after an element");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
             case 1:
               linkedlist.Add(56);
               linkedlist.Add(30);
               linkedlist.Add(70);
               linkedlist.Display();
               break;
             case 2:
               linkedlist.InsertFirst(70);
               linkedlist.InsertFirst(30);
               linkedlist.InsertFirst(56);
               linkedlist.Display();
               break;
            }
        }
    }
}

