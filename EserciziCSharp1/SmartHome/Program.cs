using SmartHome.StatusWriters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    class Program
    {
        static void Foo(Device device)
        {

        }

        static void Main(string[] args)
        {
            //observer for console
            // creates a concrete console object observer
            IStatusWriter consoleWriter = new ConsoleStatusWriter();

            Device salonLamp = new Lamp("Salon");
            Device myx = new Lamp("stairs");

            // uses the event in device...
            // DeviceStatusChangedEventHandler StatusChanged
            //x += y  => x = x + y  
            salonLamp.StatusChanged += consoleWriter.DeviceStatusChanged;

            //salonLamp.AddSubscriber(consoleWriter);
            //salonLamp.AddSubscriber(new ConsoleStatusWriter());

            salonLamp.TurnOn();
            salonLamp.TurnOff();

            Device kitchenFan = new Fan("Kitchen");
            //
            kitchenFan.AddSubscriber(consoleWriter);
            kitchenFan.TurnOn();

            salonLamp.TurnOff();

            Device ledBathroomLamp = new LedLamp("Bathroom");
            ledBathroomLamp.AddSubscriber(consoleWriter);
            ledBathroomLamp.TurnOn();

            Device halogenBathroomLamp = new HalogenLamp("Bathroom");
            halogenBathroomLamp.AddSubscriber(consoleWriter);
            halogenBathroomLamp.TurnOn();

            Console.ReadLine();
        }
    }
}
