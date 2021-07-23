using System.Drawing;

namespace ImageToANSI
{
    class ANSI
    {
        public static readonly char ESC = '';
        public static readonly char FULL = 'Ű';
        public static readonly char TOP = 'ß';
        public static readonly char BOTTOM = 'Ü';
        public static readonly char EMPTY = ' ';
        public static string NewLine(int line) => ESC + "[" + line + ";1H";
        public static string Reset => ESC + "[0m";

        public char Character { get; private set; }
        public Color8 Foreground { get; private set; }
        public Color8 Background { get; private set; }

        public Color Top => Character == TOP ? Foreground.Color : (Background?.ColorDark ?? Foreground.Color);
        public Color Bottom => Character == BOTTOM ? Foreground.Color : (Background?.ColorDark ?? Foreground.Color);

        public ANSI(char character, Color8 foreground, Color8 background)
        {
            Character = character;
            Foreground = foreground;
            Background = background;
        }

        public override string ToString()
        {
            if (Foreground == null) return Reset + Character;
            return ESC + "[" + (Foreground.Bright ? 1 : 0) + ";3" + Foreground.ID + (Background == null ? "" : (";4" + Background.ID)) + "m" + Character;
        }
    }
}
