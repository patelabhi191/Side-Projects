using System;
using System.Media;
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
    public partial class HitOrMiss : Form
    {
        int balance = 100;
        int sameNumberCount = 0;
        string quickPickNumbers = "";
      //  string quickPickNumbersTrimmed = "";
      //  string drawNumbersResult = "";

        Random rand = new Random();
        List<int> selection = new List<int>();
        List<int> drawNumbers = new List<int>();
        // SoundPlayer backgroundSound = new SoundPlayer(@"F:\College\Side Projects\Hit Or Miss\Main Page\Main Page\bin\LotterySlow.wav");
        SoundPlayer buttonSound = new SoundPlayer(@"F:\College\Side Projects\Hit Or Miss\Main Page\Main Page\bin\button_press.wav");
        SoundPlayer freePLay = new SoundPlayer(@"F:\College\Side Projects\Hit Or Miss\Main Page\Main Page\bin\Freeplay.wav");

        //Some error strings
        string[] noNumberLeftError = {"Ohh Bhai, Limit ma... Numberej nai","Baaaennnnnnchood pati gya numbers ma bhai", "Eeeela pati gya numbers hoo","Chal Chal have numbers nakhne ","Numbers pati gya laa" };

        
        //  string quickPickNumberss = "";
        public HitOrMiss()
        {
            InitializeComponent();
            label9.SendToBack();
          //  backgroundSound.Play();
            pictureBox2.SendToBack();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Assigning value to label2 - balance amount left
            label2.Text = "$" + balance;
            this.Controls.Add(label2);
            label5.Text = "";
            label6.Text = "";
            label8.Text = "";
            label11.Text = "";

           // SoundPlayer backgroundSound = new SoundPlayer(@"F:\College\Side Projects\Hit Or Miss\Main Page\Main Page\bin\LotterySlow.wav");
           
           // SoundPlayer buttonSound = new SoundPlayer(@"F:\College\Side Projects\Hit Or Miss\Main Page\Main Page\bin\Button.wav");
            


        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "" + balance;
            label2.Refresh();
        }

        private void quickPick_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            //List<int> selection = new List<int>();
            selection.Clear();
            int number;
            for (int i = 0; i < 12; i++)
            {
                do
                {
                    number = rand.Next(1, 25);
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
            textBox11.Text = selection[10] + "";
            textBox12.Text = selection[11] + "";
            
        }
        private void play_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            if (selection.Count < 12)
                MessageBox.Show("Pela 12 number to select kar CHOMu", "Error hoo");
            if (selection.Count == 12)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to play.\nCollect $2 from the customer.", "Ready to Play", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    
                }
                else
                {
                    balance = balance - 2;
                    label2.Text = "$" + balance;
                    this.Controls.Add(label2);

                    //List<int> drawNumbers = new List<int>();
                    int number;
                    drawNumbers.Clear();
                    for (int i = 0; i < 12; i++)
                    {
                        do
                        {
                            number = rand.Next(1, 25);
                        } while (drawNumbers.Contains(number));
                        drawNumbers.Add(number);
                        drawNumbers.Sort();
                    }

                    label5.Text = " " + drawNumbers[0] + "   " + drawNumbers[1] + "  " + drawNumbers[2] + "   " + drawNumbers[3] + "   " + drawNumbers[4] + "   " + drawNumbers[5];
                    label6.Text = drawNumbers[6] + "  " + drawNumbers[7] + "  " + drawNumbers[8] + "  " + drawNumbers[9] + "  " + drawNumbers[10] + "  " + drawNumbers[11];

                    label11.Text = "";
                    checkSameNumbers();
                    winningOrLosing();
                    label2.Refresh();
                }
                
            }
            
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
            textBox11.Text = "";
            textBox12.Text = "";
            selection.Clear();
           
        }

        public void showResult()
        {
            
            if (selection.Count > 12)
            {
                MessageBox.Show("Bhai. 12 Numberej... BC", "Error");
                selection.RemoveAt(selection.Count - 1);
                
            }

            selection.Sort();
            int counter = selection.Count;
            if (counter == 12)
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
                textBox11.Text = selection[10] + "";
                textBox12.Text = selection[11] +"";
            }
            else if (counter == 11)
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
                textBox11.Text = selection[10] + "";
                textBox12.Text = "";
            }
            else if (counter == 10)
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
                textBox11.Text =  "";
                textBox12.Text =  "";
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

        public void checkSameNumbers()
        {
            sameNumberCount = 0;
            string displayNumbers = "";

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (selection[i] == drawNumbers[j])
                    {
                        sameNumberCount++;
                        displayNumbers = displayNumbers +"  " + drawNumbers[j];
                    }
                }
            }
            label8.Text = sameNumberCount + " Numbers Matched\n" + displayNumbers;
           
            
        }

        public void winningOrLosing()
        {
            if (sameNumberCount == 4 || sameNumberCount == 8)
            {
                label11.Text = "Winner $2 no Gandyo";
                balance = balance + 2;
                this.Controls.Add(label2);
            }
            else if (sameNumberCount == 9 || sameNumberCount == 3)
            {
                label11.Text = "Baaeenchod $7";
                balance = balance + 7;
                this.Controls.Add(label2);
            }
            else if (sameNumberCount == 10 || sameNumberCount == 2)
            {
                label11.Text = "Oii Hoii Hoiii $22";
                balance = balance + 22;
                this.Controls.Add(label2);
            }
            else if (sameNumberCount == 11 || sameNumberCount == 1)
            {
                label11.Text = "Jangya faad $500";
                balance = balance + 500;
                this.Controls.Add(label2);
            }
            else if (sameNumberCount == 12 || sameNumberCount == 0)
            {
                label11.Text = "J A C K   P O T \nGand ma nakh paiha";
                balance = balance + 250000;
                this.Controls.Add(label2);
            }
            else if (sameNumberCount == 5)
            {
                label11.Text = "FREE PLAY\nNew Numbers are generated\nHit the play button";
                selection.Clear();
                freePLay.Play();
                string numbersToString = "";
                balance = balance + 2;
                int number;
                for (int i = 0; i < 12; i++)
                {
                    do
                    {
                        number = rand.Next(1, 25);
                    } while (selection.Contains(number));
                    selection.Add(number);
                    selection.Sort();
                }
                for (int t = 0; t < 12; t++)
                    numbersToString = numbersToString + "  " + selection[t];
                MessageBox.Show("New Numbers are \n" + numbersToString, "Free Play");
                showResult();
            }
            else
            {
                label11.Text = "Chodu Banyo. \n$2 gya";
            }

        }
        
        private void button28_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            int counter = selection.Count;
            if (counter < 1)
                MessageBox.Show("Number to select kar","Error found");
            else
            selection.RemoveAt(counter - 1);
            showResult();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            selection.Remove(1);
            selection.Add(1);
            showResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selection.Remove(2);
            selection.Add(2);
            showResult();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selection.Remove(3);
            selection.Add(3);
            showResult();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            selection.Remove(4);
            selection.Add(4);
            showResult();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selection.Remove(5);
            selection.Add(5);
            showResult();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selection.Remove(6);
            selection.Add(6);
            showResult();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selection.Remove(7);
            selection.Add(7);
            showResult();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selection.Remove(8);
            selection.Add(8);
            showResult();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selection.Remove(9);
            selection.Add(9);
            showResult();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selection.Remove(10);
            selection.Add(10);
            showResult();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            selection.Remove(11);
            selection.Add(11);
            showResult();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            selection.Remove(12);
            selection.Add(12);
            showResult();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            selection.Remove(13);
            selection.Add(13);
            showResult();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            selection.Remove(14);
            selection.Add(14);
            showResult();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selection.Remove(15);
            selection.Add(15);
            showResult();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            selection.Remove(16);
            selection.Add(16);
            showResult();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            selection.Remove(17);
            selection.Add(17);
            showResult();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            selection.Remove(18);
            selection.Add(18);
            showResult();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            selection.Remove(19);
            selection.Add(19);
            showResult();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            selection.Remove(20);
            selection.Add(20);
            showResult();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            selection.Remove(21);
            selection.Add(21);
            showResult();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            selection.Remove(22);
            selection.Add(22);
            showResult();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            selection.Remove(23);
            selection.Add(23);
            showResult();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            selection.Remove(24);
            selection.Add(24);
            showResult();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            selection.Remove(25);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
