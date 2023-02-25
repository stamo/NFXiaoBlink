# XiaoESP32C3 and .Net nanoFramework

[Seeed Studio XIAO ESP32C3](https://wiki.seeedstudio.com/XIAO_ESP32C3_Getting_Started/) is an IoT mini development board based on the Espressif ESP32-C3 WiFi/Bluetooth dual-mode chip. ESP32-C3 is a 32-bit RISC-V CPU, which includes an FPU (Floating Point Unit) for 32-bit single-precision arithmetic with powerful computing power. It has excellent radio frequency performance, supporting IEEE 802.11 b/g/n WiFi, and Bluetooth 5 (LE) protocols. And the best thing is that it can be used with [.Net nanoFramework](https://www.nanoframework.net/)

Unfortunately .Net nanoFramework doesn't yet support XiaoESP32C3 USB interface, but you can still use it by UART0 Serial Interface. To use UART0 as the serial, you need to connect pin D6 as the TX pin and pin D7 as RX pin with a USB-Serial adapter.

## Prerequisites

* Seeed Studio XIAO ESP32C3 (it is not pre soldered, so if you want to use it on a breadboard, you'll have to solder it by yourself)
* USB-C cable
* Computer
* USB to SERIAL Adapter
* LED and Resistor (150 Ω)
* .Net nanoFramework tooling and VS plugin installed

## Connect the board to Visual Studio

1. Connect the board with USB-C cable to your computer and install .Net nanoFramework on it.

``` sh
nanoff --platform esp32 --serialport COM31 --update
```

Instead of COM31 write down the port that Xiao is connected to

2. Remove the USB-C cable and connect the Xiao with USB to Serial adapter as shown on the picture

![Connecting XiaoESP32C3 to UART0](images/pins-3.png)

You can power the board either by connecting the USB to Serial adapter's 5V pin to 5V pin of the Xiao or by external power supply connected to USB-C

3. Connect the LED to GND pin of the Xiao and through resistor to pin D0

4. Open Visual Studio and find the Xiao board in the Device Explorer tab of the nanoFramework plugin. If you can not see it, press the magnifier icon to search for it. It must appear as ESP32_C3_REV3 @ COM XX
5. Deploy this demo to see the blinking LED. 

If LED is blinking you have succeeded with your first .Net nanoFramework program for XiaoESP32C3 