using System;

namespace JpgSplitter
{
    class ImageUtilities
    {
        public System.Drawing.Image ScaleImage(System.Drawing.Image ImaInput, int IntMaxWidth, int IntMaxHeight)
        {
            double dblRatioX = 0;
            double dblRatioY = 0;
            double dblRatio = 0;
            int intNewWidth = 0;
            int intNewHeight = 0;

            System.Drawing.Image ImaNewScale = null;

            try
            {
                dblRatioX = (double)IntMaxWidth / (double)ImaInput.Width;
                dblRatioY = (double)IntMaxHeight / (double)ImaInput.Height;
                dblRatio = Math.Min(dblRatioX, dblRatioY);

                intNewWidth = (int)(ImaInput.Width * dblRatio);
                intNewHeight = (int)(ImaInput.Height * dblRatio);

                ImaNewScale = new System.Drawing.Bitmap(intNewWidth, intNewHeight);

                using (System.Drawing.Graphics objGraphics = System.Drawing.Graphics.FromImage(ImaNewScale))
                {
                    objGraphics.DrawImage(ImaInput, 0, 0, intNewWidth, intNewHeight);
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

        public System.Drawing.Image ScaleImage(System.Drawing.Image ImaInput, int IntZoom)
        {
            System.Drawing.Image ImaNewScale = null;

            try
            {
                if (ImaInput != null)
                {
                    ImaNewScale = ScaleImage(ImaInput, ImaInput.Width * IntZoom / 100, ImaInput.Height * IntZoom / 100);
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
        public bool LoadImage(string vstrImageToLoad, out System.Drawing.Image rImaLoaded)
        {
            bool bolLoadSuccess = false;
            rImaLoaded = null;
            try
            {
                if (System.IO.File.Exists(vstrImageToLoad))
                {
                    using (System.IO.FileStream objFileInputJpg = System.IO.File.OpenRead(vstrImageToLoad))
                    {
                        rImaLoaded = System.Drawing.Image.FromStream(objFileInputJpg);
                    }
                    bolLoadSuccess = true;
                }
                else
                {
                    rImaLoaded = null;
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

        public void DrawLine(System.Drawing.Image rImaToDraw,
                             System.Drawing.Color vcoldesiredColor,
                             int vintWidth,
                             System.Drawing.Point vpoit1,
                             System.Drawing.Point vpoit2)
        {
            try
            {
                using (System.Drawing.Graphics objGraphics = System.Drawing.Graphics.FromImage(rImaToDraw))
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
        public void DrawRectangleWithLines(System.Drawing.Image rImaToDraw,
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

                using (System.Drawing.Graphics objGraphics = System.Drawing.Graphics.FromImage(rImaToDraw))
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
    }
}
