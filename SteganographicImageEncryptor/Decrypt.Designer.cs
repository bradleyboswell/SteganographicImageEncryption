namespace SteganographicImageEncryptor
{
    partial class frmDecrypt
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
            this.imgInput = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgOutput = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bitKey = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDecryptedImgAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitKey)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgInput
            // 
            this.imgInput.BackColor = System.Drawing.Color.White;
            this.imgInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgInput.Location = new System.Drawing.Point(39, 209);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(640, 480);
            this.imgInput.TabIndex = 0;
            this.imgInput.TabStop = false;
            this.imgInput.Click += new System.EventHandler(this.ImgInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image to Decrypt";
            // 
            // imgOutput
            // 
            this.imgOutput.BackColor = System.Drawing.Color.White;
            this.imgOutput.Location = new System.Drawing.Point(1085, 209);
            this.imgOutput.Name = "imgOutput";
            this.imgOutput.Size = new System.Drawing.Size(640, 480);
            this.imgOutput.TabIndex = 2;
            this.imgOutput.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1271, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decrypted Image";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(711, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 95);
            this.button1.TabIndex = 4;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bitKey
            // 
            this.bitKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitKey.Location = new System.Drawing.Point(915, 280);
            this.bitKey.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.bitKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitKey.Name = "bitKey";
            this.bitKey.Size = new System.Drawing.Size(120, 44);
            this.bitKey.TabIndex = 5;
            this.bitKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(784, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bit Key:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1786, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDecryptedImgAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDecryptedImgAsToolStripMenuItem
            // 
            this.saveDecryptedImgAsToolStripMenuItem.Name = "saveDecryptedImgAsToolStripMenuItem";
            this.saveDecryptedImgAsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveDecryptedImgAsToolStripMenuItem.Text = "Save Decrypted Img As...";
            this.saveDecryptedImgAsToolStripMenuItem.Click += new System.EventHandler(this.SaveDecryptedImgAsToolStripMenuItem_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog2_FileOk);
            // 
            // frmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 783);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bitKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDecrypt";
            this.Text = "Decrypt Image";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDecrypt_Close);
            this.Load += new System.EventHandler(this.FrmDecrypt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitKey)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown bitKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDecryptedImgAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}