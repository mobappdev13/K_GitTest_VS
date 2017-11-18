using HeadsetEmulator.Events;
using HeadsetEmulator.HeadSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetEmulator
{
    public class Emulator : ICallStatusNotifier
    {
        //base: public delegate string MyDelegate(string str);
        public delegate void CallStatusChangedEventHandler(Emulator emulator);

        //base: event MyDelegate _MyEvent;       
        public event CallStatusChangedEventHandler CallStatusChanged;
       
        //list of observers of call status
        private List<ICallStatusObserver> _observers = new List<ICallStatusObserver>();

        //list of headsets for shoose the model to emulate
        private readonly List<HeadSet> _headsets;
       
        //current model selected
        private HeadSet _currentHeadSet;

        public Emulator()
        {
            _headsets = new List<HeadSet>
            {
                new Nokia3310(),
                new GalaxyS(),
                new Iphone6s()
            };

            _currentHeadSet = null;
        }

        //
        //this is the property to be observed
        public string CallStatus { get; set; }
       
        public List<string> GetModels()
        {
            List<string> result = new List<string>();
            foreach (HeadSet cell in _headsets)
            {
                result.Add(cell.Model);
            }
            return result;
        }

        public void SetCurrentHeadset(string model)
        {
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("The given model is null or empty", nameof(model));
            }
            HeadSet localHeadSet = null;
            foreach (HeadSet cell in _headsets)
            {
                if (model == cell.Model)
                {
                    localHeadSet = cell;
                    break;
                }
            }

            if (localHeadSet != null)
            {
                _currentHeadSet = localHeadSet;
            }
            else
            {
                throw new ArgumentException($"The given model [{model}] is invalid", nameof(model));
            }
        }

        public void Call(string number)
        {
            if (IsModelSelected())
            {
                ActionResult action = _currentHeadSet.Call(number);
            }
        }

        private bool IsModelSelected()
        {
            return _currentHeadSet != null;
        }

        public void AddCallStatusChangedObserver(ICallStatusObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
         }

        public void RemoveCallStatusChangedObserver(ICallStatusObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyCallStatus()
        {
            CallStatusChanged(this);

            //informs all ICallStatusObserver the change state of call
            foreach (ICallStatusObserver observer in _observers)
            {
                //observer.CallStatusChanged("2345678", false);
                observer.CallStatusChanged(this);
                
           }
        }
    }
}
