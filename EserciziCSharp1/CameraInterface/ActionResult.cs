namespace CameraInterface
{
   public class ActionResult
    {
        bool _success;
        string _message;
        

        public ActionResult(string message, bool success)
        {
            _success = success;
            _message = message;
        }
        //public ActionResult(string message) : this(string.Empty, bool success)
        //{
        //}
        public string Message { get { return _message;} private set {_message = value; } }
        public bool Succes { get { return _success;} private set { _success = value; } }
    }
}