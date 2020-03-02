﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope.Interface
{
    interface IPrint
    {
        void PrintError(string text);
        void PrintAnswer(string text);
        void PrintMenu(string text);
        void PrintEx1(string text);
        void PrintEx1DatePrediction(string text);
        void PrintEx1Period(string text);
        void PrintEx1PeriodChoise(string text);
        void PrintEx1PeriodToday(string text);
        void PrintEx1PeriodWeek(string text);
        void PrintEx1PeriodYear(string text);

        void PrintEx2(string text);
        void PrintEx2ForecastData(string text);
        void PrintEx3(string text);
        void PrintLeave(string text);
    }
}
