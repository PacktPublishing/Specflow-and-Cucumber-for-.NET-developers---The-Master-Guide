using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowProject3
{
    [Binding]
    public class StepTransformation
    {
        [StepArgumentTransformation(@"(\d+) days ago")]
        public DateTime DaysAgo(int daysAgo)
        {
            return CalcDate(-daysAgo);
        }

        [StepArgumentTransformation(@"(\d+) days time")]
        public DateTime InDaysTime(int daysAhead)
        {
            return CalcDate(daysAhead);
        }

        private DateTime CalcDate(int days)
        {
            return DateTime.Today.Add(TimeSpan.FromDays(days));
        }
    }
}