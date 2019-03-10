using System.Drawing;
using System.Windows.Forms;

namespace RainbowColors
{
    public class ColorInverter
    {
        public static string RegisterWithName()
        {
            return "Invert colors";
        }

        public static void rInvertColors(RichTextBox rtb)
        {
            int NumChars = rtb.SelectedText.Length;

            for (int i = 0; i < NumChars; ++i)
            {
                rtb.Select(i, 1);
                Color Col = rtb.SelectionColor;
                Color NewCol = Color.FromArgb(255 - Col.R, 255 - Col.G, 255 - Col.B);
                rtb.SelectionColor = NewCol;
            }
            rtb.Select(NumChars, 0);
        }
    }
}
