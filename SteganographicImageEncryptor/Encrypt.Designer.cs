namespace SteganographicImageEncryptor
{
    partial class Encrypt
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
            this.imgControl = new System.Windows.Forms.PictureBox();
            this.imgInput = new System.Windows.Forms.PictureBox();
            this.imgOutput = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDecryptWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bitKey = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitKey)).BeginInit();
            this.SuspendLayout();
            // 
            // imgControl
            // 
            this.imgControl.BackColor = System.Drawing.Color.White;
            this.imgControl.Location = new System.Drawing.Point(31, 128);
            this.imgControl.Name = "imgControl";
            this.imgControl.Size = new System.Drawing.Size(640, 480);
            this.imgControl.TabIndex = 0;
            this.imgControl.TabStop = false;
            this.imgControl.Click += new System.EventHandler(this.ImgControl_Click);
            // 
            // imgInput
            // 
            this.imgInput.BackColor = System.Drawing.Color.White;
            this.imgInput.Location = new System.Drawing.Point(1173, 128);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(640, 480);
            this.imgInput.TabIndex = 1;
            this.imgInput.TabStop = false;
            this.imgInput.Click += new System.EventHandler(this.ImgInput_Click);
            // 
            // imgOutput
            // 
            this.imgOutput.BackColor = System.Drawing.Color.White;
            this.imgOutput.Location = new System.Drawing.Point(601, 692);
            this.imgOutput.Name = "imgOutput";
            this.imgOutput.Size = new System.Drawing.Size(640, 480);
            this.imgOutput.TabIndex = 2;
            this.imgOutput.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1992, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "&Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDecryptWindowToolStripMenuItem});
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.decryptToolStripMenuItem.Text = "Decrypt ";
            // 
            // openDecryptWindowToolStripMenuItem
            // 
            this.openDecryptWindowToolStripMenuItem.Name = "openDecryptWindowToolStripMenuItem";
            this.openDecryptWindowToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openDecryptWindowToolStripMenuItem.Text = "Open Decrypt Window";
            this.openDecryptWindowToolStripMenuItem.Click += new System.EventHandler(this.OpenDecryptWindowToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(769, 51);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(320, 71);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog2_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Image Control";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1404, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Image Output";
            // 
            // bitKey
            // 
            this.bitKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitKey.Location = new System.Drawing.Point(919, 194);
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
            this.bitKey.Size = new System.Drawing.Size(162, 40);
            this.bitKey.TabIndex = 8;
            this.bitKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitKey.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(788, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bit Key:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1992, 1184);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bitKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.imgOutput);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.imgControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Encrypt";
            this.Text = "Encrypt Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgControl;
        private System.Windows.Forms.PictureBox imgInput;
        private System.Windows.Forms.PictureBox imgOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bitKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDecryptWindowToolStripMenuItem;
    }
}

