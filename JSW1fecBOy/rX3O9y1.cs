using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace JSW1fecBOy
{
	public class rX3O9y1
	{
        public static MemoryStream CaptureScreenShots()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            Size screenSize = new Size(screenBounds.Width, screenBounds.Height);

            Bitmap bitmap = new Bitmap(screenBounds.Width, screenBounds.Height);

            ImageCodecInfo encoder = Ponsp.GetImageEncoder(ImageFormat.Jpeg);
            EncoderParameters encoderParameters = new EncoderParameters(1);
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, 60L);
            encoderParameters.Param[0] = qualityParam;

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(Point.Empty, Point.Empty, screenSize);
            }

            // MemoryStream에 JPEG로 저장
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, encoder, encoderParameters);
            memoryStream.Position = 0;

            return memoryStream;
        }
    }
}
