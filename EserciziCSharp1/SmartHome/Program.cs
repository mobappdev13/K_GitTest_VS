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
       static void Main(string[] args)
        {
            //observer for console
            // creates a concrete console object observer
            IStatusWriter consoleWriter = new ConsoleStatusWriter();

            Device salonLamp = new Lamp("Salon");

            
            // event DeviceStatusChangedEventHandler StatusChanged
            //x += y  => x = x + y  (add list of delegate)
            // _MyEvent += new MyDelegate(this.WelcomeUser);
            //salonLamp.Event è anche un delegate
            //notify status changed a Consolewriter (list of observers)
            salonLamp.StatusChanged += consoleWriter.DeviceStatusChanged;

            //salonLamp.AddSubscriber(consoleWriter);
            //salonLamp.AddSubscriber(new ConsoleStatusWriter());

            salonLamp.TurnOn();
            salonLamp.TurnOff();

            Device kitchenFan = new Fan("Kitchen");

            //Observable ... add subscriber
            kitchenFan.AddSubscriber(consoleWriter);

            kitchenFan.TurnOn();
            salonLamp.TurnOff();

            Device ledBathroomLamp = new LedLamp("Bathroom");
            //Observable ... add subscriber
            ledBathroomLamp.AddSubscriber(consoleWriter);

            ledBathroomLamp.TurnOn();

            Device halogenBathroomLamp = new HalogenLamp("Bathroom");
            halogenBathroomLamp.AddSubscriber(consoleWriter);
            //Observable ... add subscriber
            halogenBathroomLamp.TurnOn();

            Console.ReadLine();
        }
    }
}
