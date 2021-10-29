using App.Models.ViewModels.Lezioni;
using App.Models.InputModels.Lezioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.ViewModels.Lezioni
{
    public class LezioneListViewModel
    {
        public ListViewModel<LezioneViewModel> Lezione { get; set; }
        public LezioneListInputModel Input { get; set; }

        //int IPaginationInfo.CurrentPage => Input.Page;
        //int IPaginationInfo.TotalResults => Docente.TotalCount;
        //int IPaginationInfo.ResultsPerPage => Input.Limit;

        //string IPaginationInfo.Search => Input.Search;
        //string IPaginationInfo.OrderBy => Input.OrderBy;

        //bool IPaginationInfo.Ascending => Input.Ascending;









    }
}
