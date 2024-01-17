using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tooded_DB
{
    partial class Esileht
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
            this.button1 = new System.Windows.Forms.Button();
            this.reklaam = new System.Windows.Forms.Label();
            this.allhind = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(116, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logi sisse e-poodi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Logi_sisse);
            // 
            // reklaam
            // 
            this.reklaam.ForeColor = System.Drawing.Color.Snow;
            this.reklaam.Location = new System.Drawing.Point(456, 307);
            this.reklaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reklaam.Name = "reklaam";
            this.reklaam.Size = new System.Drawing.Size(133, 25);
            this.reklaam.TabIndex = 1;
            this.reklaam.Text = "Logides sisse saate";
            // 
            // allhind
            // 
            this.allhind.ForeColor = System.Drawing.Color.Red;
            this.allhind.Location = new System.Drawing.Point(635, 307);
            this.allhind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allhind.Name = "allhind";
            this.allhind.Size = new System.Drawing.Size(29, 25);
            this.allhind.TabIndex = 9;
            this.allhind.Text = "5%";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(456, 331);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Vaata rohkem poodis!";
            // 
            // Esileht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(807, 619);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.allhind);
            this.Controls.Add(this.reklaam);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Esileht";
            this.Text = "Esileht";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label reklaam;
        private Label allhind;
        private Label label9;
    }
}