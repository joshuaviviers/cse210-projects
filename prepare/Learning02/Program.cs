using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks.Dataflow;
class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();
        resume1._name = "Joshua Viviers";
        resume1._job = "Electrical Engineer";

        Job job1 = new Job();
        job1._company = "Tesla";
        job1._jobTitle = "Head Engineer";
        job1._startYear = 2001;
        job1._endYear = 2015;

        List<Resume> resumes = new List<Resume>();
        resumes.Add(resume1);

        List<Job> jobs = new List<Job>();
        jobs.Add(job1);
    
        foreach(Resume resume in resumes)
    {
        resume.ShowResume();
    }
        foreach(Job job in jobs)
        {
            job.ShowJob();
        }
    }
}