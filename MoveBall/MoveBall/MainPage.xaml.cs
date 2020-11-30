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

namespace MoveBall
{
    public partial class MainPage : ContentPage
    {
        bool timerRun = false;
        int count = 0;
        float oriX, oriY;
        SensorSpeed speed = SensorSpeed.UI;
        public MainPage()
        {
            InitializeComponent();
            Compass.ReadingChanged += Compass_ReadingChanged;
            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            var data = e.Reading;
            oriX = data.Acceleration.X;
            oriY = data.Acceleration.Y;
        }

        private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
            rotAngle.Text = String.Format("각도 {0}도", data.HeadingMagneticNorth.ToString("F2"));
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!Compass.IsMonitoring)
            {
                Compass.Start(speed);
            }
            if (!Accelerometer.IsMonitoring)
            {
                Accelerometer.Start(speed);
            }
            if (!timerRun)
            {
                timerRun = true;
                count = 0;
                Device.StartTimer(TimeSpan.FromMilliseconds(10), timerCalled);
            }
        }

        private bool timerCalled()
        {
            count++;
            countValue.Text = String.Format("Timer is Called {0} times.", count);
            return timerRun;
        }

        private void btnQuit_Clicked(object sender, EventArgs e)
        {
            if (Compass.IsMonitoring)
            {
                Compass.Stop();
            }
            if (Accelerometer.IsMonitoring)
            {
                Accelerometer.Stop();
            }
            if (timerRun)
            {
                timerRun = false;
            }

            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }

        private void btnStop_Clicked(object sender, EventArgs e)
        {
            if (Compass.IsMonitoring)
            {
                Compass.Stop();
            }
            if (Accelerometer.IsMonitoring)
            {
                Accelerometer.Stop();
            }
            if (timerRun)
            {
                timerRun = false;
            }
        }
        public void SimpleCirclePage()
        {
            Title = "Simple Circle";

            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += canvasView_PaintSurface;
            Content = canvasView;
        }
        private void canvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKCanvas sKCanvas = e.Surface.Canvas;
            sKCanvas.Clear();

            SKPaint sKPaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.Red.ToSKColor(),
                StrokeWidth = 25
            };
            sKPaint.Style = SKPaintStyle.Fill;
            sKPaint.Color = SKColors.Blue;

            sKCanvas.DrawCircle((e.Info.Width / 2 + oriX * -500), (e.Info.Height / 2 + oriY * 500), 100, sKPaint);
        }
    }
}