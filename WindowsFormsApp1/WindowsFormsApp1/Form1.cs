using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_RandomNumber_Click(object sender, EventArgs e)
        {

            Random myRan = new Random(); // 隨機亂數的物件 // reference type
            lbl_RandomNumber.Text = myRan.Next(1, 49).ToString(); // 大樂透開到48, 一次開6個號碼
            int[] RandomLotto = new int[6];
            int num1, num2, num3, num4, num5, num6, specialNumber;

            for (int i = 0; i < 6; i++)
            {
                RandomLotto[i] = myRan.Next(1, 49);
                for (int j = 0; j < i; j++)
                {
                    while (RandomLotto[j] == RandomLotto[i])
                    {
                        j = 0; // 當j跟k重複時, j會歸零再重新執行隨機亂數
                        RandomLotto[i] = myRan.Next(1, 49);
                    }// while 會持續重複執行，直到達到指定的條件時，才會停止
                }


               // Console.WriteLine($"{myRan.Next(1, 49)}");
                num1 = myRan.Next(1, 49);
                num2 = myRan.Next(1, 49);
                num3 = myRan.Next(1, 49);
                num4 = myRan.Next(1, 49);
                num5 = myRan.Next(1, 49);
                num6 = myRan.Next(1, 49);
                specialNumber = myRan.Next(1, 9);


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 開啟對獎器

            Form2 myForm2 = new Form2();
            // myForm2.Show();
            myForm2.ShowDialog();

        }

        private void lbl_RandomNumber_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SpecialNumber_Click(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {

        }

        private void num3_Click(object sender, EventArgs e)
        {

        }

        private void num4_Click(object sender, EventArgs e)
        {

        }

        private void num5_Click(object sender, EventArgs e)
        {

        }

        private void num6_Click(object sender, EventArgs e)
        {

        }
    }
}
