using System;
using System.Collections.Generic;
using System.Text;


public class Controller
{
	private readonly Dictionary<string, Category> categories;

    public Controller()
    {
        categories = new Dictionary<string, Category>();
    }

	public string AddCategory(List<string> args)
	{
        try
        {
            Category category = new Category(name);
            categories.Add(name, category);
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
    }

    public string AddJobOffer(List<string> args)
    {
        string categoryName = args[0];
        string jobTitle = args[1];
        string company = args[2];
        double salary = double.Parse(args[3]);
        string type = args[4];
        if (type.ToLower() == "onsite")
        {
            if (args.Count < 6)
            {
                throw new ArgumentException($"Missing required argument 'city' for 'onsite' job offer!");
            }

            string city = args[5];
            category.AddJobOffer(new OnsiteJobOffer(jobTitle, company, salary, city));
        }
        else if (type.ToLower() == "remote")
        {
            if (args.Count < 6)
            {
                throw new ArgumentException($"Missing required argument 'fullyRemote' for 'remote' job offer!");
            }


        }
    }
        public string GetAverageSalary(List<string> args)
        {
           string name = args[0];
           if (!categories.ContainsKey(name))
           {
             return $"Category {name} does not exist.";
           }

            double averageSalary = categories[name].AverageSalary();

            return $"The average salary is: {averageSalary} BGN";
        }

        public string GetOffersAboveSalary(List<string> args)
        {
            string categoryName = args[0];
            double salary = double.Parse(args[1]);

            if (!categories.ContainsKey(categoryName))
            {
               return $"Category {categoryName} does not exist.";
            }
        }

        public string GetOffersWithoutSalary(List<string> args)
        {
        string name = args[0];
        if (categories.ContainsKey(name))
        {
            Category category = categories[name];
            List<JobOffer> offers = category.GetOffersWithoutSalary();
            if (offers.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Job offers without salary in category {name}:");
                foreach (JobOffer offer in offers)
                {
                    sb.AppendLine(offer.ToString());
                }
                return sb.ToString();
            }
            else
            {
                return $"There are no job offers without salary in category {name}.";
            }
        }
        else
        {
            return $"Category {name} does not exist.";
        }
}