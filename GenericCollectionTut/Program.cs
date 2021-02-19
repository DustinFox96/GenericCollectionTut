using System;
using System.Collections.Generic;

namespace GenericCollectionTut {
    class Program {
        static void Main(string[] args) {

            var WxHistory = new List<Weather>(3); // creating a list of WeatherHistory, Wx means weather
            var DtThr = new Weather {
                Today = new DateTime(2021, 2, 18),
                Temperature = 19,
                percipitation = 3
            };
            WxHistory.Add(DtThr); // here we just added all this info to our collection
            var DtWed = new Weather {
                Today = new DateTime(2021, 2, 17),
                Temperature = 4,
                percipitation = 0
            };
            WxHistory.Add(DtWed);
            var DtTue = new Weather {
                Today = new DateTime(2021, 2, 16),
                Temperature = 25,
                percipitation = 2
            };
            WxHistory.Add(DtTue);

            // here we are creating a foreachloop var called msg and adding strings to display, eaiser to manage and add other things this way
            foreach(var day in WxHistory) {
                var msg = $"Weather for {day.Today.ToString("MMM dd, yyyy")}" +
                            $" Percipitation was {day.percipitation} inches" +
                            $" Temperature was {day.Temperature} degrees";
                Console.WriteLine(msg);
                            
            }


            var strs = new List<string> {
                "orange", "blue", "gray",
                "red", "black", "green"
            };
            Console.WriteLine($"fav color count is {strs.Count}"); // this should show us how many entries we have in the strs list
            strs.Sort(); // this sorts the data in alpba order
            foreach( var color in strs) {
                Console.WriteLine($"color is {color}");
            }


           
            // this is considered the default constuctor 
            var ints = new List<int>();
            //here we are adding to our list
            ints.Add(7);
            ints.Add(10);
            ints.Add(3);
            ints.Add(6);
            ints.Add(96);
            ints.Add(22);
            foreach(var i in ints) {
                Console.WriteLine($"Fav number is {i}");
            }
        }
    }
}
