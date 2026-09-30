public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
{
    Console.Write($"{_jobTitle}, at {_company} from {_startYear} to {_endYear}.");
}
}

