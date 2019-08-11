using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1B
{
    public class GoogleHome
    {
        private bool isOn;

        private int volume;

        private bool voiceIsBritish;

        private int numberOfLightsConnected;

        private bool lightsAreOn;

        public void setVolume(int googleVolume)
        {
            volume = googleVolume;
        }

        //public void turnOnGoogle(bool googleIsOn)
        //{
        //    isOn = googleIsOn;
        //}

        public void setVoiceToBritish(string voiceShouldBeBritish)
        {
            switch (voiceShouldBeBritish.ToLower())
            {
                case "y":
                case "yes":
                case "On":
                case "true":
                case "british":
                case "set voice to british":
                    voiceIsBritish = true;
                    Console.WriteLine("Google is British");
                    break;
                case "n":
                case "no":
                case "off":
                case "false":
                case "no british":
                case "do not set voice to british":
                    voiceIsBritish = false;
                    Console.WriteLine("Google has a boring American accent");
                    break;
                default:
                    Console.WriteLine("No voice settings were changed");
                    break;
            }

            
        }

        public void setNumberOfLightsConnectedToGoogle(int numberOfLightsConnectedToGoogle)
        {
            numberOfLightsConnected = numberOfLightsConnectedToGoogle;
        }

        public void heyGoogle(string voiceDirection)
        {
            if (!isOn)
            {
                Console.WriteLine("Sorry, you can't do that while google is turned off");
            }

            else if (voiceDirection.ToLower().Contains("turn on the lights"))
            {
                Console.WriteLine("You got it, turning on " + numberOfLightsConnected + " lights.");
                lightsAreOn = true;
                return;
            }
            else if (voiceDirection.ToLower().Contains("turn off the lights"))
            {
                Console.WriteLine("You got it, turning off " + numberOfLightsConnected + " lights.");
                lightsAreOn = false;
                return;
            }
            else if (voiceDirection.ToLower().Contains("how now brown cow"))
            {
                Console.WriteLine("How indeed.");
                return;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand");
            }
            Console.ReadLine();
        }

        public void turnGoogleOn(string turnOnDirection)
        {
            switch (turnOnDirection.ToLower())
            {
                case "y":
                case "yes":
                case "on":
                case "turn on":
                case "turn google on":
                    isOn = true;
                    Console.WriteLine("Turning Google on");
                    break;
                case "n":
                case "no":
                case "off":
                case "turn off":
                case "turn google off":
                    isOn = false;
                    Console.WriteLine("Google is off");
                    break;
                default:
                    Console.WriteLine("Command was not understood.");
                    break;
            }
        }
    }
}
