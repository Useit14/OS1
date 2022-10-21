using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List list = new List();
        Series series;

        private void ToList()
        {
            int[] array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i]);
            }
            series = chart1.Series["Series1"];
            list.Draw(listBox1, series);
        }
        private void buttonPrepend_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                list.Prepend(Convert.ToInt32(textBox1.Text));
                ToList();
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Insert number");
            }

        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            try
            {
      
                listBox1.Items.Clear();
                list.Append(int.Parse(textBox1.Text));
                ToList();
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Insert number");
            }
        }

        private void buttonRemoveByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                int selectIndex = listBox1.SelectedIndex;
                if (selectIndex!=-1)
                {
                    list.RemoveByIndex(selectIndex); ;
                }
                
                listBox1.Items.Clear();
                ToList();
                textBox1.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");
            }
            catch
            {
                MessageBox.Show("Inser number");
            }
        }


        private void Add(object sender, EventArgs e)
        {
            try
            {
                list.Add(int.Parse(textBox1.Text));
                listBox1.Items.Clear();
                ToList();
                textBox1.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");
            }
            catch
            {
                MessageBox.Show("Inser number");
            }
        }

        private void buttonFindByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                int value = list.FindByIndex(int.Parse(textBox1.Text));
                MessageBox.Show(value.ToString());
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");
            }
            catch
            {
                MessageBox.Show("Inser number");
                
            }
        }

        private void buttonFindByKey_Click(object sender, EventArgs e)
        {
            try
            {
                int value = list.FindByKey(int.Parse(textBox1.Text));
                MessageBox.Show(value.ToString());
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");

            }
            catch
            {
                MessageBox.Show("Inser number");
               
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                list.Sort();
                ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}