using System.Windows.Forms;

namespace TextEditUtils
{
    public class ShowStats
    {
        public static string RegisterWithName()
        {
            return "Show file stats";
        }

        public static void sDisplayStats(string Contents)
        {
            int NumChars = Contents.Length;
            int NumLines = Contents.Split('\n').Length;

            MessageBox.Show(string.Format("{0} characters\n{1} lines", NumChars, NumLines));
        }
    }
}
