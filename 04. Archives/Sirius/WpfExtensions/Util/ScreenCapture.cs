using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WpfExtensions.Util
{
    public class ScreenCapture
    {
        public Stream GetScreenShot()
        {
            using (Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                                        Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                     Screen.PrimaryScreen.Bounds.Y,
                                     0, 0,
                                     bitmap.Size,
                                     CopyPixelOperation.SourceCopy);
                }
                var stream = new MemoryStream();
                bitmap.Save(stream, ImageFormat.Jpeg);
                stream.Position = 0;
                return stream;
            }
        }
    }
}
