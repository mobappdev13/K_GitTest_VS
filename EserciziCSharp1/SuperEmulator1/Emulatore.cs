using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1
{
    public class Emulator
    {

        //emulatore getHSlist 
        //il minimo indispensabile per potere fare 
        //lista di headset che emula un tipo di device attenzione
        //mantiene lo stato ....vari per i vari subscribers devono vedere i cambi di stato
        //
        //lista constante ! lista di headsets
        private readonly List<HeadSet> _headSetsList;
        private HeadSet _currentHeadSet;

        public Emulator()
        {
            //prende la lista reale dal database
            _headSetsList = new List<HeadSet>
            {
                new Nokia3310(),
                new GalaxyS(),
                new IPhone6s()
            };
            _currentHeadSet = null;
    }

        // crea la lista locale 
        public List<string> GetModels()
        {
            List<string> listModels = new List<string>();
            foreach (HeadSet model in _headSetsList)
            {
                listModels.Add(model.Model);
            }
            return listModels;
        }

        HeadSet localHeadSet = null;

        //prima di adoperare devo sapere qualle il modello ha selezionato
        public void SetCurrentHeadset(string modelSelected)
        {
            
            foreach (HeadSet model in _headSetsList)
            {
                if (modelSelected == model.Model)
                {
                    _currentHeadSet = model;
                    break;
                }
            }//
            if (localHeadSet != null)
            {
                _currentHeadSet = localHeadSet;
            }
            else
            {
                throw new ArgumentException($"input model gived is invalid ! {modelSelected}");
            }

        }
        private bool IsModelSelected()
        {
            return _currentHeadSet != null)
           
        }

        public void Call(int id, string phoneNumber)
        {
            if (IsModelSelected())
            {
                
            }
            //attenzione gli stattin una classe call
            return false;
        }
        
        //on call state changed
        //on public
        public bool HangUpCall(string phoneNumber)
        {
            return false;
        }

        

        

    }
}
