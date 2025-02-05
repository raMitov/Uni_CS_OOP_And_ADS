using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace ASD_Second_LEC
{
    public class Node<T> //FINISH AT HOME RETARD
    {
        public T value;
        public Node<T> next;

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
            
    }
    public class CustLinkedList<T>
    {
        public Node<T> first { get; set; }
        public Node<T>  last { get; set; }
        public int count { get; set; }

        public CustLinkedList(Node<T> first, Node<T> last , int count)
        {
            this.first = first;
            this.last = last;
            this.count = count;
        }

        public Node<T> Append(T value)
        {
            Node<T> newnode = new Node<T>(value, first);
            newnode.next = last;
            last = newnode;
            count++;
            return newnode;
        }
        public Node<T> Prepend(T value)
        {
            Node<T> newnode = new Node<T>(value, last);
            newnode.next = first;
            first = newnode;
            count++;
            return newnode;
        }
        public Node<T> printList(){
            
            Node<T> currentNode = first;
            return first;
        }


        
    }
}