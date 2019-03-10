using System.Drawing;
using System.Windows.Forms;

namespace TextEditUtils
{
    public class DuplicateText
    {
        public static string RegisterWithName()
        {
            return "Set superior font";
        }

        public static void rDuplicateText(RichTextBox rtb)
        {
            if (rtb.SelectionLength == 0)
            {
                DialogResult dr = MessageBox.Show(
                    "Apply to whole text?",
                    "Warning - no text selected",
                    MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                    rtb.SelectAll();
            }

            Font tmpFont  = new Font("Comic Sans MS", 12, FontStyle.Bold);
            rtb.SelectionFont = tmpFont;
        }
    }
}
