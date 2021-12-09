using System;

namespace Lab4.PhoneTypes
{
    public class BlackWhiteButtonPhone : ButtonPhone
    {
        protected override string PhoneType { get; } = nameof(BlackWhiteButtonPhone);
        
        public override void Charge()
        {
            Console.WriteLine($"{PhoneType} is charging from charger.");
        }
        
        public virtual void SendMessage()
        {
            Console.WriteLine($"{PhoneType} has sent the message.");
        }

        public virtual void RespondMessage()
        {
            Console.WriteLine($"{PhoneType} responded the message.");
        }
    }
}