using System;

namespace ASD_Second_LEC
{
    //FINISH AT HOME DOESNT WORK!!!!
    public class CustArrayList<T>
    {
        public int length { get; set; }
        public T[] array { get; set; }

        public CustArrayList()
        {
            length = length;
            array = array;
        }

        public T get(int index)
        {
            return array[index];
        }

        public void pop()
        {   
            array[length - 1] = default(T);
            length--;
        }

        public void push(T item)
        {
            array[length] = item;
            length++;
        }

        public void delete(int[] array ,int index)
        {
            T bro = this.array[index];
            shiftItems(array, index);
            
        }
        public void shiftItems(int[] array, int index) {
            for (int i = index; i < this.length - 1; i++){
                this.array[i] = this.array[i + 1];
            }
            this.array[this.length - 1] = default(T);
            length--;
        }
        public void print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}