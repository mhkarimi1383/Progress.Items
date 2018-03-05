#region App
#region Usings
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
#endregion

#region NameSpace
namespace ProgressBar
{
    #region Start Class
    public partial class ProgressRing : UserControl
    {
        #region Main Diactory
        public ProgressRing()
        {
            InitializeComponent();
        }
        #endregion
        #region Variables
        protected int value = 0;
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (Value < 0) value = 0;
                else if (Value > 100) value = 100;
                this.value = value;
                Invalidate();
            }
        }

        public Color ProgressColor { get => progressColor; set => progressColor = value; }
        public Color BackgroundColor { get => backgroundColor; set => backgroundColor = value; }
        public Font ValueTextFont { get => valueTextFont; set => valueTextFont = value; }
        public Color ValueTextColor { get => valueTextColor; set => valueTextColor = value; }
        public float TextTransform { get => textTransform; set => textTransform = value; }
        public float ProgressTransform { get => progressTransform; set => progressTransform = value; }

        private Color progressColor = Color.Red;
        private Color backgroundColor = Color.White;
        private Font valueTextFont = new Font("Tohoma", 15);
        private Color valueTextColor = Color.Red;
        private float textTransform = 90;
        private float progressTransform = -90;
        #endregion
        #region a void for paint
        private void ProgressRing_Paint(object sender, PaintEventArgs e)
        {
            #region Create a big circule for showing progress
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(ProgressTransform);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen obj_pen = new Pen(ProgressColor);
            Rectangle rect1 = new Rectangle(new Point(0 - Width / 2 + 20, 0 - Height / 2 + 20), new Size(Width - 40, Height - 40));
            e.Graphics.DrawPie(pen: obj_pen, rect: rect1, startAngle: 0, sweepAngle: Value * 360 / 100);//360/100=3.6
            e.Graphics.FillPie(new SolidBrush(ProgressColor), rect1, 0, (int)(Value * 3.6));
            #endregion
            #region Create a short circule for showing background
            obj_pen = new Pen(BackgroundColor);
            rect1 = new Rectangle(0 - Width / 2 + 30, 0 - Height / 2 + 30, Width - 60, Height - 60);
            e.Graphics.DrawPie(obj_pen, rect1, 0, 360);
            e.Graphics.FillPie(new SolidBrush(BackgroundColor), rect1, 0, 360);
            #endregion
            #region Create Text for showing Value
            e.Graphics.RotateTransform(TextTransform);
            StringFormat ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            e.Graphics.DrawString($"{Value}%", ValueTextFont, new SolidBrush(ValueTextColor), rect1, ft);
            #endregion
            #region checking value for UseWaitCursor
            if (Value < 100)
            {
                UseWaitCursor = true;
            }
            if (Value == 100)
            {
                UseWaitCursor = false;
                e.Dispose();
            }
            #endregion
        }
        #endregion
        #region a void for UpDate
        public void UpDate(int Progress)
        {
            Value += Progress;

            Invalidate();

            if (Value < 0)
            {
                Value = 0;
            }
            else if (Value > 100)
            {
                Value = 100;

            }
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion