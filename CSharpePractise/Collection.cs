using System;
using System.Collections.Generic;

namespace Learncollection
{
    public class Collection
    {
     public void LearnLists()
        {
            List<byte> ages=new List<byte>();

            ages.Add(1);
            ages.Add(10);
            ages.Add(100);
            ages.Add(120);
            ages.Add(130);

           List<Country>countries=new List<Country>();
           Country country1=new Country();
           countries.Add(country1);
        }

       public void LearnDictionary()
        {
            Dictionary<string,string> countryCapitals=new Dictionary<string,string>

            {
                ["Nepal"]="kathmandu",
                ["India"]="Delhi",
                ["Bhutan"]="Thimpu"
            };
            //or simply you add manually like using function called Add after the object.
          foreach(var country in countryCapitals)
          {
              Console.WriteLine($"Country:{country.Key} Capital city:{country.Value}");
          }
        }

    public class Country
    {
        public string Name{get;set;}
    }
    }
}