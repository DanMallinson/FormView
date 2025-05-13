using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace FormView_Desktop.Controls
{
    public class ImageViewControl : Control
    {
        private Bitmap
            _image;

        private bool
            _loaded;

        private Point
            _lastPosition;

        public Bitmap Image
        {
            get { return _image; }
            set { _image = value; OnImageChanged(); }
        }

        public float Zoom { get; set; }
        public PointF Scroll {  get; set; }
        public ImageViewControl()
        {
            DoubleBuffered = true;
            Image = null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Image != null)
            {

                e.Graphics.ScaleTransform(Zoom, Zoom);
                e.Graphics.TranslateTransform(Scroll.X, Scroll.Y);
                e.Graphics.DrawImage(Image, 0, 0);
            }
            base.OnPaint(e);
        }

        private void OnImageChanged()
        {
            if(_image == null)
            {
                Zoom = 1;
                return;
            }
            var x = (float)_image.Width / (float)Width;
            var y = (float)_image.Height / (float)Height;

            //Zoom = Math.Min(x, y);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                var x = Scroll.X + (e.Location.X - _lastPosition.X) / Zoom;
                var y = Scroll.Y + (e.Location.Y - _lastPosition.Y) / Zoom;

                Scroll = new PointF(x, y);
                Refresh();
            }

            _lastPosition = e.Location;

        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            if(Control.ModifierKeys == Keys.Control)
            {
                if(e.Delta> 0 && Zoom < 10)
                {
                    Zoom += 0.1f;
                }
                else if (e.Delta < 0 && Zoom > 0.1)
                {
                    Zoom -= 0.1f;
                }
                Refresh();
            }
        }
    }
}
