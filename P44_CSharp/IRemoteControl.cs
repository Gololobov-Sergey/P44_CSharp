using System;
using System.Collections.Generic;
using System.Text;

namespace P44_CSharp
{
    internal interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
        void IncreaseVolume();
        void DecreaseVolume();

        bool IsOn { get; set; }

    }


    class Radio : IRemoteControl
    {
        bool isOn = false;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }


        public void DecreaseVolume()
        {
            throw new NotImplementedException();
        }
        public void IncreaseVolume()
        {
            throw new NotImplementedException();
        }
        public void SetChannel(int channel)
        {
            throw new NotImplementedException();
        }
        public void TurnOff()
        {
            if (isOn)
            {
                isOn = false;
                Console.WriteLine("Radio is turned off.");
            }
        }
        public void TurnOn()
        {
            if (!isOn)
            {
                isOn = true;
                Console.WriteLine("Radio is turned on.");
            }
        }
    }

    class TV : IRemoteControl
    {
        int chanel = 0;

        bool isOn = false;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }

        int volume = 10;

        public void DecreaseVolume()
        {
            volume--;
            Show();
        }
        public void IncreaseVolume()
        {
            volume++;
            Show();
        }
        public void SetChannel(int channel)
        {
            chanel = channel;
            Show();
        }
        public void TurnOff()
        {
            Show();
            if (isOn)
            {
                isOn = false;
                Console.SetCursorPosition(12, 5);
                Console.WriteLine("TV is turned off.");
            }
        }
        public void TurnOn()
        {
            Show();
            if (!isOn)
            {
                isOn = true;
                
            }
            
        }

        public void Show()
        {
            Console.Clear();
            Console.CursorVisible = false;
            int width = 40;
            int height = 15;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Верхня або нижня межа
                    if (y == 0 || y == height - 1)
                    {
                        Console.Write("*");
                    }
                    // Ліва або права межа
                    else if (x == 0 || x == width - 1)
                    {
                        Console.Write("*");
                    }
                    // Внутрішня частина
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(33, 1);
            Console.Write($"CH {chanel}");

            Console.SetCursorPosition(3, 13);
            Console.Write("Volume : ");
            Console.SetCursorPosition(10, 13);
            for (int i = 0; i < volume; i++)
            {
                Console.Write("|");
            }


            Console.SetCursorPosition(0, 16);
        }

    }

    class Remote
    {
        IRemoteControl device;
        public Remote(IRemoteControl device)
        {
            this.device = device;
        }

        public void PressKey()
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;

            switch (consoleKey)
            {
                case ConsoleKey.Q:
                    if (device.IsOn)
                        device.TurnOff();
                    else
                        device.TurnOn();
                    break;
                case ConsoleKey.D1:
                    device.SetChannel(1);
                    break;
                case ConsoleKey.D2:
                    device.SetChannel(2);
                    break;
                case ConsoleKey.D3:
                    device.SetChannel(3);
                    break;
                case ConsoleKey.D4:
                    device.SetChannel(4);
                    break;
                case ConsoleKey.D5:
                    device.SetChannel(5);
                    break;
                case ConsoleKey.D6:
                    device.SetChannel(6);
                    break;
                case ConsoleKey.D7:
                    device.SetChannel(7);
                    break;
                case ConsoleKey.D8:
                    device.SetChannel(8);
                    break;
                case ConsoleKey.D9:
                    device.SetChannel(9);
                    break;
                case ConsoleKey.UpArrow:
                    device.IncreaseVolume();
                    break;
                case ConsoleKey.DownArrow:
                    device.DecreaseVolume();
                    break;
                default:
                    break;
            }
        }
    }

}


