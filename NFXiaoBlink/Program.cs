using System.Device.Gpio;
using System.Threading;

namespace NFXiaoBlink
{
    /// <summary>
    /// Demo for running 
    /// .Net nanoFramework on XiaoESP32C3
    /// To use UART0 as the serial, 
    /// you need to connect pin D6 as the TX pin 
    /// and pin D7 as RX pin with a USB-Serial adapter
    /// </summary>
    public class Program
    {
        /// <summary>
        /// GPIO Controller
        /// </summary>
        private static GpioController s_GpioController;

        public static void Main()
        {
            s_GpioController = new GpioController();

            // Led to blink
            // Led is connected to GPIO 2 (D0 pin of the Xiao)
            GpioPin led = s_GpioController.OpenPin(2, PinMode.Output);
            led.Write(PinValue.High);

            // Blink the LED
            while (true)
            {
                led.Toggle();
                Thread.Sleep(125);
                led.Toggle();
                Thread.Sleep(125);
                led.Toggle();
                Thread.Sleep(125);
                led.Toggle();
                Thread.Sleep(525);
            }
        }
    }
}
