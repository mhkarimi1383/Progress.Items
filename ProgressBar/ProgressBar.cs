#region App
#region Usings
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
#endregion

#region NameSpace
namespace ProgressBar
{
    #region Start Class
    public partial class ProgressBar : UserControl
    {
        #region Main Diactory
        public ProgressBar()
        {
            InitializeComponent();
        }
        #endregion
        #region Variables
        private Color progressColor = Color.Red;
        private Color backgroundColor = Color.White;
        private Font valueTextFont = new Font("Tohoma", 10);
        private Color valueTextColor = Color.Red;
        private int maximum = 100;
        private float percent = 0.0f;
        public float Value
        {
            get
            {
                return Percent;
            }
            set
            {
                if (Value < 0) value = 0;
                else if (Value > Maximum) value = Maximum;
                Percent = value;
                Invalidate();
            }
        }

        public Color ProgressColor { get => progressColor; set => progressColor = value; }
        public Color BackgroundColor { get => backgroundColor; set => backgroundColor = value; }
        public Font ValueTextFont { get => valueTextFont; set => valueTextFont = value; }
        public Color ValueTextColor { get => valueTextColor; set => valueTextColor = value; }
        public int Maximum { get => maximum; set => maximum = value; }
        protected float Percent { get => percent; set => percent = value; }
        #endregion
        #region a void for paint
        private void ProgressBar_Paint(object sender, PaintEventArgs e)
        {
            BackColor = BackgroundColor;
            #region Fill this
            Brush b = new SolidBrush(ForeColor);
            LinearGradientBrush lb = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(255, ProgressColor), Color.FromArgb(50, BackgroundColor), LinearGradientMode.ForwardDiagonal);
            int width = (int)((Percent / Maximum) * Width);
            e.Graphics.FillRectangle(b, 0, 0, width, Height);
            e.Graphics.FillRectangle(lb, 0, 0, width, Height);
            #endregion
            #region Dinposing brashes
            b.Dispose();
            lb.Dispose();
            #endregion
            #region Creating Text for showing value
            StringFormat ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            if (Maximum == 100)
            {
                e.Graphics.DrawString($"{Value}%", ValueTextFont, new SolidBrush(ValueTextColor), new Point(69, 10), ft);
            }
            else
            {
                e.Graphics.DrawString($"{Value}/{Maximum}", ValueTextFont, new SolidBrush(ValueTextColor), new Point(69, 10), ft);
            }
            #endregion
            #region checking value for UseWaitCursor
            if (Value < Maximum)
            {
                UseWaitCursor = true;
            }
            if (Value == Maximum)
            {
                UseWaitCursor = false;
            }
            #endregion
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion