using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace List
{
    class List
    {
        int count;
        List<int> list = new List<int>();

        public List()
        {
            count = 0;
        }

        public void Prepend(int elementValue)
        {

            list.Insert(0, elementValue);
        }
        public void Append(int elementValue)
        {
            list.Insert(list.Count,elementValue);
        }
        public void Add(int elementValue)
        {
            list.Add(elementValue);
        }
        public void RemoveByIndex(int index)
        {
            int count = 0;
            foreach(var item in list)
            {
                if (count == index)
                {
                    list.Remove(item);
                }
                count++;
            }
        }
        public void RemoveByKey(int value)
        {
            list.Remove(value);
        }
        public int FindByIndex(int index)
        {
            int count = 0;
            int result=0;
            foreach (var item in list)
            {
                if (count == index)
                {
                     result= list.Find(x => x == item);
                }
                count++;
            }
            return result;
        }
        public int FindByKey(int value)
        {
            return list.Find(x => x == value);
        }
        public void Sort()
        {
            list.Sort();
        }
        
        public int[] ToArray()
        {
            return list.ToArray();
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