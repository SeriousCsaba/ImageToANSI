using System;
using System.Drawing;

namespace ImageToANSI
{
    class Color8
    {
        static readonly Color[] colors = new Color[16] { Color.FromArgb(0, 0, 0), Color.FromArgb(170, 0, 0), Color.FromArgb(0, 170, 0), Color.FromArgb(170, 85, 0), Color.FromArgb(0, 0, 170), Color.FromArgb(170, 0, 170), Color.FromArgb(0, 170, 170), Color.FromArgb(170, 170, 170), Color.FromArgb(85, 85, 85), Color.FromArgb(255, 85, 85), Color.FromArgb(85, 255, 85), Color.FromArgb(255, 255, 85), Color.FromArgb(85, 85, 255), Color.FromArgb(255, 85, 255), Color.FromArgb(85, 255, 255), Color.FromArgb(255, 255, 255) };
        public byte ID { get; private set; }
        public bool Bright { get; private set; }
        public float Intensity { get; private set; }

        public Color Color => colors[ID + (Bright ? 8 : 0)];
        public Color ColorDark => colors[ID];

        public Color8(Color color, bool limited)
        {
            ID = 0;
            double currentDifference = 123456;
            for (byte i = 0; i < (limited ? 8 : 16); i++)
            {
                double difference = ColorDifference(color, colors[i]);
                if (difference < currentDifference)
                {
                    ID = i;
                    currentDifference = difference;
                }
            }
            if (ID > 7)
            {
                ID -= 8;
                Bright = true;
            }
            Intensity = (float)Math.Round(0.21 * color.R + 0.72 * color.G + 0.07 * color.B) / 255f;
        }

        virtual protected double ColorDifference(Color color1, Color color2)
        {
            return Math.Sqrt(Math.Pow(color2.R - color1.R, 2) + Math.Pow(color2.G - color1.G, 2) + Math.Pow(color2.B - color1.B, 2));
        }

        public bool Equals(Color8 obj)
        {
            return ID == obj.ID && Bright == obj.Bright;
        }
    }

    class Color8Balanced : Color8
    {
        public Color8Balanced(Color color, bool limited) : base(color, limited) { }

        override protected double ColorDifference(Color color1, Color color2)
        {
            return Math.Sqrt(Math.Pow((color2.R - color1.R) * 0.3, 2) + Math.Pow((color2.G - color1.G) * 0.59, 2) + Math.Pow((color2.B - color1.B) * 0.11, 2));
        }
    }

    class Color8HSB : Color8
    {
        public Color8HSB(Color color, bool limited) : base(color, limited) { }

        override protected double ColorDifference(Color color1, Color color2)
        {
            return Math.Sqrt(Math.Pow(color2.GetHue() - color1.GetHue(), 2) + Math.Pow(color2.GetSaturation() - color1.GetSaturation(), 2) + Math.Pow(color2.GetBrightness() - color1.GetBrightness(), 2));
        }
    }

    class Color8HSV : Color8
    {
        public Color8HSV(Color color, bool limited) : base(color, limited) { }

        public void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        override protected double ColorDifference(Color color1, Color color2)
        {
            double hue1, sat1, val1;
            ColorToHSV(color1, out hue1, out sat1, out val1);
            double hue2, sat2, val2;
            ColorToHSV(color2, out hue2, out sat2, out val2);
            return Math.Sqrt(Math.Pow(hue2 - hue1, 2) + Math.Pow(sat2 - sat1, 2) + Math.Pow(val2 - val1, 2));
        }
    }

}
