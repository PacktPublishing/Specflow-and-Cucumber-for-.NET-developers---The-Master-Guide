using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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

        [StepArgumentTransformation]
        public IEnumerable<OfferCodes> OfferCodesTransform(Table table)
        {
            return table.CreateSet<OfferCodes>();
        }

        [StepArgumentTransformation]
        public IEnumerable<ProductQuantities> ProductQuantitiesTransform(Table table)
        {
            return table.CreateSet<ProductQuantities>();
        }

        private DateTime CalcDate(int days)
        {
            return DateTime.Today.Add(TimeSpan.FromDays(days));
        }

    }
}