using System;

namespace Assignment1B
{
    class GoogleHomeMain
    {
        static void Main(string[] args)
        {
            GoogleHome google = new GoogleHome();
            Console.WriteLine("Do you want to turn Google on?");
            google.turnGoogleOn(Console.ReadLine());
            Console.WriteLine("How many lights are connected to Google?");
            google.setNumberOfLightsConnectedToGoogle(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Do you prefer Google to be British?");
            google.setVoiceToBritish(Console.ReadLine());
            Console.WriteLine("Type 'turn on the lights'");
            google.heyGoogle(Console.ReadLine());
            Console.WriteLine("Type 'turn off the lights'");
            google.heyGoogle(Console.ReadLine()); 
        }
    }
}
