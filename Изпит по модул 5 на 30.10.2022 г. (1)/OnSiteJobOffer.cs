using System;
using System.Collections.Generic;
using System.Text;


public class OnSiteJobOffer : JobOffer
{
    private string city;

    public string City
    {
        get 
        {
            { return city; }
        }
        
        set
        {
            { city = value; }
        }
    }

    public OnSiteJobOffer(string jobTitle, string company, double salary, string city) : base(jobTitle, company, salary)
    {
        if (string.IsNullOrWhiteSpace(city) || city.Length < 3 || city.Length > 30)
        {
            throw new ArgumentException("City should be between 3 and 30 characters!");
        }

        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
        City = city;
    }

    public override string ToString()
    {
        return $"Job Title: {JobTitle}\nCompany: {Company}\nSalary: {Salary:F2} BGN\nCity: {City}";
    }
}

