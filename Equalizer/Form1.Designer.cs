﻿namespace Equalizer
{
    partial class _form_eq
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._txt_fileName = new System.Windows.Forms.TextBox();
            this._btn_browse = new System.Windows.Forms.Button();
            this._musicFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._btn_playpause = new System.Windows.Forms.Button();
            this._tb_volume = new System.Windows.Forms.TrackBar();
            this._btn_tmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._tb_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // _txt_fileName
            // 
            this._txt_fileName.Location = new System.Drawing.Point(11, 12);
            this._txt_fileName.Name = "_txt_fileName";
            this._txt_fileName.Size = new System.Drawing.Size(696, 23);
            this._txt_fileName.TabIndex = 0;
            // 
            // _btn_browse
            // 
            this._btn_browse.Location = new System.Drawing.Point(713, 12);
            this._btn_browse.Name = "_btn_browse";
            this._btn_browse.Size = new System.Drawing.Size(75, 23);
            this._btn_browse.TabIndex = 1;
            this._btn_browse.Text = "Browse";
            this._btn_browse.UseVisualStyleBackColor = true;
            this._btn_browse.Click += new System.EventHandler(this._btwn_browse_Click);
            // 
            // _musicFileDialog
            // 
            this._musicFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this._musicFileDialog_FileOk);
            // 
            // _btn_playpause
            // 
            this._btn_playpause.Location = new System.Drawing.Point(12, 41);
            this._btn_playpause.Name = "_btn_playpause";
            this._btn_playpause.Size = new System.Drawing.Size(22, 23);
            this._btn_playpause.TabIndex = 2;
            this._btn_playpause.UseVisualStyleBackColor = true;
            this._btn_playpause.Click += new System.EventHandler(this._btn_playpause_Click);
            // 
            // _tb_volume
            // 
            this._tb_volume.Location = new System.Drawing.Point(40, 41);
            this._tb_volume.Name = "_tb_volume";
            this._tb_volume.Size = new System.Drawing.Size(104, 45);
            this._tb_volume.TabIndex = 3;
            this._tb_volume.Scroll += new System.EventHandler(this._tb_volume_Scroll);
            // 
            // _btn_tmp
            // 
            this._btn_tmp.Location = new System.Drawing.Point(188, 41);
            this._btn_tmp.Name = "_btn_tmp";
            this._btn_tmp.Size = new System.Drawing.Size(303, 23);
            this._btn_tmp.TabIndex = 4;
            this._btn_tmp.Text = "Save 10 seconds of audio with EQ to desktop folder\r\n";
            this._btn_tmp.UseVisualStyleBackColor = true;
            this._btn_tmp.Click += new System.EventHandler(this._btn_tmp_Click);
            // 
            // _form_eq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btn_tmp);
            this.Controls.Add(this._tb_volume);
            this.Controls.Add(this._btn_playpause);
            this.Controls.Add(this._btn_browse);
            this.Controls.Add(this._txt_fileName);
            this.Name = "_form_eq";
            this.Text = "Equalizer Project";
            ((System.ComponentModel.ISupportInitialize)(this._tb_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _txt_fileName;
        private Button _btn_browse;
        private OpenFileDialog _musicFileDialog;
        private Button _btn_playpause;
        private TrackBar _tb_volume;
        private Button _btn_tmp;
    }
}