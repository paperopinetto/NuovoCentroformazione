using App.Models.Options;
using System;
using System.Linq;

namespace App.Models.InputModels.Edifici
{
    public class EdificioListInputModel
    {
        public EdificioListInputModel(string search, int page, string orderby, bool ascending, int limit, EdificioOrderOptions orderOptions)
        {
            if (!orderOptions.Allow.Contains(orderby))
            {
                orderby = orderOptions.By;
                ascending = orderOptions.Ascending;
            }

            Search = search ?? "";
            Page = Math.Max(1, page);
            Limit = Math.Max(1, limit);
            OrderBy = orderby;
            Ascending = ascending;

            Offset = (Page - 1) * Limit;
        }

        public string Search { get; }
        public int Page { get; }
        public string OrderBy { get; }
        public bool Ascending { get; }

        public int Limit { get; }
        public int Offset { get; }
    }
}