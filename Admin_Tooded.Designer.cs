namespace Tooded_DB
{
    partial class Admin_Tooded
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
            this.DGW = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Toodenimetus = new System.Windows.Forms.TextBox();
            this.Kogus = new System.Windows.Forms.TextBox();
            this.Hind = new System.Windows.Forms.TextBox();
            this.Kat_Box = new System.Windows.Forms.ComboBox();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW
            // 
            this.DGW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.DGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Location = new System.Drawing.Point(16, 289);
            this.DGW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGW.Name = "DGW";
            this.DGW.RowHeadersWidth = 51;
            this.DGW.Size = new System.Drawing.Size(979, 540);
            this.DGW.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(191, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lisa kategooria";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Lisa_Kategooria);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(299, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kustuta kategooria";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Kustuta_Kategooria);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(408, 224);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Otsi fail";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.OtsiFail);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(516, 224);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "Lisa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Lisa);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(624, 224);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 58);
            this.button5.TabIndex = 5;
            this.button5.Text = "Uuenda";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Uuenda);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(732, 224);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 58);
            this.button6.TabIndex = 6;
            this.button6.Text = "Kustuta";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Kustuta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toode nimetus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kogus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(56, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(56, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kategooria";
            // 
            // Toodenimetus
            // 
            this.Toodenimetus.Location = new System.Drawing.Point(191, 36);
            this.Toodenimetus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Toodenimetus.Name = "Toodenimetus";
            this.Toodenimetus.Size = new System.Drawing.Size(163, 22);
            this.Toodenimetus.TabIndex = 11;
            // 
            // Kogus
            // 
            this.Kogus.Location = new System.Drawing.Point(191, 76);
            this.Kogus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(163, 22);
            this.Kogus.TabIndex = 12;
            // 
            // Hind
            // 
            this.Hind.Location = new System.Drawing.Point(191, 117);
            this.Hind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hind.Name = "Hind";
            this.Hind.Size = new System.Drawing.Size(163, 22);
            this.Hind.TabIndex = 13;
            // 
            // Kat_Box
            // 
            this.Kat_Box.FormattingEnabled = true;
            this.Kat_Box.Location = new System.Drawing.Point(191, 158);
            this.Kat_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kat_Box.Name = "Kat_Box";
            this.Kat_Box.Size = new System.Drawing.Size(163, 24);
            this.Kat_Box.TabIndex = 14;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(624, 31);
            this.pb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(200, 185);
            this.pb.TabIndex = 15;
            this.pb.TabStop = false;
            // 
            // Admin_Tooded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1067, 836);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.Kat_Box);
            this.Controls.Add(this.Hind);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.Toodenimetus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGW);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_Tooded";
            this.Text = "Admin_Tooded";
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Toodenimetus;
        private System.Windows.Forms.TextBox Kogus;
        private System.Windows.Forms.TextBox Hind;
        private System.Windows.Forms.ComboBox Kat_Box;
        private System.Windows.Forms.PictureBox pb;
    }
}

