namespace LibraryInterfaces
{
    /// <summary>
    /// Class that implement this interface should log the passed message to an
    /// appropriate destination, such as the Console.
    /// </summary>
    public interface ILogger
    {
        void Log(string message);
    }
}
