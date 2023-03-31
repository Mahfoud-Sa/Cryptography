namespace Cryptography
{
    partial class cuserfrm
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
            this.keyspace = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.G3 = new System.Windows.Forms.Label();
            this.G1 = new System.Windows.Forms.Label();
            this.G2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.keyspace)).BeginInit();
            this.SuspendLayout();
            // 
            // keyspace
            // 
            this.keyspace.Font = new System.Drawing.Font("Tahoma", 14F);
            this.keyspace.Location = new System.Drawing.Point(34, 6);
            this.keyspace.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.keyspace.Name = "keyspace";
            this.keyspace.Size = new System.Drawing.Size(110, 30);
            this.keyspace.TabIndex = 29;
            this.keyspace.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.button1.Location = new System.Drawing.Point(30, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Generate Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateKeybtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.label2.Location = new System.Drawing.Point(69, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = " ";
            // 
            // G3
            // 
            this.G3.AutoSize = true;
            this.G3.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.G3.Location = new System.Drawing.Point(167, 44);
            this.G3.Name = "G3";
            this.G3.Size = new System.Drawing.Size(13, 19);
            this.G3.TabIndex = 33;
            this.G3.Text = " ";
            // 
            // G1
            // 
            this.G1.AutoSize = true;
            this.G1.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.G1.Location = new System.Drawing.Point(43, 44);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(13, 19);
            this.G1.TabIndex = 34;
            this.G1.Text = " ";
            // 
            // G2
            // 
            this.G2.AutoSize = true;
            this.G2.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.G2.Location = new System.Drawing.Point(103, 44);
            this.G2.Name = "G2";
            this.G2.Size = new System.Drawing.Size(13, 19);
            this.G2.TabIndex = 35;
            this.G2.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.label3.Location = new System.Drawing.Point(131, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Degree=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 38;
            // 
            // cuserfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(196, 231);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.G2);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.G3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keyspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cuserfrm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.cuserfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown keyspace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label G3;
        private System.Windows.Forms.Label G1;
        private System.Windows.Forms.Label G2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}