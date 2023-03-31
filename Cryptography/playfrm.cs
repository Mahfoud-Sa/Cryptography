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
    public partial class playfrm : Form
    {
        public playfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ketlbl.Text == "")
            {
                MessageBox.Show("Enter Key First");
                return;
            }
            Program.playkey = GenerateKeySquare(ketlbl.Text);

            label1.Text = GenerateKeylbl();

            Application.OpenForms["BaseFrm"].Controls.Find("Encryptionbtn", true)[0].Enabled = true;
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
            string temp = "";
            foreach (char letter in key)
            {
                if (!char.IsLetter(letter) ) ;

                else
                    temp += letter;

            }
            key = temp;
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

        private static List<int> FindAllOccurrences(string str, char value)
        {
            List<int> indexes = new List<int>();

            int index = 0;
            while ((index = str.IndexOf(value, index)) != -1)
                indexes.Add(index++);

            return indexes;
        }

        private string GenerateKeylbl()
        {
            string keylbl = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Program.playkey[i, j] == 'I')
                    {
                        keylbl += "I/J";
                        keylbl += "  ";
                        continue;
                    }
                        
                    keylbl += Program.playkey[i,j];
                    keylbl += "    ";


                }
                keylbl += "\n";
            }
            return keylbl;
        }
        private void playfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
