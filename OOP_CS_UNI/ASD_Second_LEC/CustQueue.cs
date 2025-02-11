
using System;

namespace ASD_Second_LEC
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class CustQueue <T>
    {
        private int[] arr;
        private int front, rear, size, capacity;
        
        public void Dequeue() {
            if (size == 0) {
                Console.WriteLine("Queue is empty!");
                return;
            }

            front = (front + 1) % capacity;
            size--;
        }

        private void Resize()
        {
                int newCapacity = capacity * 2;
                int[] newArr = new int[newCapacity];

                for (int i = 0; i < size; i++) {
                    newArr[i] = arr[(front + i) % capacity];
                }

                arr = newArr;
                capacity = newCapacity;
                front = 0;
                rear = size - 1;
        }

        public void Enqueue(int data) {
            if (size == capacity) Resize();

            rear = (rear + 1) % capacity;
            arr[rear] = data;
            size++;
        }

    }
}