﻿namespace Equalizer
{
    partial class EqualizerOptions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EqualizerOptions));
            this._btn_addnode = new System.Windows.Forms.Button();
            this._btn_delnode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btn_addnode
            // 
            this._btn_addnode.AllowDrop = true;
            this._btn_addnode.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btn_addnode.Location = new System.Drawing.Point(440, 95);
            this._btn_addnode.Name = "_btn_addnode";
            this._btn_addnode.Size = new System.Drawing.Size(52, 52);
            this._btn_addnode.TabIndex = 0;
            this._btn_addnode.Text = "+";
            this._btn_addnode.UseVisualStyleBackColor = true;
            this._btn_addnode.Click += new System.EventHandler(this._btn_addnode_Click);
            // 
            // _btn_delnode
            // 
            this._btn_delnode.AllowDrop = true;
            this._btn_delnode.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btn_delnode.Location = new System.Drawing.Point(440, 153);
            this._btn_delnode.Name = "_btn_delnode";
            this._btn_delnode.Size = new System.Drawing.Size(52, 52);
            this._btn_delnode.TabIndex = 1;
            this._btn_delnode.Text = "-";
            this._btn_delnode.UseVisualStyleBackColor = true;
            this._btn_delnode.Click += new System.EventHandler(this._btn_delnode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(435, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 292);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EqualizerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btn_delnode);
            this.Controls.Add(this._btn_addnode);
            this.DoubleBuffered = true;
            this.Name = "EqualizerOptions";
            this.Size = new System.Drawing.Size(498, 298);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button _btn_addnode;
        private Button _btn_delnode;
        private PictureBox pictureBox1;
    }
}
