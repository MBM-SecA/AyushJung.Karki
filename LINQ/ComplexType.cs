
using System.Linq;
using System;
class  ComplexType
{
 public void LearnLinq()
{
    var countries=Country.GetCountries();
 var result4= from country in countries
               where country.continent=="Europe" && country.population<100000
               select country;

    var result5= from country in countries
               where country.continent=="Asia" && country.independencyDay==default
               select country;

// foreach(var output in result4)
//  {
//      Console.WriteLine(output);
//  }
//hw:Is there any  african country  in your collectons.

 var output1=from Country in countries
              where Country.continent=="Africa"
              select Country.name;

  //hw:print first 2 largest  asian country names.
 
  }
}