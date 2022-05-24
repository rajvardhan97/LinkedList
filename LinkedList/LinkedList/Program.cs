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
            Console.WriteLine("1. Add elements\n2. Append element after an element\n3. Insert an element in between\n" +
                "4. Delete first element\n5. Delete last element\n6. Search an element\n7. Insert after a specific element\n" +
                "8. Delete an element and show size\n9. Display Linked List in ascending order\n");
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
                    case 3:
                        linkedlist.Add(56);
                        linkedlist.Add(70);
                        linkedlist.Display();
                        Console.WriteLine("After adding in between\n");
                        linkedlist.InsertInBetween(2, 30);
                        linkedlist.Display();
                        break;
                    case 4:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.Display();
                        linkedlist.Pop();
                        break;
                    case 5:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.Display();
                        linkedlist.PopLast();
                        break;
                    case 6:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.Display();
                        linkedlist.Search(3);
                        break;
                    case 7:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.Display();
                        linkedlist.InsertAtPosition(30, 40);
                        break;
                    case 8:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(40);
                        linkedlist.Add(70);
                        linkedlist.Display();
                        int location = linkedlist.SearchLocation(40);
                        Console.WriteLine("After deletion");
                        linkedlist.DeleteNode(location);
                        linkedlist.Display();
                        linkedlist.Size();
                        break;
                    case 9:
                        linkedlist.AddSort(56);
                        linkedlist.AddSort(30);
                        linkedlist.AddSort(40);
                        linkedlist.AddSort(70);
                        linkedlist.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
        }
    }
}

