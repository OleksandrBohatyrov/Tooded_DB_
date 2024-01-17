using System.Drawing;
using System.Windows.Forms;

namespace Tooded_DB
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.salasona_txt = new System.Windows.Forms.TextBox();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pood_logo = new System.Windows.Forms.PictureBox();
            this.unustasin_btn = new System.Windows.Forms.Button();
            this.loouuuskasutaja_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.logikylalisena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pood_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // salasona_txt
            // 
            this.salasona_txt.Location = new System.Drawing.Point(357, 251);
            this.salasona_txt.Margin = new System.Windows.Forms.Padding(4);
            this.salasona_txt.Name = "salasona_txt";
            this.salasona_txt.PasswordChar = '*';
            this.salasona_txt.Size = new System.Drawing.Size(313, 22);
            this.salasona_txt.TabIndex = 0;
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(357, 219);
            this.login_txt.Margin = new System.Windows.Forms.Padding(4);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(313, 22);
            this.login_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(273, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(273, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salasõna";
            // 
            // pood_logo
            // 
            this.pood_logo.Image = ((System.Drawing.Image)(resources.GetObject("pood_logo.Image")));
            this.pood_logo.Location = new System.Drawing.Point(357, 15);
            this.pood_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pood_logo.Name = "pood_logo";
            this.pood_logo.Size = new System.Drawing.Size(313, 157);
            this.pood_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pood_logo.TabIndex = 4;
            this.pood_logo.TabStop = false;
            // 
            // unustasin_btn
            // 
            this.unustasin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.unustasin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unustasin_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unustasin_btn.Location = new System.Drawing.Point(291, 283);
            this.unustasin_btn.Margin = new System.Windows.Forms.Padding(4);
            this.unustasin_btn.Name = "unustasin_btn";
            this.unustasin_btn.Size = new System.Drawing.Size(139, 49);
            this.unustasin_btn.TabIndex = 5;
            this.unustasin_btn.Text = "Unustasin salasõna";
            this.unustasin_btn.UseVisualStyleBackColor = false;
            this.unustasin_btn.Click += new System.EventHandler(this.unustasin_btn_Click);
            // 
            // loouuuskasutaja_btn
            // 
            this.loouuuskasutaja_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.loouuuskasutaja_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loouuuskasutaja_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loouuuskasutaja_btn.Location = new System.Drawing.Point(437, 283);
            this.loouuuskasutaja_btn.Margin = new System.Windows.Forms.Padding(4);
            this.loouuuskasutaja_btn.Name = "loouuuskasutaja_btn";
            this.loouuuskasutaja_btn.Size = new System.Drawing.Size(139, 49);
            this.loouuuskasutaja_btn.TabIndex = 6;
            this.loouuuskasutaja_btn.Text = "Loo uus kasutaja";
            this.loouuuskasutaja_btn.UseVisualStyleBackColor = false;
            this.loouuuskasutaja_btn.Click += new System.EventHandler(this.loouuuskasutaja_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(680, 219);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(71, 57);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logikylalisena
            // 
            this.logikylalisena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.logikylalisena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logikylalisena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logikylalisena.Location = new System.Drawing.Point(584, 283);
            this.logikylalisena.Margin = new System.Windows.Forms.Padding(4);
            this.logikylalisena.Name = "logikylalisena";
            this.logikylalisena.Size = new System.Drawing.Size(139, 49);
            this.logikylalisena.TabIndex = 8;
            this.logikylalisena.Text = "Logi külalisena";
            this.logikylalisena.UseVisualStyleBackColor = false;
            this.logikylalisena.Click += new System.EventHandler(this.logikylalisena_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1072, 373);
            this.Controls.Add(this.logikylalisena);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.loouuuskasutaja_btn);
            this.Controls.Add(this.unustasin_btn);
            this.Controls.Add(this.pood_logo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.salasona_txt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pood_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salasona_txt;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pood_logo;
        private System.Windows.Forms.Button unustasin_btn;
        private System.Windows.Forms.Button loouuuskasutaja_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button logikylalisena;
    }
}