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
    public partial class cuserfrm : Form
    {
        public cuserfrm()
        {
            InitializeComponent();
        }

        private void GenerateKeybtn_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt16(keyspace.Value % 26);
            label1.Text = "A =\nB =\nC =\nD =\nE =\nF =\nG =\nH =\nI=";
            G1.Text = g1(key);
            label2.Text= "J =\nK =\nL =\nM =\nN =\nO =\nP= \nQ= \nR =";
            G2.Text = g2(key);
            label3.Text = "S =\nT =\nU =\nV =\nW =\nX =\nY= \nZ=";
            G3.Text = g3(key);
            Program.cuserkey = key;
            label5.Text = key.ToString();
           Application.OpenForms["BaseFrm"].Controls.Find("Encryptionbtn", true)[0].Enabled = true;

        }
        private string g1(int key)
        {
            
            string _g1 = "";
            for(int i=0; i < 9; i++)
            {
                _g1 += Convert.ToChar(((i + key) % 26) + 65);
                _g1 += "\n";

                   
            }
            return _g1;
        }
        private string g2(int key)
        {

            string _g2 = "";
            for (int i = 9; i <18 ; i++)
            {
                _g2 += Convert.ToChar(((i + key)%26) + 65);
                _g2 += "\n";


            }
            return _g2;
        }

        private string g3(int key)
        {

            string _g3 = "";
            for (int i = 18; i < 26; i++)
            {
                _g3 += Convert.ToChar(((i + key) % 26) + 65);
                _g3 += "\n";


            }
            return _g3;
        }
        private void cuserfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
