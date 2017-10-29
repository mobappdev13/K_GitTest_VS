
namespace CameraClassTest
{
    public class ActionResult
    {
        bool _result;
        string _message;
        public ActionResult(bool result, string message)
        {
            _result = result;
            _message = message;
        }

        public bool Result { get { return _result; } private set { _result = value; } }
        public string Message { get { return _message; } set { _message = value; } }
    }
}
