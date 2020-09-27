using System;
using System.Collections.Generic;


//LINQ=language Integrated Querry
 public class Country
 {
     public String name { get; set; }
     public String continent { get; set; }
     public double area { get; set; }
     public long population { get; set; }
     public DateTime independencyDay { get; set; }


    public  Country(string n, string c, double a, long p, DateTime i=default)
     {
      name=n;
      continent=c;
      area=a;
      population=p;
      independencyDay=i;
      
     }

     public static List<Country> GetCountries()
     {
         
Country c1=new Country("Nepal","Asia",98765234.9,24356758);
Country c2=new Country("India","Asia",3387654.9,23454321, DateTime.Parse("1947/1/12"));
Country c3=new Country("Pakistan","Asia",9837654.9,24321438);
Country c4=new Country("Maldives","Asia",98654.9,45768965678);
Country c5=new Country("Bhutan","Asia",900654.9,23456778);
Country c6=new Country("China","Asia",912187654.9,2234589678);
Country c7=new Country("Algeria","Africa",9817654.9,9867458);
Country c8=new Country("Angola","Africa",677654.9,9087567);
Country c9=new Country("Cameroon","Africa",456774.9,3287967);
Country c10=new Country("Burubdi","Africa",4232654.9,213475);
Country c11=new Country("Benin","Africa",435678.9,23457578);
Country c12=new Country("Austria","Europe",7689.9,4568678);
Country c13=new Country("Croatia","Europe",7689095.9,43567878);
Country c14=new Country("Cyprus","Europe",87534.9,56876678);
Country c15=new Country("Denmark","Europe",23345.9,45764232);
Country c16=new Country("Uk","Europe",234567.9,235467878);
Country c17=new Country("Canada","North America",234567.9,3456789);
Country c18=new Country("Grenade","North America",876543.9,23456734);
Country c19=new Country("Cuba","North America",9325467.9,2345678);
Country c20=new Country("Costa Rica","North America",432143654.9,567898043);

List<Country> countries=new List<Country>{c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20};

return countries;
     }

 }