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
    public partial class monofrm : Form
    {
        public monofrm()
        {
            InitializeComponent();
        }

        private void ketlbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void Keybtn_Click(object sender, EventArgs e)
        {
            if (ketlbl.Text == "")
            {
                MessageBox.Show("Enter Key First");
                return;
            }
            Program.monokey= GenerateKey(ketlbl.Text);

            label1.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            label2.Text = Program.monokey;

            Application.OpenForms["BaseFrm"].Controls.Find("Encryptionbtn", true)[0].Enabled = true;

        }

        private string GenerateKey(string key)
        {
            key = key.ToUpper();
            string newkey = "";


            foreach (char letter in key)
            {
                if (!char.IsLetter(letter) || newkey.Contains(letter)) ;

                else
                    newkey += letter;

            }


            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (char j in letters)
            {

                if (newkey.Contains(Convert.ToChar(j)))
                    continue;
                else
                    newkey += Convert.ToChar(j);

            }


            return newkey;

        }


    }
}
