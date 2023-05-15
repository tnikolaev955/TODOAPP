using System;
using System.Collections.Generic;
using System.Text;
public abstract class JobOffer
{
    private string jobTitle;

    public string JobTitle
    {
        get 
        {
            { return jobTitle; }

        }
        set
        {
            { jobTitle = value; }
        }
    }

    private string company;

    public string Company
    {
        get 
        {
            { return company; }
        }
        set
        {
            { company = value; }
        }
    }

    private double salary;

    public double Salary
    {
        get 
        {
            { return salary; }
        }
        set 
        {
            { salary = value; } 
        }
    }

    public JobOffer(string jobTitle, string company, double salary)
    {
        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Job Title: {JobTitle}\nCompany: {Company}\nSalary: {Salary:F2} BGN";
    }

}
