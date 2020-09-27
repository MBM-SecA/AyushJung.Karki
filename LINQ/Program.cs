using System;
using System.Linq;
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

 foreach(var name in result3)
 {
     Console.WriteLine(name);
 }

//print name of countyries which has population less than 100k



        }
    }
}
