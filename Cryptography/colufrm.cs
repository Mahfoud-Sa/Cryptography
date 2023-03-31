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
    public partial class colufrm : Form
    {
        public colufrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (kettxtbox.Text == "")
            {
                MessageBox.Show("Enter Key First");
                return;
            }

            label1.Text = generateKey();
            label2.Text = getorder();
            Program.colukey = label1.Text;
            Application.OpenForms["BaseFrm"].Controls.Find("Encryptionbtn", true)[0].Enabled = true;
        }
        private string generateKey()
        {
            
            string newkey = "";


            foreach (char letter in kettxtbox.Text.ToUpper())
            {
                if (!char.IsLetter(letter) || newkey.Contains(letter))
                    continue;

                else
                    newkey += letter;

            }
            return newkey;
        }

        private string getorder()
        {
            string order = "";


            foreach (char letter in label1.Text.ToUpper())
            {
                order+=Convert.ToChar(letter) - 64;
                order += " ";
            }
            return order;

        }
    }
}
