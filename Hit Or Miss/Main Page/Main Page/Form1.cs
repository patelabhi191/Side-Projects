using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Page

    
{
    public partial class Form1 : Form
    {
        int balance = 100;
        string quickPickNumbers = "";
        string quickPickNumbersTrimmed = "";
        string drawNumbersResult = "";

        Random rand = new Random();
        List<int> selection = new List<int>();
        List<int> drawNumbers = new List<int>();

        //Some error strings
        string[] noNumberLeftError = {"Ohh Bhai, Limit ma... Numberej nai","Baaaennnnnnchood pati gya numbers ma bhai", "Eeeela pati gya numbers hoo","Chal Chal have numbers nakhne ","Numbers pati gya laa" };

        
        //  string quickPickNumberss = "";
        public Form1()
        {
            InitializeComponent();
            label9.SendToBack();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Assigning value to label2 - balance amount left
            label2.Text = "$" + balance;
            this.Controls.Add(label2);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "" + balance;
            label2.Refresh();
        }

        private void quickPick_Click(object sender, EventArgs e)
        {

            //List<int> selection = new List<int>();
            selection.Clear();
            int number;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    number = rand.Next(1, 26);
                } while (selection.Contains(number));
                selection.Add(number);
                selection.Sort();
            }

            quickPickNumbers = string.Join("   ", selection);
            textBox1.Text = selection[0] +"";
            textBox2.Text = selection[1] + "";
            textBox3.Text = selection[2] + "";
            textBox4.Text = selection[3] + "";
            textBox5.Text = selection[4] + "";
            textBox6.Text = selection[5] + "";
            textBox7.Text = selection[6] + "";
            textBox8.Text = selection[7] + "";
            textBox9.Text = selection[8] + "";
            textBox10.Text = selection[9] + "";

        }
        private void play_Click(object sender, EventArgs e)
        {
            balance = balance - 2;
            label2.Text = "$" + balance;
            this.Controls.Add(label2);

            //List<int> drawNumbers = new List<int>();
            int number;
            drawNumbers.Clear();
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    number = rand.Next(1, 26);
                } while (drawNumbers.Contains(number));
                drawNumbers.Add(number);
                drawNumbers.Sort();
            }

            label5.Text = "  "+drawNumbers[0]+"      "+drawNumbers[1]+"    "+drawNumbers[2]+"     "+drawNumbers[3] +"    "+drawNumbers[4];
            label6.Text = drawNumbers[5] + "    " + drawNumbers[6] + "    "+drawNumbers[7] +"    "+drawNumbers[8] +"    "+drawNumbers[9];

        }

        private void button29_Click(object sender, EventArgs e)
        {
           
        }
        private void clearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text =  "";
            textBox2.Text =  "";
            textBox3.Text =  "";
            textBox4.Text =  "";
            textBox5.Text =  "";
            textBox6.Text =  "";
            textBox7.Text =  "";
            textBox8.Text =  "";
            textBox9.Text =  "";
            textBox10.Text =  "";
            selection.Clear();
           
        }

        public void showResult()
        {
            if (selection.Count > 9)
            {
                MessageBox.Show("Bhai. 10 Numberej... BC", "Error");
                
            }

            selection.Sort();
            int counter = selection.Count;
            if (counter == 10)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = selection[2] + "";
                textBox4.Text = selection[3] + "";
                textBox5.Text = selection[4] + "";
                textBox6.Text = selection[5] + "";
                textBox7.Text = selection[6] + "";
                textBox8.Text = selection[7] + "";
                textBox9.Text = selection[8] + "";
                textBox10.Text = selection[9] + "";
            }
            else if (counter == 9)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = selection[2] + "";
                textBox4.Text = selection[3] + "";
                textBox5.Text = selection[4] + "";
                textBox6.Text = selection[5] + "";
                textBox7.Text = selection[6] + "";
                textBox8.Text = selection[7] + "";
                textBox9.Text = selection[8] + "";
                textBox10.Text = "";
            }
            else if (counter == 8)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = selection[2] + "";
                textBox4.Text = selection[3] + "";
                textBox5.Text = selection[4] + "";
                textBox6.Text = selection[5] + "";
                textBox7.Text = selection[6] + "";
                textBox8.Text = selection[7] + "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else if (counter == 7)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = selection[2] + "";
                textBox4.Text = selection[3] + "";
                textBox5.Text = selection[4] + "";
                textBox6.Text = selection[5] + "";
                textBox7.Text = selection[6] + "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else if (counter == 6)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = selection[2] + "";
                textBox4.Text = selection[3] + "";
                textBox5.Text = selection[4] + "";
                textBox6.Text = selection[5] + "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else if (counter == 5)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = selection[2] + "";
                textBox4.Text = selection[3] + "";
                textBox5.Text = selection[4] + "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else if (counter == 4)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = selection[2] + "";
                textBox4.Text = selection[3] + "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else if (counter == 3)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = selection[2] + "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else if (counter == 2)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = selection[1] + "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else if (counter == 1)
            {
                textBox1.Text = selection[0] + "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Orange;
        }
        private void button28_Click(object sender, EventArgs e)
        {
            int counter = selection.Count;
            if (counter < 1)
                MessageBox.Show("Number to select kar","Error found");
            else
            selection.RemoveAt(counter - 1);
            showResult();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            selection.Add(1);
            showResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selection.Add(2);
            showResult();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selection.Add(3);
            showResult();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            selection.Add(4);
            showResult();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selection.Add(5);
            showResult();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selection.Add(6);
            showResult();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selection.Add(7);
            showResult();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selection.Add(8);
            showResult();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selection.Add(9);
            showResult();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selection.Add(10);
            showResult();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            selection.Add(11);
            showResult();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            selection.Add(12);
            showResult();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            selection.Add(13);
            showResult();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            selection.Add(14);
            showResult();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selection.Add(15);
            showResult();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            selection.Add(16);
            showResult();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            selection.Add(17);
            showResult();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            selection.Add(18);
            showResult();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            selection.Add(19);
            showResult();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            selection.Add(20);
            showResult();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            selection.Add(21);
            showResult();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            selection.Add(22);
            showResult();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            selection.Add(23);
            showResult();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            selection.Add(24);
            showResult();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            selection.Add(25);
            showResult();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
