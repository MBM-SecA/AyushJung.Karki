using System.Collections.Generic;
using System.Linq;
using System;
class ComplexType
{
void Retrictions()
{
    var countries=Country.GetCountries();
 var result4= from country in countries
               where country.continent=="Europe" && country.population<100000
               select country;

    var result5= from country in countries
               where country.continent=="Asia" && country.independencyDay==default
               select country;

 foreach(var output in result4)
 {
     Console.WriteLine(output);
 }
}


}