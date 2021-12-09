using System;

namespace Lab4.PhoneTypes
{
    public class ButtonPhone : RotaryPhone
    {
        protected override string PhoneType { get; } = nameof(ButtonPhone);

        public virtual void Charge()
        {
            Console.WriteLine($"{PhoneType} is charging from station.");
        }

        public virtual void Discharge()
        {
            Console.WriteLine($"{PhoneType} is discharged.");
        }
    }
}