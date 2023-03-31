namespace Cryptography
{
    partial class monofrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ketlbl = new System.Windows.Forms.TextBox();
            this.Keybtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ketlbl
            // 
            this.ketlbl.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.ketlbl.Location = new System.Drawing.Point(46, 12);
            this.ketlbl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ketlbl.Name = "ketlbl";
            this.ketlbl.Size = new System.Drawing.Size(228, 26);
            this.ketlbl.TabIndex = 3;
            this.ketlbl.Text = "zebra";
            this.ketlbl.TextChanged += new System.EventHandler(this.ketlbl_TextChanged);
            // 
            // Keybtn
            // 
            this.Keybtn.Font = new System.Drawing.Font("Calisto MT", 10F);
            this.Keybtn.Location = new System.Drawing.Point(91, 195);
            this.Keybtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Keybtn.Name = "Keybtn";
            this.Keybtn.Size = new System.Drawing.Size(135, 39);
            this.Keybtn.TabIndex = 2;
            this.Keybtn.Text = "Generate Key";
            this.Keybtn.UseVisualStyleBackColor = true;
            this.Keybtn.Click += new System.EventHandler(this.Keybtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.label1.Location = new System.Drawing.Point(1, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.label2.Location = new System.Drawing.Point(1, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 5;
            // 
            // monofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 281);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ketlbl);
            this.Controls.Add(this.Keybtn);
            this.Font = new System.Drawing.Font("Calisto MT", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "monofrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ketlbl;
        private System.Windows.Forms.Button Keybtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}