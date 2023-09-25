using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace MaterialsManagement
{
    public partial class ProgressForm : Form
    {
        private delegate void RenewInterfaceHandler();
        private Graphics graphic;
        private Bitmap bmp;
        private int progress;
        public ProgressForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            //ProgressParameter gp = new ProgressParameter(this, 0);
            //path.AddArc(gp.eaX, gp.eaY, gp.diameter, gp.diameter, -90, 180);
            //path.AddLine(gp.elX, gp.blY, gp.slX, gp.blY);
            //path.AddArc(gp.saX, gp.saY, gp.diameter, gp.diameter, 90, 180);
            //path.AddLine(gp.slX, gp.tlY, gp.elX, gp.tlY);
            path.AddEllipse(DisplayRectangle);
            Region = new System.Drawing.Region(path);
            drawProgress(e.Graphics);
        }

        private void drawProgress(Graphics g)
        {
            bmp = new Bitmap(Width, Height);
            graphic = Graphics.FromImage(bmp);
            int w = bmp.Width;
            int h = bmp.Height;
            graphic.FillRectangle(Brushes.Transparent, 0, 0, w, h);
            //graphic.DrawLine(Pens.DeepSkyBlue, 0, 0, w - 1, 0);
            //graphic.DrawLine(Pens.DeepSkyBlue, w - 1, 0, w - 1, h - 1);
            //graphic.DrawLine(Pens.DeepSkyBlue, w - 1, h - 1, 0, h - 1);
            //graphic.DrawLine(Pens.DeepSkyBlue, 0, h - 1, 0, 0);
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.CompositingQuality = CompositingQuality.HighQuality;
            graphic.TextRenderingHint = TextRenderingHint.AntiAlias;
            int oX = w / 2;
            int oY = h / 2;
            int min = (w > h ? h : w) / 2;
            int r = min - 4;
            graphic.FillEllipse(Brushes.LightGray, oX - r, oY - r, 2 * r, 2 * r);
            int R = (int)(r * 0.618);
            graphic.FillEllipse(Brushes.White, oX - R, oY - R, 2 * R, 2 * R);
            int f = r - R;
            int hf = f / 2;
            graphic.FillEllipse(Brushes.DeepSkyBlue, oX - hf, oY - r, f, f);
            int fr = R + hf;
            graphic.DrawArc(new Pen(Color.DeepSkyBlue, f), oX - fr, oY - fr, 2 * fr, 2 * fr, -90, progress * 360 / 100);
            double angle = (-90 + progress * 360 / 100) * Math.PI / 180;
            float rX = (float)(oX + fr * Math.Cos(angle) - hf);
            float rY = (float)(oY + fr * Math.Sin(angle) - hf);
            graphic.FillEllipse(Brushes.DeepSkyBlue, rX, rY, f, f);
            float fs = R * 0.618f;
            string text = progress.ToString();
            graphic.DrawString(text.ToString(), new Font("微软雅黑", fs), Brushes.DeepSkyBlue, oX - fs * text.Length / 2, oY - fs);
            g.DrawImage(bmp, 0, 0);
        }


        private void ProgressForm_Load(object sender, EventArgs e)
        {
            RenewInterfaceHandler handler = delegate()
            {
                Invalidate();
                if (progress >= 100) Dispose();
            };

            new Task(() =>
            {
                while (progress < 100)
                {
                    progress++;
                    Invoke(handler);
                    Task.Delay(10).Wait();
                }
            }).Start();

        }
    }
    //public class ProgressParameter
    //{
    //    public int diameter;
    //    public int eaX, eaY, saX, saY, elX, slX, blY, tlY;
    //    public ProgressParameter(Control ctr, int padding)
    //    {
    //        int Height = ctr.Height;
    //        int Width = ctr.Width;
    //        int raduis = Height / 2 - padding;
    //        eaX = Width - 2 * raduis - padding;
    //        eaY = Height / 2 - raduis;
    //        saX = padding;
    //        saY = Height / 2 - raduis;
    //        elX = Width - raduis - padding;
    //        slX = raduis + padding;
    //        blY = Height / 2 + raduis;
    //        tlY = Height / 2 - raduis;
    //        diameter = 2 * raduis;
    //    }
    //}

}
//public int progress = 0;
//private delegate void RenewProgressHandler();
//public ProgressForm()
//{
//    InitializeComponent();
//}

//private int ScurveIncrease(int add)
//{
//    //int variable = add * 600 / time;
//    //add * 1000 / time;
//    //return (int)(1001 / (1 + Math.Pow(Math.E, -0.005 * (variable))));
//    return 0;
//}
//private void ProgressForm_Load(object sender, EventArgs e)
//{
//    RenewProgressHandler handler = delegate
//    {
//        if (progress < 1000)
//        {
//            progressBar.Value = progress;
//            labelProgress.Text = (progress / 10).ToString() + "%";
//        }
//        else
//        {
//            progressBar.Value = progress;
//            labelProgress.Text = (progress / 10).ToString() + "%";
//            Thread.Sleep(300);
//            Dispose();
//        }
//    };
//    new Thread(new ThreadStart(() =>
//    {
//        int add = 0;
//        while (progress < 1000)
//        {
//            add++;
//            if (add > 950) Thread.Sleep(add / 10);
//            progress = add;
//            progressBar.Invoke(handler);
//        }
//    })).Start();
//}