using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class BaseFrm : Form
    {
        string outputtxt;
        string algorithm;
        public BaseFrm()
        {
            outputtxt = string.Empty;
            algorithm = string.Empty;
            InitializeComponent();
        }

     

        
        public void ChangeForm(Form modForm)
        {


            modForm.Dock = DockStyle.Fill;
            modForm.TopLevel = false;
            modForm.FormBorderStyle = FormBorderStyle.None;
            Chaildpnl.Controls.Add(modForm);
            modForm.BringToFront();
            modForm.Show();
        }

        


        
        private void Encryptionbtn_Click(object sender, EventArgs e)
        {

            if (Inputtxtbox.Text == string.Empty)
            {
                MessageBox.Show("Enter text first");
                return;
            }
            outputtxt = string.Empty;
            string inputtxt = Inputtxtbox.Text.ToUpper();


            switch (algorithm)
            {
                case "caser":
                    cuserAlgo(inputtxt, Program.cuserkey);
                    break;

                case "mono":
                    monoAlgo(inputtxt, Program.monokey);
                    break;
                case "hono":
                    foreach(char chr in inputtxt)
                    {
                        if (char.IsDigit(chr))
                        {
                            MessageBox.Show("Numbers Can Not Cryptography");
                            return;
                        }
                            

                    }
                    outputtxt = homoAlgo(inputtxt, Program.homokey);
                    break;
                case "play":
                    outputtxt = playAlgo(inputtxt, Program.playkey,true);
                    break;
                case "geom":
                    outputtxt =geomAlog(inputtxt);
                    break;
                case "rail":
                    outputtxt = railAlgo(inputtxt,Program.raikey);
                    break;
            }


            //

            
            Outputtxtbox.Text = outputtxt;
            Decryptionbtn.Enabled = true;
        }

       

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Decryption_Click(object sender, EventArgs e)
        {

            if (Outputtxtbox.Text == string.Empty)
            {
                MessageBox.Show("Enter text first");
                return;
            }
            string inputtxt = Outputtxtbox.Text.ToUpper();


            switch (algorithm)
            {
                case "caser":
                    MessageBox.Show(deCuserAlgo(inputtxt, Program.cuserkey));
                    break;

                case "mono":
                    MessageBox.Show(deMonoAlgo(inputtxt, Program.monokey));
                    break;
                case "hono":
                    MessageBox.Show(deHomoAlgo(inputtxt,Program.homokey));
                    break;
                case "play":
                    MessageBox.Show(Playfair.Cipher(inputtxt,Program.playkey,false));
                    break;
                case "geom":
                    MessageBox.Show(geomAlog(inputtxt));
                    
                    break;
                case "rail":
                    MessageBox.Show(derailAlgo(inputtxt, Program.raikey));
                    break;
            }


            
        }


        //Radio Buttons


        private void Caerbtn_Click(object sender, EventArgs e)
        {

            //form
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(551, 599);
                this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                Inputtxtbox.Size = new Size(523, 83); 
                Chaildpnl.Size = new Size(260, 281);
                Chaildpnl.Location = new Point(281, 132);
                groupBox3.Size = new Size(257, 281);
                Decryptionbtn.Location = new Point(313, 419);
                Encryptionbtn.Location = new Point(107, 419);
                Outputtxtbox.Size = new Size(523, 130);
            //

            algorithm = "caser";
            Chaildpnl.Controls.Clear();
            ChangeForm(new cuserfrm());
        }


        private void Monobtn_Click(object sender, EventArgs e)
        {
            //form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 599);
            this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Inputtxtbox.Size = new Size(523, 83);
            Chaildpnl.Size = new Size(331, 281);
            Chaildpnl.Location = new Point(210, 132);
            groupBox3.Size = new Size(186, 281);
            Decryptionbtn.Location = new Point(313, 419);
            Encryptionbtn.Location = new Point(107, 419);
            Outputtxtbox.Size = new Size(523, 130);
            //

            algorithm = "mono";

            Chaildpnl.Controls.Clear();
            ChangeForm(new monofrm());
        } 

        private void Homobtn_Click(object sender, EventArgs e)
        {
            Inputtxtbox.Size = new Size(653, 83);
            this.ClientSize = new System.Drawing.Size(683, 599);
            Chaildpnl.Size = new Size(462, 281);
            Chaildpnl.Location = new Point(209, 132);
            groupBox3.Size = new Size(182, 281);
            Decryptionbtn.Location = new Point(399, 419);
            Encryptionbtn.Location = new Point(161, 419);
            Outputtxtbox.Size = new Size(653, 130);

            algorithm = "hono";

            Chaildpnl.Controls.Clear();
            ChangeForm(new homofrm());
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            //form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 599);
            this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Inputtxtbox.Size = new Size(523, 83);
            Chaildpnl.Size = new Size(194, 281);
            Chaildpnl.Location = new Point(347, 132);
            groupBox3.Size = new Size(323, 281);
            Decryptionbtn.Location = new Point(313, 419);
            Encryptionbtn.Location = new Point(107, 419);
            Outputtxtbox.Size = new Size(523, 130);
            //

            algorithm = "play";

            Chaildpnl.Controls.Clear();
            ChangeForm(new playfrm());
        }
        private void Geombtn_Click(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 599);
            this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Inputtxtbox.Size = new Size(523, 83);
            Chaildpnl.Size = new Size(112, 281);
            Chaildpnl.Location = new Point(429, 132);
            groupBox3.Size = new Size(405, 281);
            Decryptionbtn.Location = new Point(313, 419);
            Encryptionbtn.Location = new Point(107, 419);
            Outputtxtbox.Size = new Size(523, 130);

            


            algorithm = "geom";
            Chaildpnl.Controls.Clear();
           

            Encryptionbtn.Enabled = true;
        }

        private void railbtn_Click(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 599);
            this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Inputtxtbox.Size = new Size(523, 83);
            Chaildpnl.Size = new Size(175, 281);
            Chaildpnl.Location = new Point(366, 132);
            groupBox3.Size = new Size(342, 281);
            Decryptionbtn.Location = new Point(313, 419);
            Encryptionbtn.Location = new Point(107, 419);
            Outputtxtbox.Size = new Size(523, 130);

            algorithm = "rail";

            Chaildpnl.Controls.Clear();
            ChangeForm(new raifrm());

        }
        private void colubtn_Click(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 599);
            this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Inputtxtbox.Size = new Size(523, 83);
            Chaildpnl.Size = new Size(175, 281);
            Chaildpnl.Location = new Point(366, 132);
            groupBox3.Size = new Size(342, 281);
            Decryptionbtn.Location = new Point(313, 419);
            Encryptionbtn.Location = new Point(107, 419);
            Outputtxtbox.Size = new Size(523, 130);
            algorithm = "colu";

            Chaildpnl.Controls.Clear();
            ChangeForm(new colufrm());


        }


        // Algorithms

        private int mod(int k ,int n)
        {
            return ((k %= n) < 0 ? k + n : k);
        }
        private void cuserAlgo(string plaintxt, int key)
        {


            
            string output = string.Empty;
            foreach (char ch in plaintxt)
            {
                if (char.IsLetter(ch) )
                {

                    char d = char.IsUpper(ch) ? 'A' : 'a';
                    output += Convert.ToChar((mod((ch - key - d), 26) + d));
                        
                    //output += Convert.ToChar((((ch - key - d) % 26) + d));
                }
                else
                    output += ch;


            }
            outputtxt = output;

            //foreach (char ch in plaintxt)
            //{

            //    if (char.IsLetter(ch))
            //    {
                    
            //        outputtxt += Convert.ToChar((((ch + key - 65) % 26) + 65));
            //    }
            //        //outputtxt += Convert.ToChar((((Convert.ToUInt16(ch) - 65) + key) % 26) + 65);
            //    else
            //        outputtxt += ch;

            //}




        }

        private string deCuserAlgo(string inputtxt, int key)
        {

            string output = string.Empty;
            foreach (char ch in inputtxt)
            {
                if (char.IsLetter(ch))
                {
                    char d = char.IsUpper(ch) ? 'A' : 'a';
                output += Convert.ToChar((((ch + key - d) % 26) + d));
                }
                else
                    output += ch;

            }
            return  output;



        }

        private void monoAlgo(string plaintxt, string key)
        {

           
             
            foreach (char chr in plaintxt)
            {
                if (char.IsLetter(chr))
                {
                    int index = Convert.ToInt16(chr) - 65;
                    outputtxt += Program.monokey[index];
                }
                else outputtxt += chr;

            }



        }

        private string deMonoAlgo(string cipertxt, string key)
        {


            string plaintxt = string.Empty;

            foreach (char chr in cipertxt)
            {
                if (char.IsLetter(chr))
                {
                    key.IndexOf(chr);

                    plaintxt += Convert.ToChar(key.IndexOf(chr) + 65);
                }
                else plaintxt += chr;
            }


            return  plaintxt; 
        }

        private  string playAlgo(string input, char[,] keySquare, bool encipher)
        {
            string retVal = string.Empty;

            string tempInput = "";

             foreach (char letter in input)
            {
                if (!char.IsLetter(letter))
                    continue;

                else
                    tempInput += letter;

            }

            int e = encipher ? 1 : -1;

            if ((tempInput.Length % 2) != 0)
                tempInput += "X";

            Inputtxtbox.Text = tempInput;


            for (int i = 0; i < tempInput.Length; i += 2)
            {
                int row1 = 0;
                int col1 = 0;
                int row2 = 0;
                int col2 = 0;

                GetPosition(ref keySquare, char.ToUpper(tempInput[i]), ref row1, ref col1);
                GetPosition(ref keySquare, char.ToUpper(tempInput[i + 1]), ref row2, ref col2);

                if (row1 == row2 && col1 == col2)
                {
                    retVal += new string(SameRowColumn(ref keySquare, row1, col1, e));
                }
                else if (row1 == row2)
                {
                    retVal += new string(SameRow(ref keySquare, row1, col1, col2, e));
                }
                else if (col1 == col2)
                {
                    retVal += new string(SameColumn(ref keySquare, col1, row1, row2, e));
                }
                else
                {
                    retVal += new string(DifferentRowColumn(ref keySquare, row1, col1, row2, col2));
                }
            }

            retVal = AdjustOutput(tempInput, retVal);

            return retVal;
        }

       private string geomAlog(string inputtxt)
        {

            string outputtxt = "";
            
            for(int i= inputtxt.Length-1; i != -1; i--)
            {
                outputtxt += inputtxt[i];
            }
            

            return outputtxt;
        }

        
        public static string railAlgo(string text, int rails)
        {
            text = text.ToUpper();
            text = Regex.Replace(text, @"[^A-Z0-9]", string.Empty);

            var lines = new List<StringBuilder>();

            for (int i = 0; i < rails; i++)
                lines.Add(new StringBuilder());

            int currentLine = 0;
            int direction = 1;

            for (int i = 0; i < text.Length; i++)
            {
                lines[currentLine].Append(text[i]);

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == rails - 1)
                    direction = -1;

                currentLine += direction;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rails; i++)
                result.Append(lines[i].ToString());

            return result.ToString();
        }

        public static string derailAlgo(string text, int rails)
        {
            text = text.ToUpper();
            text = Regex.Replace(text, @"[^A-Z0-9]", string.Empty);

            var lines = new List<StringBuilder>();

            for (int i = 0; i < rails; i++)
            {
                lines.Add(new StringBuilder());
            }

            int[] linesLenght = Enumerable.Repeat(0, rails).ToArray();

            int currentLine = 0;
            int direction = 1;

            for (int i = 0; i < text.Length; i++)
            {
                linesLenght[currentLine]++;

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == rails - 1)
                    direction = -1;

                currentLine += direction;
            }

            int currentChar = 0;

            for (int line = 0; line < rails; line++)
            {
                for (int c = 0; c < linesLenght[line]; c++)
                {
                    lines[line].Append(text[currentChar]);
                    currentChar++;
                }
            }

            StringBuilder result = new StringBuilder();

            currentLine = 0;
            direction = 1;

            int[] currentReadLine = Enumerable.Repeat(0, rails).ToArray();

            for (int i = 0; i < text.Length; i++)
            {

                result.Append(lines[currentLine][currentReadLine[currentLine]]);
                currentReadLine[currentLine]++;

                if (currentLine == 0)
                {
                    direction = 1;
                }
                else if (currentLine == rails - 1)
                {
                    direction = -1;
                }

                currentLine += direction;
            }

            return result.ToString();

        }

        private string homoAlgo(string inputtxt,char[,] key)
        {

            
            string outputtxt = "";
            
            foreach (char letter in inputtxt)
            {

                if (char.IsLetter(letter))
                    {
                    int cip = Convert.ToInt16(letter) - 65;

                    int c = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        if (key[cip, i] == '_')
                            c += 1;

                    }
                    
                    
                    Random temp = new Random();
                    long index=Convert.ToInt64( temp.Next(10 - c));
                    

                    


                    outputtxt += key[cip, index];
                }
                else
                    outputtxt += letter;
            }


            return outputtxt;
        }

        private string deHomoAlgo(string inputtxt, char[,] key)
        {
            string outputtxt = "";
            inputtxt = inputtxt.ToUpper();

            foreach (char letter in inputtxt)
            {
                if (char.IsLetter(letter) || char.IsNumber(letter))
                
                     outputtxt += Convert.ToChar(getIndex(letter));
                
                else
                outputtxt +=letter;
            }


            return outputtxt;
        }

        private int getIndex(char letter)
        {
            int index = 0;
            char[,] key = Program.homokey;
            for (int row = 0; row < 26; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    if (key[row, col] == letter)
                    {
                        index = row;
                        return index + 65;
                    }
                }
            }
            return 0;
        }
        //playfair Algorithms funs
        private string AdjustOutput(string input, string output)
        {
            StringBuilder retVal = new StringBuilder(output);

            for (int i = 0; i < input.Length; ++i)
            {
                if (!char.IsLetter(input[i]))
                    retVal = retVal.Insert(i, input[i].ToString());

                if (char.IsLower(input[i]))
                    retVal[i] = char.ToLower(retVal[i]);
            }

            return retVal.ToString();
        }
        private  void GetPosition(ref char[,] keySquare, char ch, ref int row, ref int col)
        {
            if (ch == 'J')
                GetPosition(ref keySquare, 'I', ref row, ref col);

            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    if (keySquare[i, j] == ch)
                    {
                        row = i;
                        col = j;
                    }
        }

        private  char[] SameRow(ref char[,] keySquare, int row, int col1, int col2, int encipher)
        {
            return new char[] { keySquare[row, Mod((col1 + encipher), 5)], keySquare[row, Mod((col2 + encipher), 5)] };
        }

        private  char[] SameColumn(ref char[,] keySquare, int col, int row1, int row2, int encipher)
        {
            return new char[] { keySquare[Mod((row1 + encipher), 5), col], keySquare[Mod((row2 + encipher), 5), col] };
        }

        private  char[] SameRowColumn(ref char[,] keySquare, int row, int col, int encipher)
        {
            return new char[] { keySquare[Mod((row + encipher), 5), Mod((col + encipher), 5)], keySquare[Mod((row + encipher), 5), Mod((col + encipher), 5)] };
        }

        private  char[] DifferentRowColumn(ref char[,] keySquare, int row1, int col1, int row2, int col2)
        {
            return new char[] { keySquare[row1, col2], keySquare[row2, col1] };
        }

        private  int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbel1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }

    public static class Playfair
    {
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        private static List<int> FindAllOccurrences(string str, char value)
        {
            List<int> indexes = new List<int>();

            int index = 0;
            while ((index = str.IndexOf(value, index)) != -1)
                indexes.Add(index++);

            return indexes;
        }

        private static string RemoveAllDuplicates(string str, List<int> indexes)
        {
            string retVal = str;

            for (int i = indexes.Count - 1; i >= 1; i--)
                retVal = retVal.Remove(indexes[i], 1);

            return retVal;
        }

        private static char[,] GenerateKeySquare(string key)
        {
            char[,] keySquare = new char[5, 5];
            string defaultKeySquare = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            string tempKey = string.IsNullOrEmpty(key) ? "CIPHER" : key.ToUpper();

            tempKey = tempKey.Replace("J", "");
            tempKey += defaultKeySquare;

            for (int i = 0; i < 25; ++i)
            {
                List<int> indexes = FindAllOccurrences(tempKey, defaultKeySquare[i]);
                tempKey = RemoveAllDuplicates(tempKey, indexes);
            }

            tempKey = tempKey.Substring(0, 25);

            for (int i = 0; i < 25; ++i)
                keySquare[(i / 5), (i % 5)] = tempKey[i];

            return keySquare;
        }

        private static void GetPosition(ref char[,] keySquare, char ch, ref int row, ref int col)
        {
            if (ch == 'J')
                GetPosition(ref keySquare, 'I', ref row, ref col);

            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    if (keySquare[i, j] == ch)
                    {
                        row = i;
                        col = j;
                    }
        }

        private static char[] SameRow(ref char[,] keySquare, int row, int col1, int col2, int encipher)
        {
            return new char[] { keySquare[row, Mod((col1 + encipher), 5)], keySquare[row, Mod((col2 + encipher), 5)] };
        }

        private static char[] SameColumn(ref char[,] keySquare, int col, int row1, int row2, int encipher)
        {
            return new char[] { keySquare[Mod((row1 + encipher), 5), col], keySquare[Mod((row2 + encipher), 5), col] };
        }

        private static char[] SameRowColumn(ref char[,] keySquare, int row, int col, int encipher)
        {
            return new char[] { keySquare[Mod((row + encipher), 5), Mod((col + encipher), 5)], keySquare[Mod((row + encipher), 5), Mod((col + encipher), 5)] };
        }

        private static char[] DifferentRowColumn(ref char[,] keySquare, int row1, int col1, int row2, int col2)
        {
            return new char[] { keySquare[row1, col2], keySquare[row2, col1] };
        }

        private static string RemoveOtherChars(string input)
        {
            input = input.ToUpper();
            string text = "";


            foreach (char letter in input)
            {
                if (!char.IsLetter(letter) ) ;

                else
                    text += letter;

            }
            return text;
        }

        private static string AdjustOutput(string input, string output)
        {
            StringBuilder retVal = new StringBuilder(output);

            for (int i = 0; i < input.Length; ++i)
            {
                if (!char.IsLetter(input[i]))
                    retVal = retVal.Insert(i, input[i].ToString());

                if (char.IsLower(input[i]))
                    retVal[i] = char.ToLower(retVal[i]);
            }

            return retVal.ToString();
        }

        public static string Cipher(string input, char[,] keySquare, bool encipher)
        {
            string retVal = string.Empty;

            string tempInput = RemoveOtherChars(input);
            int e = encipher ? 1 : -1;

            if ((tempInput.Length % 2) != 0)
                tempInput += "X";
            
                
            for (int i = 0; i < tempInput.Length; i += 2)
            {
                int row1 = 0;
                int col1 = 0;
                int row2 = 0;
                int col2 = 0;

                GetPosition(ref keySquare, char.ToUpper(tempInput[i]), ref row1, ref col1);
                GetPosition(ref keySquare, char.ToUpper(tempInput[i + 1]), ref row2, ref col2);

                if (row1 == row2 && col1 == col2)
                {
                    retVal += new string(SameRowColumn(ref keySquare, row1, col1, e));
                }
                else if (row1 == row2)
                {
                    retVal += new string(SameRow(ref keySquare, row1, col1, col2, e));
                }
                else if (col1 == col2)
                {
                    retVal += new string(SameColumn(ref keySquare, col1, row1, row2, e));
                }
                else
                {
                    retVal += new string(DifferentRowColumn(ref keySquare, row1, col1, row2, col2));
                }
            }

            retVal = AdjustOutput(tempInput, retVal);

            return retVal;
        }

        //public static string Encrypt(string input, string key)
        //{
        //    if (string.IsNullOrEmpty(key))
        //    {
        //        return "Error: You must enter a keyword";
        //    }
        //    return Cipher(input, key, true);
        //}

        //public static string Decrypt(string input, string key)
        //{
        //    if (string.IsNullOrEmpty(key))
        //    {
        //        return "Error: You must enter a keyword";
        //    }
        //    return Cipher(input, key, false);
        //}
    }

}
