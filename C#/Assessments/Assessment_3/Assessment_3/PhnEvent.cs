using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class MobilePhone
    {
        public delegate void RingEventHandler();
        public event RingEventHandler OnRing;

        public void ReceiveCall()
        {
            Console.WriteLine("------------Incoming call------------");
            OnRing?.Invoke();
        }
    }
    class RingtonePlayer
    {
        public void PlayRingtone()
        {
            Console.WriteLine("Playing ringtone...");
        }
    }

    class ScreenDisplay
    {
        public void ShowCaller()
        {
            Console.WriteLine("Displaying caller information...");
        }
    }
    class VibrationMotor
    {
        public void Vibrate()
        {
            Console.WriteLine("Phone is vibrating...");
        }
    }
    public class PhnEvent
    {
        public static void Main()
        {
            MobilePhone phone = new MobilePhone();

            RingtonePlayer ringtone = new RingtonePlayer();
            ScreenDisplay screen = new ScreenDisplay();
            VibrationMotor vibration = new VibrationMotor();

            phone.OnRing += ringtone.PlayRingtone;
            phone.OnRing += screen.ShowCaller;
            phone.OnRing += vibration.Vibrate;

            //Console.Write("Enter event: ");
            //string call = Console.ReadLine();
            //if (call == "call" || call == "Call")
            //{
            //  phone.ReceiveCall(call);

            //}

            phone.ReceiveCall();
        }
    }
}

