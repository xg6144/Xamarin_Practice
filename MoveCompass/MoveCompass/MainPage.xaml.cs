using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace MoveCompass
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private double angle = 0f;
        public MainPage()
        {
            InitializeComponent();
            Compass.ReadingChanged += Compass_ReadingChanged;
        }
        private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
            rotAngle.Text = String.Format("각도 : {0} 도", data.HeadingMagneticNorth.ToString("F2"));
            angle = data.HeadingMagneticNorth * Math.PI / 180.0;
            canvasView.InvalidateSurface();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!Compass.IsMonitoring)
                Compass.Start(SensorSpeed.UI, applyLowPassFilter: true);
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (Compass.IsMonitoring)
                Compass.Stop();
        }
        private void canvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear();
            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.Red.ToSKColor(),
                StrokeWidth = 25
            };
            paint.Style = SKPaintStyle.Fill;
            paint.Color = SKColors.Red;
            float x, y;
            x = (float)(info.Height * Math.Sin(angle));
            y = (float)(info.Height * Math.Cos(angle));

            canvas.DrawLine(info.Width / 2, info.Height / 2, info.Width / 2 - x, info.Height - y, paint);
            paint.Color = SKColors.Yellow;
            canvas.DrawLine(info.Width / 2, info.Height / 2, info.Width / 2 + x, y, paint);
        }
    }
}