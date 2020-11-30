using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Hardware;
using Xamarin.Forms;
using Xamarin.Essentials;
using Android.Content;
using SkiaSharp;
using SkiaSharp.Views.Forms;

[assembly:Dependency(typeof(Light1.Droid.MainActivity))]
namespace Light1.Droid
{
    [Activity(Label = "Light1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity,
        ITransLabelService, ISensorEventListener
    {
        static private Label lightLabel;
        static SensorManager sensorManager;
        Sensor lightSensor;
        static private float lux;
      

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            sensorManager = (SensorManager)GetSystemService(SensorService);
            lightSensor = sensorManager.GetDefaultSensor(SensorType.Light);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnResume()
        {
            base.OnResume();
            sensorManager.RegisterListener(this, lightSensor, SensorDelay.Game);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            sensorManager.UnregisterListener(this);
        }

        public void TransModel(Label label)
        {
            //throw new NotImplementedException();
            lightLabel = label;
        }

        public void TransVersion(Label label)
        {
            //throw new NotImplementedException();
        }

        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
            //throw new NotImplementedException();
        }

        
        public void OnSensorChanged(SensorEvent e)
        {
            lux = e.Values[0];
            string msg = string.Format("Light Level : {0, 8:F3}", lux);
            lightLabel.Text = msg;
        }

        public void TransColor(object sender, SKPaintSurfaceEventArgs e)
        {
            SKCanvas sKCanvas = e.Surface.Canvas;
            sKCanvas.Clear();

            SKPaint sKPaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.Red.ToSKColor(),
                StrokeWidth = 25
            };

            

            if (lux >= 400)
            {
                sKCanvas.Clear();
                sKPaint.Color = SKColors.Brown;
                sKPaint.Style = SKPaintStyle.Fill;
                sKCanvas.DrawCircle(e.Info.Width / 2, e.Info.Height / 2, 200, sKPaint);
            }else if(lux >= 200)
            {
                sKCanvas.Clear();
                sKPaint.Color = SKColors.Gray;
                sKPaint.Style = SKPaintStyle.Fill;
                sKCanvas.DrawCircle(e.Info.Width / 2, e.Info.Height / 2, 200, sKPaint);
            }else if (lux >= 50)
            {
                sKCanvas.Clear();
                sKPaint.Color = SKColors.Black;
                sKPaint.Style = SKPaintStyle.Fill;
                sKCanvas.DrawCircle(e.Info.Width / 2, e.Info.Height / 2, 200, sKPaint);
            }
            else
            {
                sKCanvas.Clear();
                sKPaint.Color = SKColors.Blue;
                sKPaint.Style = SKPaintStyle.Fill;
                sKCanvas.DrawCircle(e.Info.Width / 2, e.Info.Height / 2, 200, sKPaint);
            }
        }

    }
}