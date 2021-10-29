using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models.Options;

namespace App.Models.InputModels.Lezioni
{
    public class LezioneListInputModel
    {

        public LezioneListInputModel(string search, int page, string orderby, bool ascending, int limit, LezioneOrderOptions orderOptions)
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

