using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace List
{
    class List
    {
        int count;
        Node first;
        Node last;


        public List()
        {
            first = null;
            last = null;
            count = 0;
        }

        public void Prepend(int elementValue)
        {

            if (count == 0)
            {
                first = new Node(null, null, elementValue);
                last = new Node(null, null, elementValue);
                first = last;
                count++;

            }
            else
            {
                Node node = new Node(first, null, elementValue);
                first.Prev = node;
                first = node;
                count++;
            }

        }
        public void Append(int elementValue)
        {
            if (count == 0)
            {
                first = new Node(null, null, elementValue);
                last = new Node(null, null, elementValue);
                first = last;
                count++;

            }
            else
            {
                Node node = new Node(null, last, elementValue);
                last.Next = node;
                last = node;
                count++;
            }
        }
        public void Add(int elementValue)
        {
            DivideForMegre(ToArray());
            var prev = first.Prev;
            var current = first;

            while (current != null)
            {
                if (current.element > elementValue)
                {

                    Node node = new Node(current, prev, elementValue);
                    prev.Next = node;
                    current.Prev = node;
                    count++;
                    return;
                }

                prev = current;
                current = current.Next;
            }
            if (prev.element < elementValue)
            {
                Append(elementValue);
                return;
            }
            throw new IndexOutOfRangeException();
        }
        public void RemoveByIndex(int index)
        {
            int i = 0;
            Node current = first;
            Node prev = first.Prev;
            while (current != null)
            {
                if (current == first && i == index)
                {

                    first = null;
                    first = current.Next;
                    count--;
                    return;

                }
                else if (i == index && current.Next == null)
                {
                    prev.Next = current.Next;
                    last = current;
                    count--;
                    return;
                }
                else if (i == index)
                {
                    prev.Next = current.Next;
                    current.Next.Prev = prev;
                    count--;
                    return;
                }
                prev = current;
                current = current.Next;
                i++;
            }
            throw new IndexOutOfRangeException();
        }
        public void RemoveByKey(int value)
        {
            Node current = first;
            Node prev = first.Prev;
            while (current != null)
            {
                if (current == first && current.element == value)
                {

                    first = null;
                    first = current.Next;
                    count--;
                    return;

                }
                if (current.element == value && current.Next == null)
                {
                    prev.Next = current.Next;
                    last = current;
                    count--;
                    return;
                }
                if (current.element == value)
                {
                    prev.Next = current.Next;
                    current.Next.Prev = prev;
                    count--;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new IndexOutOfRangeException();
        }
        public int FindByIndex(int index)
        {
            int i = 0;
            var current = first;
            while (current != null)
            {
                if (i == index)
                {
                    return current.element;
                }
                current = current.Next;
                i++;
            }

            throw new IndexOutOfRangeException();


        }
        public int FindByKey(int value)
        {
            int i = 0;
            var current = first;
            while (current != null)
            {
                if (current.element == value)
                {
                    break;
                }
                current = current.Next;
                i++;
            }
            if (current == null)
            {
                throw new IndexOutOfRangeException();
            }
            return i;
        }
        private int[] MergeSort(int [] target,int[] left,int[]right)
        {
            int indexMinTarget = 0;
            int indexMinLeft = 0;
            int indexMinRight = 0;
            while(indexMinLeft<left.Length && indexMinRight < right.Length)
            {
                if (left[indexMinLeft] <= right[indexMinRight])
                {
                    target[indexMinTarget] = left[indexMinLeft];
                    indexMinLeft++;
                    indexMinTarget++;
                }
                else
                {
                    target[indexMinTarget] = right[indexMinRight];
                    indexMinRight++;
                    indexMinTarget++;
                }
                    
            }
            
                if(indexMinLeft >= left.Length)
                {
                    for (int i = indexMinRight; i < right.Length; i++)
                    {
                        target[indexMinTarget] = right[indexMinRight];
                        indexMinRight++;
                        indexMinTarget++;
                    }
                }
                else
                {
                    for (int j = indexMinLeft; j < left.Length; j++)
                    {
                        target[indexMinTarget] = left[indexMinLeft];
                        indexMinLeft++;
                        indexMinTarget++;
                    }
                }
            return target;
        }
        public void DivideForMegre(int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = array[i];
            }
            for (int j = 0; j < right.Length; j++)
            {
                right[j] = array[mid + j];
            }
            DivideForMegre(left);
            DivideForMegre(right);
            var result=MergeSort(array, left, right);
            var current = first;
            for (int i = 0; i < result.Length; i++)
            {
                current.element = result[i];
                current = current.Next;
            }
        }
        public int[] ToArray()
        {
            var current = first;
            int[] arrayOut = new int[count];
            int i = 0;
            while (current != null)
            {
                arrayOut[i] = current.element;
                i++;
                current = current.Next;
            }
            return arrayOut;
        }
        public  void Draw(ListBox listBox ,Series series)
        {
            int [] currentArray= ToArray();
            series.Points.Clear();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                series.Points.Add(currentArray[i]);
            }
        }
    }
}