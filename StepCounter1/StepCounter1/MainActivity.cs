using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Android.Hardware;
using Android.Content;


namespace StepCounter1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, ISensorEventListener
    {
        private SensorManager sensorManager;

        private float stepCount;
        private int reset = 1;

        private int mStepDetector;
        private bool run = false;
        private Sensor stepDetectorSensor;
        TextView tvStepCount;

        Button startBtn;
        Button resetBtn;
        Button quitBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);


            sensorManager = (SensorManager)GetSystemService(Context.SensorService);

            tvStepCount = (TextView)FindViewById<TextView>(Resource.Id.tvStepCount);

            startBtn = (Button)FindViewById<Button>(Resource.Id.start);
            resetBtn = (Button)FindViewById<Button>(Resource.Id.reset);
            quitBtn = (Button)FindViewById<Button>(Resource.Id.quitBtn);

            startBtn.Click += OnStartBtn;
            quitBtn.Click += OnQuitBtn;
            resetBtn.Click += OnResetBtn;

            stepDetectorSensor = sensorManager.GetDefaultSensor(SensorType.StepDetector);
            if (stepDetectorSensor == null)
            {
                Toast.MakeText(this, "센서가 없습니다.", ToastLength.Short).Show();
            }
        }
        public void OnResetBtn(object sender, EventArgs e)
        {
            if(reset == 1) // 리셋이 1이면 초기화하라
            {
                mStepDetector = 0;
                tvStepCount.Text = "0";
                run = false;
                startBtn.Text = "시작";

            }

        }

        public void OnStartBtn(object sender, EventArgs e)
        {
            if(run==false)
            {
                run = true;
                startBtn.Text = "정지";
            }

            else if(run == true)
            {
                run = false;
                startBtn.Text = "시작";
            }
        }

        
        public void OnQuitBtn(object sender, EventArgs e)
        {
            this.FinishAffinity();
        }

        protected override void OnResume()
        {
            base.OnResume();
            sensorManager.RegisterListener(this, stepDetectorSensor, SensorDelay.Normal);
        }

        protected override void OnPause()
        {
            base.OnPause();
            //sensorManager.UnregisterListener(this);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public void OnSensorChanged(SensorEvent e)
        {
            int Count = (int)e.Values[0];

           
            if (run == true)
            {
                if (e.Values[0] == 1.0f)
                {
                    mStepDetector += Count;


                    //tvStepCount.Text = string.Format("{0:N}", mStepDetector);
                    tvStepCount.Text = mStepDetector.ToString();
                }
            }

            
            /*
            int totalCount = (int)e.Values[0];
            if (run == true)
            {
                if (reset == 0)
                {
                    totalCount = 0;
                    stepCount = totalCount;
                    tvStepCount.Text = string.Format("{0:F}", stepCount);
                }
                else if(reset == 1)
                {
                    stepCount = totalCount;
                    tvStepCount.Text = string.Format("{0:F}", stepCount);
                }
            }
            */
            //if (e.Sensor.GetType().Equals(stepCountSensor))
            //{
            //    tvStepCount.Text = string.Format("{0:f}", e.Values[0]);
            //}
        }

        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


    }
}
