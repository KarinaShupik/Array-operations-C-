using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Array
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void btn_res_Click(object sender, RoutedEventArgs e)
        {
            //перетворюємо рядок в масив
            string input1 = txt_input1.Text;
            string[] stringArray = input1.Split(',');

            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i].Trim());
            }

            //перетворення масив в рядок
            string arrString = "";
            for (int i = 0; i < intArray.Length; i++)
            {
                arrString += intArray[i].ToString();
                if (i < intArray.Length - 1)
                {
                    arrString += ", ";
                }
            }
            txt_input_res.Text = arrString;

        }

        //1,1
        private void btn_res_min_Click(object sender, RoutedEventArgs e)
        {
            //перетворюємо рядок в масив
            string input1 = txt_input1.Text;
            string[] stringArray = input1.Split(',');

            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i].Trim());
            }

            //знаходимо від'ємні елементиб та додаємо їх до нового динамічного масиву
            List<int> res = new List<int>();
            for (int i = 0; i < intArray.Length; i++)
            {
                if  (intArray[i] < 0)
                {
                    res.Add(intArray[i]);
                }
            }
            //підраховуємо к-сть від'ємних елементів
            string minArrLength = Convert.ToString(res.Count);
            
            txt_input_res2.Text = minArrLength;   
        }
        //1,2
        private void btn_res_sum_Click(object sender, RoutedEventArgs e)
        {
            //перетворюємо рядок в масив
            string input1 = txt_input1.Text;
            string[] stringArray = input1.Split(',');

            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i].Trim());
            }

            List<int> res = new List<int>();
            for (int i = 0; i < intArray.Length; i++)
            {
                res.Add(Math.Abs(intArray[i]));
            }

            int minEl = res.Min();

            int sum = 0;
            foreach (int el in res)
            {
                sum += el;
            }

            double difference = sum - minEl;
            txt_input_res3.Text = Convert.ToString(difference);
        }
        //1,3
        private void btn_res_sort_Click(object sender, RoutedEventArgs e)
        {
            //перетворюємо рядок в масив
            string input1 = txt_input1.Text;
            string[] stringArray = input1.Split(',');

            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i].Trim());
            }

            //підносимо від'ємні елементи до квадрату
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < 0)
                {
                    intArray[i] = (int)Math.Pow(intArray[i], 2);
                }
            }

            //сортуємо масив
            int temp;
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            //перетворення перевернутий масив в рядок
            string arrString = "";
            for (int i = 0; i < intArray.Length; i++)
            {
                arrString += intArray[i].ToString();
                if (i < intArray.Length - 1)
                {
                    arrString += ", ";
                }
            }


            txt_input_res4.Text = arrString;

        }
        //2.1
        private void btn_show_Click(object sender, RoutedEventArgs e)
        {
            
            int colSize = Convert.ToInt32(txt_input_res5.Text);
            int rowSize = Convert.ToInt32(txt_input_res5_1.Text);

            int[,] arr = new int[rowSize, colSize];


            int count = 1; // змінна, яка буде зберігати числа, що ми заповнюємо масив

            //заповняємо масив рандомними числами від 1 до 20
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    arr[i, j] = count;
                    count++;
                }
            }

            //перетворюємо масив в рядок та виводимо його
            string text = "";
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    text += arr[i, j].ToString() + " ";
                }
                text += "\r\n";
            }

            txt_input_res6.Text = text;
        }
        //2.2
        private void btn_show_2_Click(object sender, RoutedEventArgs e)
        {
            int colSize = Convert.ToInt32(txt_input_res5.Text);
            int rowSize = Convert.ToInt32(txt_input_res5_1.Text);

            int[,] arr = new int[rowSize, colSize];


            int count = 1; // змінна, яка буде зберігати числа, що ми заповнюємо масив

            //заповняємо масив рандомними числами від 1 до 20
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    arr[i, j] = count;
                    count++;
                }
            }
            //знаходимо елементи 2 стовпця
            List<int> res = new List<int>();
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    res.Add(arr[i, 1]);
                }
            }
            //знаходимо унікальні елементи
            IEnumerable<int> distinctAges = res.Distinct();

            string arrString = "";
            foreach (int age in distinctAges)
            {
                arrString += age.ToString() + ", ";
            }

            
            txt_input_res7.Text = arrString;
        }
        //2,3
        private void btn_res_row_Click(object sender, RoutedEventArgs e)
        {
            int m = Convert.ToInt32(txt_input_res8.Text);

            int colSize = Convert.ToInt32(txt_input_res5.Text);
            int rowSize = Convert.ToInt32(txt_input_res5_1.Text);

            int[,] arr = new int[rowSize, colSize];


            int count = 1; // змінна, яка буде зберігати числа, що ми заповнюємо масив

            //заповняємо масив рандомними числами від 1 до 20
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    arr[i, j] = count;
                    count++;
                }
            }

            //знаходимо елементи m-рядка
            List<int> res = new List<int>();
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if(m <= rowSize)
                    {
                        res.Add(arr[m, j]);
                    }
                    else
                    {
                        res.Add(0);
                    }
                    
                }
            }

            //знаходимо унікальні елементи
            IEnumerable<int> distinctAges = res.Distinct();

            string arrString = "";
            foreach (int age in distinctAges)
            {
                arrString += age.ToString() + ", ";
            }

            txt_input_res9.Text = arrString;

        }
    }
}
