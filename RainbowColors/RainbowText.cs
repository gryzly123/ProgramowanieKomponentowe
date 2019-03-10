using System.Drawing;
using System.Windows.Forms;

namespace RainbowColors
{
    public class RainbowText
    {
        public static string RegisterWithName()
        {
            return "Make it rain(bow)";
        }

        public static void rRainbow(RichTextBox rtb)
        {
            Color[] colors =
            {
                Color.Red,
                Color.Orange,
                Color.Yellow,
                Color.Green,
                Color.Blue,
                Color.Pink,
                Color.Violet
            };

            int NumChars = rtb.SelectedText.Length;
            int NumCols = colors.Length;

            for(int i = 0; i < NumChars; ++i)
            {
                rtb.Select(i, 1);
                rtb.SelectionColor = colors[i % NumCols];
            }
        }
    }
}
