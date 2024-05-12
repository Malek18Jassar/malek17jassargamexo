namespace Game_xo
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
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lagame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btp2 = new System.Windows.Forms.Button();
            this.ptclose = new System.Windows.Forms.Button();
            this.btp1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(349, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 348);
            this.panel4.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 348);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 6);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 6);
            this.panel3.TabIndex = 14;
            // 
            // lagame
            // 
            this.lagame.AutoSize = true;
            this.lagame.BackColor = System.Drawing.Color.Transparent;
            this.lagame.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Bold);
            this.lagame.ForeColor = System.Drawing.Color.White;
            this.lagame.Location = new System.Drawing.Point(110, 76);
            this.lagame.Name = "lagame";
            this.lagame.Size = new System.Drawing.Size(145, 71);
            this.lagame.TabIndex = 13;
            this.lagame.Text = "Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 70);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tic Toc Toe X/o";
            // 
            // btp2
            // 
            this.btp2.BackColor = System.Drawing.Color.Blue;
            this.btp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btp2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btp2.Location = new System.Drawing.Point(93, 202);
            this.btp2.Name = "btp2";
            this.btp2.Size = new System.Drawing.Size(178, 46);
            this.btp2.TabIndex = 9;
            this.btp2.TabStop = false;
            this.btp2.Text = "play 2";
            this.btp2.UseVisualStyleBackColor = false;
            this.btp2.Click += new System.EventHandler(this.btp2_Click);
            // 
            // ptclose
            // 
            this.ptclose.BackColor = System.Drawing.Color.Red;
            this.ptclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ptclose.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptclose.ForeColor = System.Drawing.Color.White;
            this.ptclose.Location = new System.Drawing.Point(115, 296);
            this.ptclose.Name = "ptclose";
            this.ptclose.Size = new System.Drawing.Size(140, 38);
            this.ptclose.TabIndex = 10;
            this.ptclose.TabStop = false;
            this.ptclose.Text = "Close";
            this.ptclose.UseVisualStyleBackColor = false;
            this.ptclose.Click += new System.EventHandler(this.ptclose_Click);
            // 
            // btp1
            // 
            this.btp1.BackColor = System.Drawing.Color.Blue;
            this.btp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btp1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btp1.Location = new System.Drawing.Point(93, 150);
            this.btp1.Name = "btp1";
            this.btp1.Size = new System.Drawing.Size(178, 46);
            this.btp1.TabIndex = 11;
            this.btp1.TabStop = false;
            this.btp1.Text = "play 1";
            this.btp1.UseVisualStyleBackColor = false;
            this.btp1.Click += new System.EventHandler(this.btp1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_xo.Properties.Resources.ma51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(355, 360);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lagame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btp2);
            this.Controls.Add(this.ptclose);
            this.Controls.Add(this.btp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lagame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btp2;
        private System.Windows.Forms.Button ptclose;
        private System.Windows.Forms.Button btp1;
    }
}

