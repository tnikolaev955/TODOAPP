using System;
using System.Collections.Generic;
using System.Text;

public class RemoteJobOffer : JobOffer
{
    private bool fullyRemote;

    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        JobTitle = jobTitle;
        company = company;
        Salary = salary;
        FullyRemote = fullyRemote;
    }

    public bool FullyRemote
    {
        get 
        {
            { return FullyRemote; }
        }
        set 
        {
            { FullyRemote = value; }
        }
    }

    public override string ToString()
    {
        string fullyRemoteString = FullyRemote ? "yes" : "no";
        return $"Job Title: {JobTitle}\nCompany: {Company}\nSalary: {Salary:F2} BGN\nFully Remote: {fullyRemoteString}";
    }
}

