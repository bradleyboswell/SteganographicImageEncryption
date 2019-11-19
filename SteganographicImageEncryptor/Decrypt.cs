using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteganographicImageEncryptor
{
    public partial class frmDecrypt : Form
    {
        public static int instantiations = 0;   //used to limit amount of instantiations of this form
        Bitmap inputImage = null;
        Bitmap outputImage = null;
        public frmDecrypt()
        {
            InitializeComponent();
            instantiations++;
        }

        private void FrmDecrypt_Load(object sender, EventArgs e)
        {

        }

        private void FrmDecrypt_Close(object sender, FormClosedEventArgs e)
        {
            instantiations--;
        }

        private void ImgInput_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG Files|*.png|Bitmap Files|*.bmp|AllFiles|*.*";
            openFileDialog1.Title = "Select Image to Decrypt";
            openFileDialog1.ShowDialog();

            //Check to see if a filename was given
            if (openFileDialog1.FileName != "")
            {
                //Scale image for display
                imgInput.SizeMode = PictureBoxSizeMode.StretchImage;
                inputImage = new Bitmap(openFileDialog1.FileName);
                imgInput.ClientSize = new Size(imgInput.Width, imgInput.Height);
                imgInput.Image = inputImage;
            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int offset = 8 - (int)bitKey.Value; 
            int outputBits = 0xFF >> offset;    //decrypt mask

            outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            for(int i = 0; i< inputImage.Width; i++)
            {
                for(int j = 0; j < inputImage.Height; j++)
                {
                    var pixel = inputImage.GetPixel(i, j);
                    //pixel color masks
                    var decMR = pixel.R & outputBits;
                    var decMG = pixel.G & outputBits;
                    var decMB = pixel.B & outputBits;

                    //bit shift LSB to MSB for output
                    var stegR = decMR << offset;
                    var stegG = decMG << offset;
                    var stegB = decMB << offset;

                    //Set pixels for image output
                    var newPixel = Color.FromArgb(stegR, stegG, stegB);
                    outputImage.SetPixel(i, j, newPixel);
                }
            }

            //scale output for display
            imgOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgOutput.ClientSize = new Size(imgOutput.Width, imgOutput.Height);
            imgOutput.Image = outputImage;


        }

        private void SaveDecryptedImgAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Files|*.png|Bitmap Files| *.bmp";
            saveFileDialog1.Title = "Save Decrypted Image";
            saveFileDialog1.ShowDialog();

            //check for filename
            if (saveFileDialog1.FileName != "")
            {
                //convert image to save
                ImageConverter conv = new ImageConverter();
                byte[] outBytes = (byte[])conv.ConvertTo(imgOutput.Image, typeof(byte[]));
                File.WriteAllBytes(saveFileDialog1.FileName, outBytes);
            }
        }

        private void SaveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
