namespace CameraClassTest
{
    public class PhoneI : CameraClass
    {
        public int _brightnes;

        public PhoneI(string nameCamera, TypeCamera typeCamera, bool isActive, int br) : base(nameCamera, typeCamera, isActive)
        {
            _brightnes = br;
        }

        public int Brightnes { get {return _brightnes; } set {_brightnes = value; } }
        public int Calcolate(int _brightnes)
        {
            return _brightnes + 12 -2;

        }
    }
}
