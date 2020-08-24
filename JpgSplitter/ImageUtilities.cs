using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace JpgSplitter
{
    class ImageUtilities
    {
        public System.Drawing.Bitmap ScaleBitmap(System.Drawing.Bitmap  BmpInput, int IntMaxWidth, int IntMaxHeight)
        {
            double dblRatioX = 0;
            double dblRatioY = 0;
            double dblRatio = 0;
            int intNewWidth = 0;
            int intNewHeight = 0;

            System.Drawing.Bitmap ImaNewScale = null;

            try
            {
                dblRatioX = (double)IntMaxWidth / (double)BmpInput.Width;
                dblRatioY = (double)IntMaxHeight / (double)BmpInput.Height;
                dblRatio = Math.Min(dblRatioX, dblRatioY);

                intNewWidth = (int)(BmpInput.Width * dblRatio);
                intNewHeight = (int)(BmpInput.Height * dblRatio);

                ImaNewScale = new System.Drawing.Bitmap(intNewWidth, intNewHeight);

                using (System.Drawing.Graphics objGraphics = System.Drawing.Graphics.FromImage(ImaNewScale))
                {
                    objGraphics.DrawImage(BmpInput, 0, 0, intNewWidth, intNewHeight);
                }
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
            }

            return ImaNewScale;
        }

        public System.Drawing.Bitmap ScaleBitmap(System.Drawing.Bitmap BmpInput, int IntZoom)
        {
            System.Drawing.Bitmap ImaNewScale = null;

            try
            {
                if (BmpInput != null)
                {
                    ImaNewScale = ScaleBitmap(BmpInput, BmpInput.Width * IntZoom / 100, BmpInput.Height * IntZoom / 100);
                }
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
            }

            return ImaNewScale;
        }
        public bool LoadBitmap(string vstrImageToLoad, out System.Drawing.Bitmap rBmpLoaded)
        {
            bool bolLoadSuccess = false;
            rBmpLoaded = null;
            try
            {
                if (System.IO.File.Exists(vstrImageToLoad))
                {
                    using (System.IO.FileStream objFileInputJpg = System.IO.File.OpenRead(vstrImageToLoad))
                    {
                        rBmpLoaded = new System.Drawing.Bitmap(objFileInputJpg);
                    }
                    bolLoadSuccess = true;
                }
                else
                {
                    rBmpLoaded = null;
                    bolLoadSuccess = false;
                }

            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
            }
            return bolLoadSuccess;
        }

        public void DrawLine(System.Drawing.Bitmap rBmpToDraw,
                             System.Drawing.Color vcoldesiredColor,
                             int vintWidth,
                             System.Drawing.Point vpoit1,
                             System.Drawing.Point vpoit2)
        {
            try
            {
                using (System.Drawing.Graphics objGraphics = System.Drawing.Graphics.FromImage(rBmpToDraw))
                {
                    using (System.Drawing.Pen objPen = new System.Drawing.Pen(vcoldesiredColor, vintWidth))
                    {
                        objGraphics.DrawLine(objPen, vpoit1, vpoit2);
                    }
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
        public void DrawRectangleWithLines(System.Drawing.Bitmap rBmpToDraw,
                                           System.Drawing.Color vcoldesiredColor,
                                           int vintWidth,
                                           System.Drawing.Point vpoitTopLeft,
                                           System.Drawing.Point vpoitBottomLeft,
                                           System.Drawing.Point vpoitBottomRight,
                                           System.Drawing.Point vpoitTopRight)
        {
            try
            {
                System.Drawing.Point[] objpoints =
                {
               vpoitTopLeft,
               vpoitBottomLeft,

               vpoitTopLeft,
               vpoitTopRight,

               vpoitTopRight,
               vpoitBottomRight,

               vpoitBottomLeft,
               vpoitBottomRight
            };

                using (System.Drawing.Graphics objGraphics = System.Drawing.Graphics.FromImage(rBmpToDraw))
                {
                    using (System.Drawing.Pen objPen = new System.Drawing.Pen(vcoldesiredColor, vintWidth))
                    {
                        objGraphics.DrawLines(objPen, objpoints);
                    }
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

        public System.Drawing.Bitmap CopyPartOfBitmap(System.Drawing.Bitmap vBmpToClone,
                                                      System.Drawing.Rectangle vRecSource,
                                                      System.Drawing.Rectangle vRecDestination)
        {
            System.Drawing.Bitmap BmpCloned = null;
            try
            {
                BmpCloned = new System.Drawing.Bitmap(vRecDestination.Width , vRecDestination.Height, vBmpToClone.PixelFormat);
                BmpCloned.SetResolution(vBmpToClone.HorizontalResolution, vBmpToClone.VerticalResolution);

                using (System.Drawing.Graphics ObjGraphic = System.Drawing.Graphics.FromImage(BmpCloned))
                {
                    ObjGraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    ObjGraphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    ObjGraphic.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                    ObjGraphic.DrawImage(vBmpToClone,
                                         vRecDestination,
                                         vRecSource,
                                         System.Drawing.GraphicsUnit.Pixel);
                }
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
            }

            return BmpCloned;
        }

        public bool SaveBitmap(System.Drawing.Bitmap vBmpToSave,
                               string vstrFileName,
                               bool vbolFileCanBeOverWrite,
                               System.Drawing.Imaging.ImageFormat vImaFormat)
        {
            bool bolSuccess = true;
            
            try
            {
                if(! vbolFileCanBeOverWrite && System.IO.File.Exists(vstrFileName))
                {
                    bolSuccess = false;
                }
                else
                {
                    vBmpToSave.Save(vstrFileName, vImaFormat);
                }
            }
            catch (System.Exception ex)
            {
                bolSuccess = false;
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
            }

            return bolSuccess;

        }
        public string GetBitmapInformation(System.Drawing.Bitmap vBmpToDescribe)
        {
            System.Text.StringBuilder objStringBuilder = new System.Text.StringBuilder();
            string strBitMapInfos = "";
            try
            {
                if(vBmpToDescribe != null)
                {
                    objStringBuilder.Append("Width : " + vBmpToDescribe.Width + " X ");
                    objStringBuilder.Append("Height : " + vBmpToDescribe.Height + " ");
                    objStringBuilder.Append("H-Res. : " + vBmpToDescribe.HorizontalResolution + " ");
                    objStringBuilder.Append("V-Res. : " + vBmpToDescribe.VerticalResolution + " ");
                    objStringBuilder.Append(vBmpToDescribe.PixelFormat.ToString());

                    strBitMapInfos = objStringBuilder.ToString();
                }
            }
            catch (System.Exception ex)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
            }
            finally
            {
                objStringBuilder.Clear();
                objStringBuilder = null;
            }

            return strBitMapInfos;
        }

    }
}
