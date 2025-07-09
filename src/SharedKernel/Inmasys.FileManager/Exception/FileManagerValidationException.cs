namespace Inmasys.FileManager.Exception;

public class FileManagerValidationException : System.Exception
{
    public FileManagerValidationException(){}

    public FileManagerValidationException(string message)
        :base(message)
    {   
    }
}
