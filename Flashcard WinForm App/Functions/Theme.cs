using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    public static class Theme
    {
        public static Color BackgroundColor = ColorTranslator.FromHtml(Properties.Resources.bgColor);
        public static Color ButtonBgColor = ColorTranslator.FromHtml(Properties.Resources.buttonBg);
        public static Color CardFront = ColorTranslator.FromHtml(Properties.Resources.cardFront);
        public static Color CardBack = ColorTranslator.FromHtml(Properties.Resources.cardBack);
        public static Color TextBoxBg = ColorTranslator.FromHtml(Properties.Resources.textboxBg);
        public static Color TextColor = Color.White;

        //Theme.ApplyTheme(this);

        public static void ApplyTheme(Control parent)
        {
            parent.BackColor = BackgroundColor;
            parent.ForeColor = TextColor;

            foreach (Control c in parent.Controls)
            {
                // Update specific controls
                if (c is Button btn)
                {
                    btn.BackColor = ButtonBgColor;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                }

                if (c is Label lbl)
                {
                    lbl.ForeColor = TextColor;
                }

                if (c is TextBox txt)
                {
                    txt.BackColor = TextBoxBg;
                    txt.ForeColor = Color.Black;
                }

                if (c is ComboBox box)
                {
                    box.BackColor = TextBoxBg;
                    box.ForeColor = ButtonBgColor;
                }

                // If the control has children (like a Panel or UserControl), recurse
                if (c.HasChildren)
                {
                    ApplyTheme(c);
                }
            }
        }
    }
}
