using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category
{
    private string name;
    private List<JobOffer> jobOffers;

    public string Name
    {
        get 
        {
            { return Name; }
        }
        
        set
        {
            { Name = value; }
        }
    }

    public Category(string name)
    {
        if (name.Length < 2 || name.Length > 40)
        {
            throw new ArgumentException("Name should be between 2 and 40 characters!");
        }
    }

    public void AddJobOffer(JobOffer offer)
    {
        _offers.Add(offer);
    }

    public double AverageSalary()
    {
        double sum = 0;
        int count = 0;

        foreach (JobOffer offer in _offers)
        {
            if (offer.Salary >= 0)
            {
                sum += offer.Salary;
                count++;
            }
        }

        if (count == 0)
        {
            return 0;
        }

        return sum / count;
    }

    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        List<JobOffer> offers = new List<JobOffer>();

        foreach (JobOffer offer in _offers)
        {
            if (offer.Salary >= salary)
            {
                offers.Add(offer);
            }
        }

        offers.Sort((o1, o2) => o2.Salary.CompareTo(o1.Salary));

        return offers;
    }

    public List<JobOffer> GetOffersWithoutSalary()
    {
        List<JobOffer> offers = new List<JobOffer>();

        foreach (JobOffer offer in _offers)
        {
            if (offer.Salary == 0)
            {
                offers.Add(offer);
            }
        }

        offers.Sort((o1, o2) => o1.Company.CompareTo(o2.Company));

        return offers;
    }

    public override string ToString()
    {
        return $"Category {Name}\nTotal Offers: {_offers.Count}";
    }
}