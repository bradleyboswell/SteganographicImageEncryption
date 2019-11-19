﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SteganographicImageEncryptor
{
    public partial class Encrypt : Form
    {
        Bitmap controlImage = null; //carrier/control image
        Bitmap inputImage = null;   //image to hide
        Bitmap outputImage = null;  //output image

        int controlBits, inputBits; //masks

        frmDecrypt fDecrypt;    //decryption form

        public Encrypt()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Check to make sure dimensions are equal
            if(inputImage.Width == controlImage.Width && inputImage.Height == controlImage.Height)
            {
                int offset = 8 - (int)bitKey.Value;
                inputBits = 0xFF >> offset; //input mask
                controlBits = 0xFF << (int)bitKey.Value; //control mask

                outputImage = new Bitmap(inputImage.Width, inputImage.Height);

                for (int i = 0; i < inputImage.Width; i++)
                {
                    for (int j = 0; j < inputImage.Height; j++)
                    {
                        //Get indexed pixel from each img
                        var controlPixel = controlImage.GetPixel(i, j);
                        var inputPixel = inputImage.GetPixel(i, j);

                        //Alter colors for outputImg
                        var controlStegR = controlPixel.R & controlBits;
                        var inputStegR = (inputPixel.R >> offset) & inputBits;      //shift and mask via bitkey
                        var outputStegR = controlStegR + inputStegR;

                        var controlStegG = controlPixel.G & controlBits;
                        var inputStegG = (inputPixel.G >> offset) & inputBits;
                        var outputStegG = controlStegG + inputStegG;

                        var controlStegB = controlPixel.B & controlBits;
                        var inputStegB = (inputPixel.B >> offset) & inputBits;
                        var outputStegB = controlStegB + inputStegB;

                        //Set pixel for output img
                        var outColor = Color.FromArgb(outputStegR, outputStegG, outputStegB);
                        outputImage.SetPixel(i, j, outColor);

                    }
                }

                //Scale img for display
                imgOutput.SizeMode = PictureBoxSizeMode.StretchImage;
                imgOutput.ClientSize = new Size(imgOutput.Width, imgOutput.Height);
                imgOutput.Image = outputImage;
            }

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Files|*.png|Bitmap Files| *.bmp";
            saveFileDialog1.Title = "Save Encrypted Image";
            saveFileDialog1.ShowDialog();

            //check for filename
            if(saveFileDialog1.FileName != "")
            {
                //convert image to save
                ImageConverter conv = new ImageConverter();
                byte[] outBytes = (byte[])conv.ConvertTo(imgOutput.Image, typeof(byte[]));
                File.WriteAllBytes(saveFileDialog1.FileName, outBytes);
            }
        }

        private void ImgControl_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files|*.jpg|JPEG Files|*.jpeg|PNG Files|*.png";
            openFileDialog1.Title = "Select Control Image";
            openFileDialog1.ShowDialog();

            //Check to see if a filename was given
            if (openFileDialog1.FileName != "")
            {
                //Scale image for display
                imgControl.SizeMode = PictureBoxSizeMode.StretchImage;
                controlImage = new Bitmap(openFileDialog1.FileName);
                imgControl.ClientSize = new Size(imgControl.Width, imgControl.Height);
                imgControl.Image = controlImage;
            }
        }

        private void ImgInput_Click(object sender, EventArgs e)
        {            
            openFileDialog2.Filter = "JPEG Files|*.jpeg|PNG Files|*.png|JPG Files|*.jpg| AllFiles|*.*";
            openFileDialog2.Title = "Select Image to Encrypt";
            openFileDialog2.ShowDialog();

            //Check to see if a filename was given
            if (openFileDialog2.FileName != "")
            {
                //scale img for display
                imgInput.SizeMode = PictureBoxSizeMode.StretchImage;
                inputImage = new Bitmap(openFileDialog2.FileName);
                imgInput.ClientSize = new Size(imgInput.Width, imgInput.Height);
                imgInput.Image = inputImage;
            }
        }

        private void OpenDecryptWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDecrypt.instantiations == 0)
            {
                fDecrypt = new frmDecrypt();
                fDecrypt.Show();
            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
