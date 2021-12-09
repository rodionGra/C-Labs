using System;

namespace Lab4.PhoneTypes
{
    public sealed class Smartphone : ColorButtonPhone
    {
        protected override string PhoneType { get; } = nameof(Smartphone);

        public override void Charge()
        {
            Console.WriteLine("Smartphone is charging from wireless charging.");
        }

        public override void WatchVideo()
        {
            Console.WriteLine("Smartphone is displaying the Full HD video.");
        }

        public static void EditMedia()
        {
            Console.WriteLine("Smartphone is editing the video.");
        }
    }
}