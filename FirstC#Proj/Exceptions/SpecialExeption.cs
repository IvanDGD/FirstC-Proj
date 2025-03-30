[Serializable]
public class SpecialException : Exception
{
    public SpecialException() { }
    public SpecialException(string message) : base(message) { }
    public SpecialException(string message, Exception inner) : base(message, inner) { }

}
