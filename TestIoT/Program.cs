using System;
using System.Drawing.Text;
using System.Threading;
using Iot.Device.CpuTemperature;

namespace TestIoT
{
    internal class Program
    {
        private static CpuTemperature temperature = new CpuTemperature();

        private static void Main(string[] args)
        {
            while (true)
            {
                if (temperature.IsAvailable)
                {
                    Console.WriteLine($"CPU Temp: {temperature.Temperature.Celsius}");
                }
                Thread.Sleep(2000);
            }
        }
    }
}