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

namespace OpenWeb3
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        float accX, accY;
        SensorSpeed speed = SensorSpeed.Game;
        int open = 0;
        public MainPage()
        {
            InitializeComponent();
            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;

            if (!Accelerometer.IsMonitoring)
            {
                Accelerometer.Start(speed);
            }
        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            var data = e.Reading;
            accX = data.Acceleration.X;
            accY = data.Acceleration.Y;

            canvasView.InvalidateSurface();
        }


        private async void Open()
        {
            await OpenBrowser();
        }

        private void OnDestroy()
        {
            if (Accelerometer.IsMonitoring)
            {
                Accelerometer.Stop();
            }
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }

        private async Task OpenBrowser()
        {
            var uri = "https://www.naver.com";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        public void SimpleCirclePage()
        {
            Title = "Simple Circle";

            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += canvasView_PaintSurface;
            Content = canvasView;
        }
        private void canvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
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

            sKCanvas.DrawCircle((info.Width / 2) + (accX * -500), (info.Height / 2) + (accY * 500), 100, sKPaint);

            //네이버로 이동하는 원
            sKPaint.Style = SKPaintStyle.Stroke;
            sKPaint.Color = SKColors.Green;

            sKCanvas.DrawCircle((info.Width / 2) - 200, info.Height / 2, 100, sKPaint);

            //종료하는 원
            sKPaint.Style = SKPaintStyle.Stroke;
            sKPaint.Color = SKColors.Black;

            sKCanvas.DrawCircle((info.Width / 2) + 200, info.Height / 2, 100, sKPaint);

            if ((info.Width / 2) + (accX * -500) < (info.Width / 2) - 200 && (info.Height / 2) + (accY * 500) > info.Height / 2)
            {
                if (open == 0)
                {
                    Open();
                    open = 1;
                }
                Device.StartTimer(TimeSpan.FromSeconds(3), () =>
                {
                    if(open == 1)
                    {
                        Open();
                        open = 0;

                        return true;
                    }

                    return false;
                });

            }

            if ((info.Width / 2 + accX * -500) > (info.Width / 2) + 200 && (info.Height / 2 + accY * 500) > info.Height / 2)
            {
                OnDestroy();
            }
        }
    }
}