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

[assembly:Dependency(typeof(ChangeLux.Droid.MainActivity))]
[assembly: UsesPermission(Android.Manifest.Permission.Flashlight)]
[assembly: UsesPermission(Android.Manifest.Permission.Camera)]
namespace ChangeLux.Droid
{
    [Activity(Label = "ChangeLux", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ISensorEventListener, ITransLabelService
    {
        static private Label lightLabel;
        static private Label description;
        static SensorManager sensorManager;
        Sensor lightSensor;
        static private float lux;
        private WindowManagerLayoutParams lp;
        private float brightness;

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
            sensorManager.RegisterListener(this, lightSensor, SensorDelay.Game);

            lp = Window.Attributes;
        
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
            sensorManager.UnregisterListener(this);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
            //throw new NotImplementedException();
        }

        public async void OnSensorChanged(SensorEvent e)
        {
            //throw new NotImplementedException();
            lux = e.Values[0];
            string msg = string.Format("LUX Value : {0, 8:F3}", lux);
            lightLabel.Text = msg;

            if (lux >= 200)
            {
                lp.ScreenBrightness = 1f;
                Window.Attributes = lp;
                await Flashlight.TurnOffAsync();
                description.Text = "Flash Off";
            }

            else if(lux >= 100)
            {
                lp.ScreenBrightness = 0.5f;
                Window.Attributes = lp;
                await Flashlight.TurnOffAsync();
                description.Text = "Flash Off";
            }

            else if (lux >= 30)
            {
                lp.ScreenBrightness = 0.2f;
                Window.Attributes = lp;
                await Flashlight.TurnOnAsync();
                description.Text = "Flash On";
            }
        }

        public void TransModel(Label label)
        {
            //throw new NotImplementedException();
            lightLabel = label;
        }

        public void TransDes(Label label)
        {
            //throw new NotImplementedException();
            description = label;
        }
    }
}