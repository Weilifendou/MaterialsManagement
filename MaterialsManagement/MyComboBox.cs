using System;
using System.Drawing;
using System.Windows.Forms;
namespace MaterialsManagement
{
    public sealed class MyComboBox : ComboBox
    {
        private const int WM_PAINT = 0x000F;
        private string hintText = "";
    
        public enum enumInputTypes
        {
            None,
            字母,
            数字
        }
        public string HintText
        {
            get { return hintText; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                hintText = value;
                Invalidate();
            }
        }
        public enumInputTypes inputType;
        public enumInputTypes InputType
        {
            get { return inputType; }
            set
            {
                inputType = value;
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PAINT && !Focused && (hintText.Length > 0))
            {
                TextFormatFlags tff = TextFormatFlags.Left;
                using (Graphics g = CreateGraphics())
                {
                    Rectangle rect = ClientRectangle;
                    rect.Offset(1, 1);
                    TextRenderer.DrawText(g, hintText, Font, rect, Color.LightGray, tff);
                }
            }
            base.WndProc(ref m);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (inputType.ToString() == "数字")
            {
                if (e.KeyChar != 8 && !Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (inputType.ToString() == "字母")
            {
                if (e.KeyChar != 8 && Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.A)
            {
                SelectAll();
            }
            //if (e.Control && e.KeyCode == Keys.X)
            //{
            //    Cut();
            //}
            //if (e.Control && e.KeyCode == Keys.C)
            //{
            //    Copy();
            //}
            //if (e.Control && e.KeyCode == Keys.V)
            //{
            //    Paste();
            //}
        }
    }
}
