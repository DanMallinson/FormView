using FormViewLibraries.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormView_Desktop.Controls
{
    public class SummaryViewControl : Panel
    {
        public delegate void FormClickedHandler(object sender, FormClickedArgs args);

        public event FormClickedHandler OnFormClicked;
        public int FormWidth { get; set; }
        public float SizeRatio { get; set; }
        public List<FormViewLibraries.Forms.Form> Forms { get; set; }

        public SummaryViewControl()
        {
            Forms = new ();
            AutoScroll = true;
            BackColor = SystemColors.ControlDark;
        }

        public override void Refresh()
        {
            base.Refresh();
            Reconstruct();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Reconstruct();
        }

        private void Reconstruct()
        {
            Controls.Clear();
            var numForms = Forms.Count;
            var numColumns = Width / FormWidth;

            var contentTable = new TableLayoutPanel();

            var numRows = numForms / numColumns;
            if(numRows * numColumns < numForms)
            {
                ++numRows;
            }

            contentTable.ColumnCount = numColumns;
            contentTable.AutoSize = true;
            //contentTable.RowCount = numRows;
            contentTable.Dock = DockStyle.Top;
            Controls.Add(contentTable);

            for(var i = 0; i< numRows; ++i)
            { 
                contentTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            for (var i = 0; i < numForms; ++i)
            {
                Control panel = null;
                if (Forms[i] is ImageForm imageForm)
                {
                    var pictureBox = new PictureBox();
                    pictureBox.Image = imageForm.Image;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    panel = pictureBox;
                }
                else if (Forms[i] is PdfForm)
                {
                    var label = new Label();
                    label.Text = "PDF";
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    panel = label;
                }
                else
                {
                    throw new NotImplementedException();
                }
                panel.BackColor = SystemColors.Control;
                panel.Tag = i;
                panel.Click += Panel_Click;
                panel.Width = FormWidth;
                panel.Height = (int)(FormWidth * SizeRatio);
                panel.Cursor = Cursors.Hand;
                contentTable.Controls.Add(panel);
            }
        }

        private void Panel_Click(object? sender, EventArgs e)
        {
            if(OnFormClicked != null)
            {
                var control = sender as Control;
                if(control == null || control.Tag is not int)
                {
                    throw new InvalidOperationException();
                }

                OnFormClicked.Invoke(this, new FormClickedArgs() { Index = (int)control.Tag });
            }
        }
    }

    public class FormClickedArgs : EventArgs
    {
        public int Index { get; set; }
    }
}
