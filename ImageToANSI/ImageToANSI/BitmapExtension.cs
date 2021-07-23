using System.Drawing;

namespace ImageToANSI
{
    static class BitmapExtension
    {
        static Bitmap ResizeToPosition(this Bitmap bitmap, int width, int height, Point position)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
                g.DrawImage(bitmap, position);
            return result;
        }

        public static Bitmap Resize(this Bitmap bitmap, int width, int height)
        {
            return bitmap.ResizeToPosition(width, height, Point.Empty);
        }

        public static Bitmap ResizeToCenter(this Bitmap bitmap, int width, int height)
        {
            return bitmap.ResizeToPosition(width, height, new Point(width / 2 - bitmap.Width / 2, height / 2 - bitmap.Height / 2));
        }
    }
}
