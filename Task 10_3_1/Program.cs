interface IWriter 
{
    void Write();
}

interface IReader 
{
    void Read();
}

interface IMailer 
{
    void SendMail();
}

class FileManager : IWriter, IReader, IMailer
{
    public void Write() 
    {

    }

    public void Read() 
    {

    }

    public void SendMail() 
    {

    }
}