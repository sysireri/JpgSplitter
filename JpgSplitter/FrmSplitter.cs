﻿using System;
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
        System.Drawing.Bitmap mBmpOriginal = null;

        ImageUtilities mobjImageUtilities = new ImageUtilities();


        #region "Interactive functions"
        public FrmSplitter()
        {
            InitializeComponent();
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (! mLoadOriginalBitmapAndTraceLines())
                {
                    MessageBox.Show("Image not exists.");
                }

            }
            catch (System.Exception ex)
            {
                ExceptionUtilities.DisplayError(ex);
            }
            finally
            {
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
                ExceptionUtilities.DisplayError(ex);
            }
            finally
            {
            }
        }

        private void ButSplitt_Click(object sender, EventArgs e)
        {
            try
            {
                txtNextId.Text = mFormatNextId(mSplitBitMap());
            }
            catch (System.Exception ex)
            {
                ExceptionUtilities.DisplayError(ex);
            }
            finally
            {
            }

        }

        private void butBrowseOutputDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                FolOutput.ShowNewFolderButton = true;
                FolOutput.ShowDialog();
                txtOutPutDirectory.Text = FolOutput.SelectedPath;
            }
            catch (System.Exception ex)
            {
                ExceptionUtilities.DisplayError(ex);
            }
            finally
            {
            }
        }

        #endregion

        #region "Customs Functions"
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

                cboSplit.DataSource = new BindingSource(dicSplit, "");
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

        private void mGenerateSplitRectangles(System.Drawing.Bitmap rBmpToDisplay)
        {
            System.Drawing.Color colLines = System.Drawing.Color.Yellow;
            int intLineWidth = 25;
            int intCenterOfLine = (intLineWidth / 2);
            try
            {
                switch (cboSplit.SelectedValue)
                {
                    case 1: // 1 X 1
                        DrawRectangleAroundImage();
                        break;

                    case 2: // 2 X 1
                        DrawRectangleAroundImage();

                        mobjImageUtilities.DrawLine(rBmpToDisplay,
                                                   colLines,
                                                   intLineWidth,
                                                   new System.Drawing.Point(rBmpToDisplay.Width / 2, 0),  // Top Center
                                                   new System.Drawing.Point(rBmpToDisplay.Width / 2, rBmpToDisplay.Height));  // Bottom Center

                        break;

                    case 3: // 2 X 2
                        DrawRectangleAroundImage();

                        mobjImageUtilities.DrawLine(rBmpToDisplay,
                                                   colLines,
                                                   intLineWidth,
                                                   new System.Drawing.Point(rBmpToDisplay.Width / 2, 0),  // Top Center
                                                   new System.Drawing.Point(rBmpToDisplay.Width / 2, rBmpToDisplay.Height));  // Bottom Center

                        mobjImageUtilities.DrawLine(rBmpToDisplay,
                                                   colLines,
                                                   intLineWidth,
                                                   new System.Drawing.Point(0, rBmpToDisplay.Height / 2),  // Middle Left
                                                   new System.Drawing.Point(rBmpToDisplay.Width, rBmpToDisplay.Height / 2));  // Middle Right

                        break;

                    case 4: // 1 X 2
                        DrawRectangleAroundImage();

                        mobjImageUtilities.DrawLine(rBmpToDisplay,
                                                   colLines,
                                                   intLineWidth,
                                                   new System.Drawing.Point(0, rBmpToDisplay.Height / 2),  // Middle Left
                                                   new System.Drawing.Point(rBmpToDisplay.Width, rBmpToDisplay.Height / 2));  // Middle Right

                        break;
                }


                void DrawRectangleAroundImage() // 1 X 1
                {
                    mobjImageUtilities.DrawRectangleWithLines(rBmpToDisplay,
                                                             colLines,
                                                             intLineWidth,
                                                             new System.Drawing.Point(0 + intCenterOfLine, 0 + intCenterOfLine),  // Top Left
                                                             new System.Drawing.Point(0 + intCenterOfLine, rBmpToDisplay.Height - intCenterOfLine),  // Bottom Left
                                                             new System.Drawing.Point(rBmpToDisplay.Width - intCenterOfLine, rBmpToDisplay.Height - intCenterOfLine), // Bottom Right
                                                             new System.Drawing.Point(rBmpToDisplay.Width - intCenterOfLine, 0 + intCenterOfLine));  // Top Right

                }
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
            }
        }

        private int mSplitBitMap()
        {
            string strDirectiory = "";
            int intNextId = 0;
            string strExtension = ".JPG";

            System.Drawing.Bitmap BmpToSave = null;

            System.Drawing.Rectangle recSource;
            System.Drawing.Rectangle recDestination;

            try
            {
                strDirectiory = @txtOutPutDirectory.Text + @"\";
                intNextId = Convert.ToInt32(txtNextId.Text);

                if (mBmpOriginal == null)
                {
                    return intNextId;
                }

                if (!System.IO.Directory.Exists(strDirectiory))
                {
                    System.IO.Directory.CreateDirectory(strDirectiory);
                }

                switch (cboSplit.SelectedValue)
                {
                    case 1: // 1 X 1
                        recDestination = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width, mBmpOriginal.Height); // All bitMap

                        recSource = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width, mBmpOriginal.Height); // All bitMap
                        mGenerateBitmapAndSaveIt();

                        break;

                    case 2: // 2 X 1
                        recDestination = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width / 2, mBmpOriginal.Height);

                        recSource = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width / 2, mBmpOriginal.Height);
                        mGenerateBitmapAndSaveIt();

                        recSource = new System.Drawing.Rectangle((mBmpOriginal.Width / 2) + 1, 0, mBmpOriginal.Width / 2, mBmpOriginal.Height);
                        mGenerateBitmapAndSaveIt();

                        break;

                    case 3: // 2 X 2
                        recDestination = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width / 2, mBmpOriginal.Height / 2);

                        recSource = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width / 2, mBmpOriginal.Height / 2);
                        mGenerateBitmapAndSaveIt();

                        recSource = new System.Drawing.Rectangle((mBmpOriginal.Width / 2) + 1, 0, mBmpOriginal.Width / 2, mBmpOriginal.Height / 2);
                        mGenerateBitmapAndSaveIt();

                        recSource = new System.Drawing.Rectangle(0, (mBmpOriginal.Height / 2) + 1, mBmpOriginal.Width / 2, mBmpOriginal.Height / 2);
                        mGenerateBitmapAndSaveIt();

                        recSource = new System.Drawing.Rectangle((mBmpOriginal.Width / 2) + 1, (mBmpOriginal.Height / 2) + 1, mBmpOriginal.Width / 2, mBmpOriginal.Height / 2);
                        mGenerateBitmapAndSaveIt();

                        break;

                    case 4: // 1 X 2
                        recDestination = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width, mBmpOriginal.Height / 2);

                        recSource = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width, mBmpOriginal.Height / 2);
                        mGenerateBitmapAndSaveIt();

                        recSource = new System.Drawing.Rectangle(0, (mBmpOriginal.Height / 2) + 1, mBmpOriginal.Width, mBmpOriginal.Height / 2);
                        mGenerateBitmapAndSaveIt();

                        break;
                }

                void mGenerateBitmapAndSaveIt()
                {
                    try
                    {
                        BmpToSave = mobjImageUtilities.CopyPartOfBitmap(mBmpOriginal, recSource, recDestination);
                        if (!mobjImageUtilities.SaveBitmap(BmpToSave, mGetFullPath(strDirectiory, intNextId, strExtension), chkOverwrite.Checked, ImageFormat.Jpeg))
                        {
                            MessageBox.Show("File : " + Environment.NewLine + Environment.NewLine + Environment.NewLine + mGetFullPath(strDirectiory, intNextId, strExtension) + Environment.NewLine + Environment.NewLine + Environment.NewLine + " Already exists and cannot be overwrite.", "Warning", MessageBoxButtons.OK);
                        }
                        intNextId += 1;
                    }
                    catch (System.Exception ex)
                    {
                        System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
                    }

                }
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
                if (BmpToSave != null)
                {
                    BmpToSave.Dispose();
                }
            }

            return intNextId;
        }

        private string mGetFullPath(string vstrDirectiory,
                                    int vintNextId,
                                    string vstrExtension)
        {
            string strFileFullPath = "";
            try
            {
                strFileFullPath = @vstrDirectiory + mFormatNextId(vintNextId) + vstrExtension;
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
            }

            return strFileFullPath;
        }
        private string mFormatNextId(int vintNextId) => vintNextId.ToString("0000");

        private bool mLoadOriginalBitmapAndTraceLines()
        {
            System.Drawing.Bitmap BmpToDisplay = null;
            System.Drawing.Rectangle recOriginal;
            System.Drawing.Rectangle recToDisplay;

            bool bolBitMapLoaded = false;
            try
            {
                bolBitMapLoaded = mobjImageUtilities.LoadBitmap(@txtInputJpg.Text, out mBmpOriginal);
                if(bolBitMapLoaded)
                {
                    LblInputImageInfo.Text = mobjImageUtilities.GetBitmapInformation(mBmpOriginal);

                    recOriginal = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width, mBmpOriginal.Height);
                    recToDisplay = new System.Drawing.Rectangle(0, 0, mBmpOriginal.Width, mBmpOriginal.Height);

                    BmpToDisplay = mobjImageUtilities.CopyPartOfBitmap(mBmpOriginal, recOriginal, recToDisplay);

                    mGenerateSplitRectangles(BmpToDisplay);

                    picInput.Image = mobjImageUtilities.ScaleBitmap(BmpToDisplay, System.Convert.ToInt32(txtZoom.Text));

                }
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
                if(BmpToDisplay != null)
                {
                    BmpToDisplay.Dispose();
                    BmpToDisplay = null;
                }
            }

            return bolBitMapLoaded;
        }

        #endregion

    }
}
