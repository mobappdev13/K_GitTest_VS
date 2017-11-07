using SmartHome.StatusWriters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public abstract class Device : IObservableDevice
    {
        //base: public delegate string MyDelegate(string str);
        public delegate void DeviceStatusChangedEventHandler(Device device);

        //base: event MyDelegate _MyEvent;       
        public event DeviceStatusChangedEventHandler StatusChanged;

        protected bool _isOn;

        //this is a fondamental list of Subscrivers (observers)
        private List<IStatusWriter> _subscribers = new List<IStatusWriter>();

        public Device(string room)
        {
            Room = room;
        }

        public string DeviceType { get; protected set; }

        public string Room { get; private set; }

      
        //this is the property to be observed
        public string Status
        {
            get
            {
                return _isOn ? "on" : "off";
            }
        }

        //add method of the interface IObservableDevice
        public void AddSubscriber(IStatusWriter writer)
        {
            // add subscribers only if is not present 
            // does not accept duplicate
            if (!_subscribers.Contains(writer))
                _subscribers.Add(writer);
        }

        //Remove method of the interface IObservableDevice
        public void RemoveSubscriber(IStatusWriter writer)
        {
            // add subscribers only if is not present 
            // does not accept duplicate
            if (_subscribers.Contains(writer))
                _subscribers.Remove(writer);
        }

        ////Notify method of the interface IObservableDevice
        public void NotifyStatusChanged()
        {
            if (StatusChanged != null)

                //call the event with delegate
                //StatusChanged(this Device);
                //
                //  delegato("Ciao, buon compleanno, Lunga vita a te !")
                StatusChanged(this);

            //informs all subscribers of state change
            // call the updateMethod of each Observer
            // this refers to the current device of this class
            foreach (IStatusWriter subscriber in _subscribers)
            {
                subscriber.DeviceStatusChanged(this);
            }
        }

        public bool TurnOn()
        {
            bool oldStatus = _isOn;
            _isOn = true;

            if (oldStatus != _isOn)
                // notyfy all the obsevers thet status are changed
                NotifyStatusChanged();

            return _isOn;
        }

        public bool TurnOff()
        {
            bool oldStatus = _isOn;
            _isOn = false;

            if (oldStatus != _isOn)
                // // notyfy all the obsevers thet status are changed
                NotifyStatusChanged();

            return _isOn;
        }

        public abstract int CalculateConsumption();

        public abstract string GetDescription();

        //public virtual int CalculateConsumption()
        //{
        //    return 0;
        //}
    }
}
