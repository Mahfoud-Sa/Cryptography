using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Homokeylbl : Form
    {
        List<int> allNums;
        List<int> lettersOptchion;
        char[,] keyArray;
        int col;
        public Homokeylbl()
        {
            allNums = new List<int>();
            allNums.Add(0);
            allNums.Add(1);
            allNums.Add(2);
            allNums.Add(3);
            allNums.Add(4);
            allNums.Add(5);
            allNums.Add(6);
            allNums.Add(7);
            allNums.Add(8);
            allNums.Add(9);
            InitializeComponent();
            lettersOptchion = new List<int>();

            keyArray = new char[26, 11];
            col = 0;
        }

        private void choseLettetcombox_SelectedIndexChanged(object sender, EventArgs e)
        {

            letterlbl.Text = choseLettetcombox.SelectedItem.ToString();
            letterNumsCombox.Enabled = true;
            plusbtn.Enabled = true;
            minusbtn.Enabled = true;


        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            if (letterNumsCombox.SelectedItem == null)
                return;

            int temp = Convert.ToInt16(letterNumsCombox.SelectedItem);


            lettersOptchion.Add(temp);

            allNums.Remove(temp);

            letterNumslbl.Text += temp.ToString();

            //refresh item
            letterNumsCombox.Items.Remove(letterNumsCombox.SelectedItem);



        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            if (letterNumslbl.Text == String.Empty)
                return;



            letterNumslbl.Text = letterNumslbl.Text.Substring(0, letterNumslbl.Text.Length - 1);

            int temp = lettersOptchion.Last();
            allNums.Add(temp);

            lettersOptchion.Remove(temp);

            letterNumsCombox.Items.Add(temp);
            letterNumsCombox.Sorted = true;



        }

        private void addKeybtn_Click(object sender, EventArgs e)
        {
            if (letterlbl.Text == String.Empty)
            {
                MessageBox.Show("You Shoud Create a letter ");
                return;
            }
            
                
            string letter = letterlbl.Text + letterNumslbl.Text;


            for (int col = 0; col < letter.Length; col++)
            {
                keyArray[this.col, col] = letter[col];

            }
            col += 1;

            lt0.Text = String.Empty;
            lt1.Text = String.Empty;
            l2.Text = String.Empty;
            lt3.Text = String.Empty;
            lt4.Text = String.Empty;
            lt5.Text = String.Empty; 
            lt6.Text = String.Empty;
            lt7.Text = String.Empty; 
            lt8.Text = String.Empty;
            lt9.Text = String.Empty; 
            lt10.Text = String.Empty;
            lt11.Text = String.Empty;
            lt12.Text = String.Empty;
            lt12.Text = String.Empty;
            lt13.Text = String.Empty;
            lt14.Text = String.Empty;
            lt15.Text = String.Empty;
            lt16.Text = String.Empty;
            lt17.Text = String.Empty;
            lt18.Text = String.Empty;
            lt19.Text = String.Empty;
            lt20.Text = String.Empty;
            lt21.Text = String.Empty;
            lt22.Text = String.Empty;
            lt23.Text = String.Empty;
            lt24.Text = String.Empty;
            lt25.Text = String.Empty;

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[0, col] == '_')
                    break;
                lt0.Text += keyArray[0, col];
                lt0.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[1, col] == '_')
                    break;
                lt1.Text += keyArray[1, col];
                lt1.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[2, col] == '_')
                    break;
                l2.Text += keyArray[2, col];
                l2.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[3, col] == '_')
                    break;
                lt3.Text += keyArray[3, col];
                lt3.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[4, col] == '_')
                    break;
                lt4.Text += keyArray[4, col];
                lt4.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[5, col] == '_')
                    break;
                lt5.Text += keyArray[5, col];
                lt5.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[6, col] == '_')
                    break;
                lt6.Text += keyArray[6, col];
                lt6.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[7, col] == '_')
                    break;
                lt7.Text += keyArray[7, col];
                lt7.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[8, col] == '_')
                    break;
                lt8.Text += keyArray[8, col];
                lt8.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[9, col] == '_')
                    break;
                lt9.Text += keyArray[9, col];
                lt9.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[10, col] == '_')
                    break;
                lt10.Text += keyArray[10, col];
                lt10.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[11, col] == '_')
                    break;
                lt11.Text += keyArray[11, col];
                lt11.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[12, col] == '_')
                    break;
                lt12.Text += keyArray[12, col];
                lt12.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[13, col] == '_')
                    break;
                lt13.Text += keyArray[13, col];
                lt13.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[14, col] == '_')
                    break;
                lt14.Text += keyArray[14, col];
                lt14.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[15, col] == '_')
                    break;
                lt15.Text += keyArray[15, col];
                lt15.Text += "\n";
            }


            for (int col = 0; col < 11; col++)
            {
                if (keyArray[16, col] == '_')
                    break;
                lt16.Text += keyArray[16, col];
                lt16.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[17, col] == '_')
                    break;
                lt17.Text += keyArray[17, col];
                lt17.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[18, col] == '_')
                    break;
                lt18.Text += keyArray[18, col];
                lt18.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[19, col] == '_')
                    break;
                lt19.Text += keyArray[19, col];
                lt19.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[20, col] == '_')
                    break;
                lt20.Text += keyArray[20, col];
                lt20.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[21, col] == '_')
                    break;
                lt21.Text += keyArray[21, col];
                lt21.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[22, col] == '_')
                    break;
                lt22.Text += keyArray[22, col];
                lt22.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[23, col] == '_')
                    break;
                lt23.Text += keyArray[23, col];
                lt23.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (keyArray[24, col] == '_')
                    break;
                lt24.Text += keyArray[24, col];
                lt24.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (keyArray[25, col] == '_')
                    break;
                lt25.Text += keyArray[25, col];
                lt25.Text += "\n";
            }




            choseLettetcombox.Items.Remove(letterlbl.Text);
                lettersOptchion = new List<int>();
                letterNumslbl.Text = string.Empty;
                letterlbl.Text = String.Empty;
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( choseLettetcombox.Items.Count==0)
            {
                Program.homokey = keyArray;
                Control c = Application.OpenForms["homofrm"].Controls.Find("Keybtn", true)[0];
                Button b = (Button) c;
                b.PerformClick();

                Close();
                return;
            }
            else
            MessageBox.Show("you shoud compelete the key");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }

