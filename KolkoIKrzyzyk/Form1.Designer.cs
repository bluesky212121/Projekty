namespace KolkoIKrzyzyk
{
    partial class Form1
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
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.IleNaIleLabel = new System.Windows.Forms.Label();
            this.SzerokoscUP = new System.Windows.Forms.Button();
            this.WysokoscUP = new System.Windows.Forms.Button();
            this.WysokoscDOWN = new System.Windows.Forms.Button();
            this.SzerokoscDOWN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(861, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gracz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(971, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.label3.Location = new System.Drawing.Point(310, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 153);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.label4.Location = new System.Drawing.Point(470, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 153);
            this.label4.TabIndex = 13;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1040, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Od nowa";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Reset_Click);
            // 
            // IleNaIleLabel
            // 
            this.IleNaIleLabel.AutoSize = true;
            this.IleNaIleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.IleNaIleLabel.Location = new System.Drawing.Point(910, 22);
            this.IleNaIleLabel.Name = "IleNaIleLabel";
            this.IleNaIleLabel.Size = new System.Drawing.Size(67, 31);
            this.IleNaIleLabel.TabIndex = 14;
            this.IleNaIleLabel.Text = "x x x";
            // 
            // SzerokoscUP
            // 
            this.SzerokoscUP.Location = new System.Drawing.Point(865, 56);
            this.SzerokoscUP.Name = "SzerokoscUP";
            this.SzerokoscUP.Size = new System.Drawing.Size(75, 23);
            this.SzerokoscUP.TabIndex = 15;
            this.SzerokoscUP.Text = "/\\";
            this.SzerokoscUP.UseVisualStyleBackColor = true;
            this.SzerokoscUP.Click += new System.EventHandler(this.SzerokoscUP_Click);
            // 
            // WysokoscUP
            // 
            this.WysokoscUP.Location = new System.Drawing.Point(946, 56);
            this.WysokoscUP.Name = "WysokoscUP";
            this.WysokoscUP.Size = new System.Drawing.Size(75, 23);
            this.WysokoscUP.TabIndex = 16;
            this.WysokoscUP.Text = "/\\";
            this.WysokoscUP.UseVisualStyleBackColor = true;
            this.WysokoscUP.Click += new System.EventHandler(this.WysokoscUP_Click);
            // 
            // WysokoscDOWN
            // 
            this.WysokoscDOWN.Location = new System.Drawing.Point(946, 85);
            this.WysokoscDOWN.Name = "WysokoscDOWN";
            this.WysokoscDOWN.Size = new System.Drawing.Size(75, 23);
            this.WysokoscDOWN.TabIndex = 18;
            this.WysokoscDOWN.Text = "\\/";
            this.WysokoscDOWN.UseVisualStyleBackColor = true;
            this.WysokoscDOWN.Click += new System.EventHandler(this.WysokoscDOWN_Click);
            // 
            // SzerokoscDOWN
            // 
            this.SzerokoscDOWN.Location = new System.Drawing.Point(865, 85);
            this.SzerokoscDOWN.Name = "SzerokoscDOWN";
            this.SzerokoscDOWN.Size = new System.Drawing.Size(75, 23);
            this.SzerokoscDOWN.TabIndex = 17;
            this.SzerokoscDOWN.Text = "\\/";
            this.SzerokoscDOWN.UseVisualStyleBackColor = true;
            this.SzerokoscDOWN.Click += new System.EventHandler(this.SzerokoscDOWN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 652);
            this.Controls.Add(this.WysokoscDOWN);
            this.Controls.Add(this.SzerokoscDOWN);
            this.Controls.Add(this.WysokoscUP);
            this.Controls.Add(this.SzerokoscUP);
            this.Controls.Add(this.IleNaIleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Name = "Form1";
            this.Text = "Kolko i krzyzyk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IleNaIleLabel;
        private System.Windows.Forms.Button SzerokoscUP;
        private System.Windows.Forms.Button WysokoscUP;
        private System.Windows.Forms.Button WysokoscDOWN;
        private System.Windows.Forms.Button SzerokoscDOWN;
    }
}

