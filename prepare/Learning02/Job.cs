public class Job
{

    public string _company = "";
    public string _jobTitle = "";

    public int _startYear;
    public int _endYear;

    public void ShowJob()
    {
        Console.WriteLine($"Title: {_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}