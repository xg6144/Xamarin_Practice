using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MesCall
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        TimeSpan duration1 = TimeSpan.FromSeconds(0.5);
        TimeSpan duration2 = TimeSpan.FromSeconds(1);

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                PhoneDialer.Open(Num.Text);
            }
            catch(ArgumentNullException anEx)
            {
                Debug.WriteLine(anEx.Message);
            }
            catch(FeatureNotSupportedException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        private void Button1_Clicked(Object sender, EventArgs e)
        {
            _ = SendMsg(Msg.Text, Num.Text);
        }

        public async Task SendMsg(string msgTxt, string rec)
        {
            try
            {
                var msg = new SmsMessage(msgTxt, new[] { rec });
                await Sms.ComposeAsync(msg);
            }
            catch(FeatureNotSupportedException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void Vibrate(string txt)
        {
            if (txt.Length == 1)
            {
                string firstIndex = txt.Substring(0, 1);
                OneSub(firstIndex);
            }

            if(txt.Length == 2)
            {
                string firstIndex = txt.Substring(0, 1);
                string secondIndex = txt.Substring(1, 1);
                OneSub(firstIndex);
                SecondSub(secondIndex);
            }
            if (txt.Length == 3)
            {
                string firstIndex = txt.Substring(0, 1);
                string secondIndex = txt.Substring(1, 1);
                string thirdIndex = txt.Substring(2, 1);
                OneSub(firstIndex);
                SecondSub(secondIndex);
                ThirdSub(thirdIndex);
            }

            if (txt.Length == 4)
            {
                string firstIndex = txt.Substring(0, 1);
                string secondIndex = txt.Substring(1, 1);
                string thirdIndex = txt.Substring(2, 1);
                string fourthIndex = txt.Substring(3, 1);
                OneSub(firstIndex);
                SecondSub(secondIndex);
                ThirdSub(thirdIndex);
                FourthSub(fourthIndex);
            }

            if (txt.Length == 5)
            {
                string firstIndex = txt.Substring(0, 1);
                string secondIndex = txt.Substring(1, 1);
                string thirdIndex = txt.Substring(2, 1);
                string fourthIndex = txt.Substring(3, 1);
                string fifthIndex = txt.Substring(4, 1);

                OneSub(firstIndex);
                SecondSub(secondIndex);
                ThirdSub(thirdIndex);
                FourthSub(fourthIndex);
                FifthSub(fifthIndex);

            }
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            Vibrate(Vib.Text);
        }

        public void OneSub(string txt)
        {
            string firstIndex = txt;
            if (firstIndex.Equals("a") || firstIndex.Equals("A"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }
            if (firstIndex.Equals("b") || firstIndex.Equals("B"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }
            if (firstIndex.Equals("c") || firstIndex.Equals("C"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("d") || firstIndex.Equals("D"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("e") || firstIndex.Equals("E"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("f") || firstIndex.Equals("F"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("g") || firstIndex.Equals("G"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("h") || firstIndex.Equals("H"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("i") || firstIndex.Equals("I"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("j") || firstIndex.Equals("J"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("k") || firstIndex.Equals("K"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("l") || firstIndex.Equals("L"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("m") || firstIndex.Equals("M"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("n") || firstIndex.Equals("N"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("o") || firstIndex.Equals("O"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("p") || firstIndex.Equals("P"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("q") || firstIndex.Equals("Q"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("r") || firstIndex.Equals("R"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("s") || firstIndex.Equals("S"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("t") || firstIndex.Equals("T"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("u") || firstIndex.Equals("U"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("v") || firstIndex.Equals("V"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("w") || firstIndex.Equals("W"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("x") || firstIndex.Equals("X"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("y") || firstIndex.Equals("Y"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (firstIndex.Equals("z") || firstIndex.Equals("Z"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

        }
        public void SecondSub(string txt)
        {
            string secondIndex = txt;
            if (secondIndex.Equals("a") || secondIndex.Equals("A"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("b") || secondIndex.Equals("B"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("c") || secondIndex.Equals("C"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("d") || secondIndex.Equals("D"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("e") || secondIndex.Equals("E"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("f") || secondIndex.Equals("F"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("g") || secondIndex.Equals("G"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("h") || secondIndex.Equals("H"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("i") || secondIndex.Equals("I"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("j") || secondIndex.Equals("J"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("k") || secondIndex.Equals("K"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("l") || secondIndex.Equals("L"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("m") || secondIndex.Equals("M"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("n") || secondIndex.Equals("N"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("o") || secondIndex.Equals("O"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("p") || secondIndex.Equals("P"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("q") || secondIndex.Equals("Q"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("r") || secondIndex.Equals("R"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("s") || secondIndex.Equals("S"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("t") || secondIndex.Equals("T"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("u") || secondIndex.Equals("U"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("v") || secondIndex.Equals("V"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("w") || secondIndex.Equals("W"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("x") || secondIndex.Equals("X"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("y") || secondIndex.Equals("Y"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (secondIndex.Equals("z") || secondIndex.Equals("Z"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }
        }
        public void ThirdSub(string txt)
        {
            string thirdIndex = txt;
            //thirdIndex

            if (thirdIndex.Equals("a") || thirdIndex.Equals("A"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }
            if (thirdIndex.Equals("b") || thirdIndex.Equals("B"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("c") || thirdIndex.Equals("C"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("d") || thirdIndex.Equals("D"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("e") || thirdIndex.Equals("E"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("f") || thirdIndex.Equals("F"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("g") || thirdIndex.Equals("G"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("h") || thirdIndex.Equals("H"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("i") || thirdIndex.Equals("I"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("j") || thirdIndex.Equals("J"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("k") || thirdIndex.Equals("K"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("l") || thirdIndex.Equals("L"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("m") || thirdIndex.Equals("M"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("n") || thirdIndex.Equals("N"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("o") || thirdIndex.Equals("O"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("p") || thirdIndex.Equals("P"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("q") || thirdIndex.Equals("Q"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("r") || thirdIndex.Equals("R"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("s") || thirdIndex.Equals("S"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("t") || thirdIndex.Equals("T"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("u") || thirdIndex.Equals("U"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("v") || thirdIndex.Equals("V"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("w") || thirdIndex.Equals("W"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("x") || thirdIndex.Equals("X"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("y") || thirdIndex.Equals("Y"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (thirdIndex.Equals("z") || thirdIndex.Equals("Z"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }
        }
        public void FourthSub(string txt)
        {
            string fourthIndex = txt;

            //fourthIndex

            if (fourthIndex.Equals("a") || fourthIndex.Equals("A"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }
            if (fourthIndex.Equals("b") || fourthIndex.Equals("B"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("c") || fourthIndex.Equals("C"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("d") || fourthIndex.Equals("D"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("e") || fourthIndex.Equals("E"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("f") || fourthIndex.Equals("F"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("g") || fourthIndex.Equals("G"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("h") || fourthIndex.Equals("H"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("i") || fourthIndex.Equals("I"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("j") || fourthIndex.Equals("J"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("k") || fourthIndex.Equals("K"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("l") || fourthIndex.Equals("L"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("m") || fourthIndex.Equals("M"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("n") || fourthIndex.Equals("N"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("o") || fourthIndex.Equals("O"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("p") || fourthIndex.Equals("P"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("q") || fourthIndex.Equals("Q"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("r") || fourthIndex.Equals("R"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("s") || fourthIndex.Equals("S"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("t") || fourthIndex.Equals("T"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("u") || fourthIndex.Equals("U"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("v") || fourthIndex.Equals("V"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("w") || fourthIndex.Equals("W"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("x") || fourthIndex.Equals("X"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("y") || fourthIndex.Equals("Y"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fourthIndex.Equals("z") || fourthIndex.Equals("Z"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }
        }
        public void FifthSub(string txt)
        {
            string fifthIndex = txt;

            //fifthIndex

            if (fifthIndex.Equals("a") || fifthIndex.Equals("A"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }
            if (fifthIndex.Equals("b") || fifthIndex.Equals("B"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("c") || fifthIndex.Equals("C"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("d") || fifthIndex.Equals("D"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("e") || fifthIndex.Equals("E"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("f") || fifthIndex.Equals("F"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("g") || fifthIndex.Equals("G"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("h") || fifthIndex.Equals("H"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("i") || fifthIndex.Equals("I"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("j") || fifthIndex.Equals("J"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("k") || fifthIndex.Equals("K"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("l") || fifthIndex.Equals("L"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("m") || fifthIndex.Equals("M"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("n") || fifthIndex.Equals("N"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("o") || fifthIndex.Equals("O"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("p") || fifthIndex.Equals("P"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("q") || fifthIndex.Equals("Q"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("r") || fifthIndex.Equals("R"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("s") || fifthIndex.Equals("S"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("t") || fifthIndex.Equals("T"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("u") || fifthIndex.Equals("U"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("v") || fifthIndex.Equals("V"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("w") || fifthIndex.Equals("W"))
            {
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("x") || fifthIndex.Equals("X"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("y") || fifthIndex.Equals("Y"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
            }

            if (fifthIndex.Equals("z") || fifthIndex.Equals("Z"))
            {
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration2);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
                Vibration.Vibrate(duration1);
                Thread.Sleep(1000);
            }
        }
    }
}
