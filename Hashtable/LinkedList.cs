using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{

    public class linkedlist<Gtype>
    {
       public Node<Gtype> head;

        public void Add(Gtype data)
        {
            //Node<Gtype> temp_node = head;

            Node<Gtype> node = new Node<Gtype>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<Gtype> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted in Linkedlist", node.data);
        }
        public int Find(Gtype val)
        {

            Node<Gtype> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(val)) ;
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public void DeleteBetween(Gtype data , int index)
        {
            Node<Gtype> temp = head;
            Node<Gtype> prev = null;
            if (temp != null && temp.data.Equals(data)) ;
            {
                head = temp.next;
                return;
            }
            while (temp != null)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
        }
        public void Display()
        {
            Node<Gtype> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }
        
    }
}

