public class Resume
{

    public string _name = "";
    public string _job = "";
    
    public void ShowResume()
    {
        Console.WriteLine($"Name: {_name}, Job: {_job}");
    }
}