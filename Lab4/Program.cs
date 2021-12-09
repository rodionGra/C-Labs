using System;
using Lab4.PhoneTypes;

namespace Lab4
{
    internal static class Program
    {
        // Task:
        // Використовуючи інтерфейси або спадкування реалізуйте еволюцію: дисковий телефон
        // -> кнопочний телефон –>мобільний телефон з чорно-> білим екраном – >мобільний телефон
        // з кольоровим екраном – >смартфон. (краще спадкування)
        
        public static void Main(string[] args)
        {
            DisplayRotaryPhoneFeatures();
            DisplayButtonPhoneFeatures();
            DisplayBlackWhiteButtonPhoneFeatures();
            DisplayColorButtonPhoneFeatures();
            DisplaySmartphoneFeatures();
        }

        private static void DisplayRotaryPhoneFeatures()
        {
            var rotaryPhone = new RotaryPhone();
            rotaryPhone.Call();
            rotaryPhone.AcceptCall();

            Console.WriteLine();
        }
        
        private static void DisplayButtonPhoneFeatures()
        {
            var buttonPhone = new ButtonPhone();
            buttonPhone.Call();
            buttonPhone.AcceptCall();
            buttonPhone.Charge();
            buttonPhone.Discharge();

            Console.WriteLine();
        }
        
        private static void DisplayBlackWhiteButtonPhoneFeatures()
        {
            var blackWhiteButtonPhone = new BlackWhiteButtonPhone();
            blackWhiteButtonPhone.Call();
            blackWhiteButtonPhone.AcceptCall();
            blackWhiteButtonPhone.Charge();
            blackWhiteButtonPhone.Discharge();
            blackWhiteButtonPhone.SendMessage();
            blackWhiteButtonPhone.RespondMessage();

            Console.WriteLine();
        }
        
        private static void DisplayColorButtonPhoneFeatures()
        {
            var colorButtonPhone = new ColorButtonPhone();
            colorButtonPhone.Call();
            colorButtonPhone.AcceptCall();
            colorButtonPhone.Charge();
            colorButtonPhone.Discharge();
            colorButtonPhone.SendMessage();
            colorButtonPhone.RespondMessage();
            colorButtonPhone.WatchVideo();

            Console.WriteLine();
        }
        
        private static void DisplaySmartphoneFeatures()
        {
            var smartphone = new Smartphone();
            smartphone.Call();
            smartphone.AcceptCall();
            smartphone.Charge();
            smartphone.Discharge();
            smartphone.SendMessage();
            smartphone.RespondMessage();
            smartphone.WatchVideo();
            Smartphone.EditMedia();

            Console.WriteLine();
        }
    }
}