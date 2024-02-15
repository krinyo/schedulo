using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedulo.Custom
{
    public class MultiLineListBox : ListBox
    {
        public MultiLineListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0 && e.Index < Items.Count)
            {
                string text = Items[e.Index].ToString();
                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
                }
            }
            e.DrawFocusRectangle();
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (e.Index >= 0 && e.Index < Items.Count)
            {
                string text = ((TaskItem)Items[e.Index]).DisplayText;
                SizeF size = e.Graphics.MeasureString(text, this.Font, this.Width);
                e.ItemHeight = (int)size.Height;
                e.ItemWidth = (int)size.Width;
            }
            else
            {
                base.OnMeasureItem(e);
            }
        }


    }

}
