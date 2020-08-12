using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpgSplitter
{
    public partial class FrmSplitter : Form
    {
        System.Drawing.Image mImaOriginal = null;

        public FrmSplitter()
        {
            InitializeComponent();
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            ImageUtilities objImageUtilities = new ImageUtilities();
            System.Drawing.Image ImaToDisplay = null;
            System.Drawing.Color colLines = System.Drawing.Color.Yellow;
            int intLineWidth = 50;

            try
            {
                if (objImageUtilities.LoadImage(@txtInputJpg.Text, out mImaOriginal))
                {
                    ImaToDisplay = mImaOriginal;

                    objImageUtilities.DrawRectangleWithLines(ImaToDisplay,
                                                             colLines,
                                                             intLineWidth,
                                                             new System.Drawing.Point(0, 0),  // Top Left
                                                             new System.Drawing.Point(0, ImaToDisplay.Height),  // Bottom Left
                                                             new System.Drawing.Point(ImaToDisplay.Width, ImaToDisplay.Height), // Bottom Right
                                                             new System.Drawing.Point(ImaToDisplay.Width, 0));  // Top Right


                    picInput.Image = objImageUtilities.ScaleImage(ImaToDisplay, System.Convert.ToInt32(txtZoom.Text));

                }
                else
                {
                    MessageBox.Show("Image not exists.");
                }

            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objImageUtilities = null;
            }


        }
    }
}
