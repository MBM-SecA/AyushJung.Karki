using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
  

         int[] numbers={23,45,67,34,45,12,32,54,65,76,56};
         //fetch numbers which are greater than 50.
         //using lamda expression
         var result1=numbers.Where(x => x > 50);
      
      //using querry expression.


      var result2=from num in numbers
                   where num>50
                   select num;

 string[] names={"ayush","Abhinash","Abhaya","anil","bikash","umesh","umakunda"};
 var result3= names.Where(y=> y.Length > 4 && y.ToLower().StartsWith("a"));

//  foreach(var name in result3)
//  {
//      Console.WriteLine(name);
//  }

//print name of countyries which has population less than 100k
//projections
var result4= numbers.Select(x=> x*x);


//ordering
 var result6= from num in numbers
            orderby num  //for decending use decending keyboard at last of num in 2nd line
            select num;

//partitioning
var result7=numbers.Take(5);//take first five numbers from the list
            
var results8= numbers.Skip(5).Take(5);// skip 5 num then take 5 number from the list
// foreach(var num in result7)
//  {
//      Console.WriteLine(num);
//  }

// Quantifier
var result9=numbers.Any(x=> x%2==0);
var result10=numbers.All(x=> x%2==0);//return true if list contains all even numbers
var result11=numbers.Contains(34);
 var result12=Enumerable.Range(1, 100);//to print 1 to 1000 
 var result13=Enumerable.Repeat("Hello world",10);//print hello world 10 times




var collection=Country.GetCountries();

var assignment1= from africian in collection
                where africian.continent=="Africa"
                select africian;

               
               foreach(var output in assignment1)

          { 

        Console.WriteLine(output.name);
          }

          
        }
    }
}
