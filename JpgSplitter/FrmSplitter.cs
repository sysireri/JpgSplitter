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
        public FrmSplitter()
        {
            InitializeComponent();
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            ImageUtilities objImageUtilities = new ImageUtilities();
            System.Drawing.Image ImaInput = null;

            try
            {
                if (objImageUtilities.LoadImage(@txtInputJpg.Text, out ImaInput))
                {
                    picInput.Image = objImageUtilities.ScaleImage(ImaInput, System.Convert.ToInt32(txtZoom.Text));
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
