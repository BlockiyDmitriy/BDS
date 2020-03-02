﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class PredictWeather
    {
        public bool TempCalendarRes { get; set; }
        public PredictWeather(bool tempCalendarRes)
        {
            this.TempCalendarRes = tempCalendarRes;
        }
        public string SearchWeather()
        {
            Print print = new Print(new ConsolePrinter());
            
            if (TempCalendarRes)
            {
                Random random = new Random();
                int valueRnd = random.Next(1, 20);
                string mesPredict = Properties.PredictionWeather.ResourceManager.GetString("weather" + valueRnd);
                return mesPredict;
            }
            else
            {
                print.PrintError();
                return null;
            }
        }        
    }
}
