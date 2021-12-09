using System;

namespace Lab4.PhoneTypes
{
    public class ColorButtonPhone : BlackWhiteButtonPhone
    {
        protected override string PhoneType { get; } = nameof(ColorButtonPhone);

        public virtual void WatchVideo()
        {
            Console.WriteLine("Color button phone is displaying the video.");
        }
    }
}