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
    public partial class raifrm : Form
    {
        public raifrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputtxtLenght = textLenght();
            if (keyspace.Value >= inputtxtLenght)
            {
               
                MessageBox.Show("Failed Depth,\nYou Must Choise Depth less than the  lenght of Plain Text {with out the space}");
                return;
            }
                Program.raikey = Convert.ToInt16(keyspace.Value);

            Application.OpenForms["BaseFrm"].Controls.Find("Encryptionbtn", true)[0].Enabled = true;
        }

        private int textLenght()
        {
            string text = Application.OpenForms["BaseFrm"].Controls.Find("Inputtxtbox", true)[0].Text;
            int c = 0;
            foreach (char letter in text)
            {
                if (letter==' ')
                    c += 1;

            }
            return Text.Length-c;

        }
    }
}
