using System;

namespace Lab4.PhoneTypes
{
    public class RotaryPhone
    {
        protected virtual string PhoneType { get; } = nameof(RotaryPhone);

        public virtual void Call()
        {
            Console.WriteLine($"{PhoneType} is calling.");
        }

        public virtual void AcceptCall()
        {
            Console.WriteLine($"{PhoneType} has accepted the call.");
        }
    }
}