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
                    objImageUtilities.DrawLine(ImaToDisplay,
                                               colLines,
                                               intLineWidth,
                                               0,
                                               0,
                                               0,
                                               ImaToDisplay.Height);

                    objImageUtilities.DrawLine(ImaToDisplay,
                                               colLines,
                                               intLineWidth,
                                               0,
                                               0,
                                               ImaToDisplay.Width,
                                               0);

                    objImageUtilities.DrawLine(ImaToDisplay,
                                               colLines,
                                               intLineWidth,
                                               ImaToDisplay.Width,
                                               0,
                                               ImaToDisplay.Width,
                                               ImaToDisplay.Height);

                    objImageUtilities.DrawLine(ImaToDisplay,
                                               colLines,
                                               intLineWidth,
                                               0,
                                               ImaToDisplay.Height,
                                               ImaToDisplay.Height,
                                               ImaToDisplay.Height);

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
