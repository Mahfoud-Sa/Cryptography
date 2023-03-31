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

    public partial class homofrm : Form
    {
        char[,] homokey;
        int[] chosenNums;
        public homofrm()
        {
            homokey = Program.homokey;
            chosenNums = new int[10];


            InitializeComponent();
        }

        private void homofrm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form newe = new Homokeylbl();
            newe.ShowDialog();
        }

        private void Keybtn_Click(object sender, EventArgs e)
        {
            homokey = Program.homokey; 
            foreach (Label lbl in panel1.Controls)
            {
                lbl.Text = "";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[0, col] == '_')
                    break;
                lb0.Text += homokey[0, col];
                lb0.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (homokey[1, col] == '_')
                    break;
                lb1.Text += homokey[1, col];
                lb1.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (homokey[2, col] == '_')
                    break;
                lb2.Text += homokey[2, col];
                lb2.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (homokey[3, col] == '_')
                    break;
                lb3.Text += homokey[3, col];
                lb3.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[4, col] == '_')
                    break;
                lb4.Text += homokey[4, col];
                lb4.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[5, col] == '_')
                    break;
                lt5.Text += homokey[5, col];
                lt5.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[6, col] == '_')
                    break;
                lt6.Text += homokey[6, col];
                lt6.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[7, col] == '_')
                    break;
                lt7.Text += homokey[7, col];
                lt7.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[8, col] == '_')
                    break;
                lt8.Text += homokey[8, col];
                lt8.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[9, col] == '_')
                    break;
                lt9.Text += homokey[9, col];
                lt9.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[10, col] == '_')
                    break;
                lt10.Text += homokey[10, col];
                lt10.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (homokey[11, col] == '_')
                    break;
                lt11.Text += homokey[11, col];
                lt11.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (homokey[12, col] == '_')
                    break;
                lt12.Text += homokey[12, col];
                lt12.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[13, col] == '_')
                    break;
                lt13.Text += homokey[13, col];
                lt13.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[14, col] == '_')
                    break;
                lt14.Text += homokey[14, col];
                lt14.Text += "\n";
            }

            for (int col = 0; col < 11; col++)
            {
                if (homokey[15, col] == '_')
                    break;
                lt15.Text += homokey[15, col];
                lt15.Text += "\n";
            }


            for (int col = 0; col < 11; col++)
            {
                if (homokey[16, col] == '_')
                    break;
                lt16.Text += homokey[16, col];
                lt16.Text += "\n";
            }
            
            for (int col = 0; col < 11; col++)
            {
                if (homokey[17, col] == '_')
                    break;
                lt17.Text += homokey[17, col];
                lt17.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[18, col] == '_')
                    break;
                lt18.Text += homokey[18, col];
                lt18.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[19, col] == '_')
                    break;
                lt19.Text += homokey[19, col];
                lt19.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[20, col] == '_')
                    break;
                lt20.Text += homokey[20, col];
                lt20.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[21, col] == '_')
                    break;
                lt21.Text += homokey[21, col];
                lt21.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[22, col] == '_')
                    break;
                lt22.Text += homokey[22, col];
                lt22.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[23, col] == '_')
                    break;
                lt23.Text += homokey[23, col];
                lt23.Text += "\n";
            }
            
            for (int col = 0; col < 11; col++)
            {
                if (homokey[24, col] == '_')
                    break;
                lt24.Text += homokey[24, col];
                lt24.Text += "\n";
            }
            for (int col = 0; col < 11; col++)
            {
                if (homokey[25, col] == '_')
                    break;
                lt25.Text += homokey[25, col];
                lt25.Text += "\n";
            }

            Application.OpenForms["BaseFrm"].Controls.Find("Encryptionbtn", true)[0].Enabled = true;

        }
    }
}
