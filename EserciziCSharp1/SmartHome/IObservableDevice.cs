using SmartHome.StatusWriters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    interface IObservableDevice        
    {
        //Method Subscribe(IObserver<T>)
        //IStatusWriter is an IObserver

        //add Observer
        void AddSubscriber(IStatusWriter writer);
        //remove Observer
        void RemoveSubscriber(IStatusWriter writer);
        //notify Observers (can be a list)
        void NotifyStatusChanged();
    }
}
