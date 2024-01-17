namespace Tooded_DB
{
    partial class Kassa
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
            this.korv = new System.Windows.Forms.ListBox();
            this.Maksa_btn = new System.Windows.Forms.Button();
            this.val_toode_pb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hindkokku_txt = new System.Windows.Forms.TextBox();
            this.hind_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.val_toode_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // korv
            // 
            this.korv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.korv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.korv.FormattingEnabled = true;
            this.korv.ItemHeight = 16;
            this.korv.Location = new System.Drawing.Point(16, 16);
            this.korv.Margin = new System.Windows.Forms.Padding(4);
            this.korv.Name = "korv";
            this.korv.Size = new System.Drawing.Size(172, 452);
            this.korv.TabIndex = 1;
            // 
            // Maksa_btn
            // 
            this.Maksa_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.Maksa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Maksa_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Maksa_btn.Location = new System.Drawing.Point(457, 460);
            this.Maksa_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Maksa_btn.Name = "Maksa_btn";
            this.Maksa_btn.Size = new System.Drawing.Size(114, 57);
            this.Maksa_btn.TabIndex = 6;
            this.Maksa_btn.Text = "Maksa";
            this.Maksa_btn.UseVisualStyleBackColor = false;
            this.Maksa_btn.Click += new System.EventHandler(this.Maksa);
            // 
            // val_toode_pb
            // 
            this.val_toode_pb.Location = new System.Drawing.Point(371, 23);
            this.val_toode_pb.Margin = new System.Windows.Forms.Padding(4);
            this.val_toode_pb.Name = "val_toode_pb";
            this.val_toode_pb.Size = new System.Drawing.Size(200, 185);
            this.val_toode_pb.TabIndex = 7;
            this.val_toode_pb.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(59, 473);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hind kokku";
            // 
            // hindkokku_txt
            // 
            this.hindkokku_txt.Location = new System.Drawing.Point(16, 492);
            this.hindkokku_txt.Margin = new System.Windows.Forms.Padding(4);
            this.hindkokku_txt.Name = "hindkokku_txt";
            this.hindkokku_txt.Size = new System.Drawing.Size(172, 22);
            this.hindkokku_txt.TabIndex = 8;
            // 
            // hind_txt
            // 
            this.hind_txt.Location = new System.Drawing.Point(197, 43);
            this.hind_txt.Margin = new System.Windows.Forms.Padding(4);
            this.hind_txt.Name = "hind_txt";
            this.hind_txt.Size = new System.Drawing.Size(132, 22);
            this.hind_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(247, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hind";
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(581, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hindkokku_txt);
            this.Controls.Add(this.val_toode_pb);
            this.Controls.Add(this.Maksa_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hind_txt);
            this.Controls.Add(this.korv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kassa";
            this.Text = "Kassa";
            ((System.ComponentModel.ISupportInitialize)(this.val_toode_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox korv;
        private System.Windows.Forms.Button Maksa_btn;
        private System.Windows.Forms.PictureBox val_toode_pb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hindkokku_txt;
        private System.Windows.Forms.TextBox hind_txt;
        private System.Windows.Forms.Label label2;
    }
}