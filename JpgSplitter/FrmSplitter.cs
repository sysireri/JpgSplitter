using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            try
            {
                if (objImageUtilities.LoadImage(@txtInputJpg.Text, out mImaOriginal))
                {
                    ImaToDisplay = mImaOriginal;

                    mGenerateSplitRectangles(ImaToDisplay);

                    picInput.Image = objImageUtilities.ScaleImage(ImaToDisplay, System.Convert.ToInt32(txtZoom.Text));

                }
                else
                {
                    MessageBox.Show("Image not exists.");
                }

            }
            catch(System.Exception ex)
            {
                ExceptionUtilities.DisplayError(ex);
            }
            finally
            {
                objImageUtilities = null;
            }
        }

        private void FrmSplitter_Load(object sender, EventArgs e)
        {
            try
            {
                mLoadControls();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
        void mLoadControls()
        {
            try
            {
                System.Collections.Generic.Dictionary<int, string> dicSplit = new Dictionary<int, string>
                {
                    { 1, "1 X 1"},
                    { 4, "1 X 2"},
                    { 2, "2 X 1"},
                    { 3, "2 X 2"}
                };

                cboSplit.DataSource = new BindingSource(dicSplit,"");
                cboSplit.DisplayMember = "Value";
                cboSplit.ValueMember = "Key";

                cboSplit.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
            }

        }

        private void mGenerateSplitRectangles(System.Drawing.Image rImaToDisplay)
        {
            ImageUtilities objImageUtilities = new ImageUtilities();
            System.Drawing.Color colLines = System.Drawing.Color.Yellow;
            int intLineWidth = 25;
            int intCenterOfLine = (intLineWidth / 2);
            try
            {
                switch (cboSplit.SelectedValue )
                {
                    case 1: // 1 X 1
                        DrawRectangleAroundImage();
                        break;

                    case 2: // 2 X 1
                        DrawRectangleAroundImage();

                        objImageUtilities.DrawLine(rImaToDisplay,
                                                   colLines,
                                                   intLineWidth,
                                                   new System.Drawing.Point(rImaToDisplay.Width / 2, 0),  // Top Center
                                                   new System.Drawing.Point(rImaToDisplay.Width / 2, rImaToDisplay.Height));  // Bottom Center

                        break;

                    case 3: // 2 X 2
                        DrawRectangleAroundImage();

                        objImageUtilities.DrawLine(rImaToDisplay,
                                                   colLines,
                                                   intLineWidth,
                                                   new System.Drawing.Point(rImaToDisplay.Width / 2, 0),  // Top Center
                                                   new System.Drawing.Point(rImaToDisplay.Width / 2, rImaToDisplay.Height));  // Bottom Center

                        objImageUtilities.DrawLine(rImaToDisplay,
                                                   colLines,
                                                   intLineWidth,
                                                   new System.Drawing.Point(0, rImaToDisplay.Height / 2),  // Middle Left
                                                   new System.Drawing.Point(rImaToDisplay.Width, rImaToDisplay.Height / 2));  // Middle Right

                        break;

                    case 4: // 1 X 2
                        DrawRectangleAroundImage();

                        objImageUtilities.DrawLine(rImaToDisplay,
                                                   colLines,
                                                   intLineWidth,
                                                   new System.Drawing.Point(0, rImaToDisplay.Height / 2),  // Middle Left
                                                   new System.Drawing.Point(rImaToDisplay.Width, rImaToDisplay.Height / 2));  // Middle Right

                        break;
                }


                void DrawRectangleAroundImage() // 1 X 1
                {
                    objImageUtilities.DrawRectangleWithLines(rImaToDisplay,
                                                             colLines,
                                                             intLineWidth,
                                                             new System.Drawing.Point(0 + intCenterOfLine, 0 + intCenterOfLine),  // Top Left
                                                             new System.Drawing.Point(0 + intCenterOfLine, rImaToDisplay.Height - intCenterOfLine),  // Bottom Left
                                                             new System.Drawing.Point(rImaToDisplay.Width - intCenterOfLine, rImaToDisplay.Height - intCenterOfLine), // Bottom Right
                                                             new System.Drawing.Point(rImaToDisplay.Width - intCenterOfLine, 0 + intCenterOfLine));  // Top Right

                }
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
                objImageUtilities = null;
            }
        }
    }
}
