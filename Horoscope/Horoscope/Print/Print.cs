﻿using Horoscope.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscope
{
    class Print
    {
        public string Text { get; set; }
        public IPrint Printer { get; set; }

        public Print(IPrint printer)
        {
            this.Printer = printer;
        }
        public void PrintAnswer(string text)
        {
            Printer.PrintAnswer(text);
        }
        public void PrintMenu()
        {
            Printer.PrintMenu(Text);
        }
        public void PrintEx1()
        {
            Printer.PrintEx1(Text);
        }
        public void PrintEx1DatePrediction()
        {
            Printer.PrintEx1DatePrediction(Text);
        }
        public void PrintEx1PeriodBefor()
        {
            Printer.PrintEx1PeriodBefor(Text);
        }
        public void PrintEx1PeriodAfter()
        {
            Printer.PrintEx1PeriodAfter(Text);
        }
        public void PrintEx2()
        {
            Printer.PrintEx2(Text);
        }
        public void PrintEx3()
        {
            Printer.PrintEx3(Text);
        }
        public void PrintLeave()
        {
            Printer.PrintLeave(Text);
        }
        public void PrintError()
        {
            Printer.PrintError(Text);
        }
    }
}