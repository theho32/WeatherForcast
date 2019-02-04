﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class weatherForcast
    {

        public city city { get; set; }
        public List<list> list { get; set; } //forcast list (List and list are different)




    }

    public class temp
    {
        public double day { get; set; } // temperature on the day
    }
    public class weather
    {
        public string main { get; set; } //weather condition
        public string description { get; set; } //weather description
        public string icon { get; set; } // weather icon id



    }
    public class city {
            public string name { get; set; }

        }
    public class list
    {

        public double dt { get; set; } // days in milli seconds (dt is a abbrevation)
        public double pressure { get; set; } // pressure
        public double humidity { get; set; } // humidity %
        public double speed { get; set; } // wind speed km/h
        public temp temp { get; set; }
        public List<weather> weather { get; set; } // weather list
    }




}


