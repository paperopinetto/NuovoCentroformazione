
using App.Models.InputModels.Edifici;
using App.Models.ViewModels.Edifici;

namespace App.Models.ViewModels.Docenti


{
    public class EdificioListViewModel 
    {
        public ListViewModel<EdificioViewModel> Edificio { get; set; }
        public EdificioListViewModel Input { get; set; }

        //int IPaginationInfo.CurrentPage => Input.Page;
        //int IPaginationInfo.TotalResults => Edificio.TotalCount;
        //int IPaginationInfo.ResultsPerPage => Input.Limit;

        //string IPaginationInfo.Search => Input.Search;
        //string IPaginationInfo.OrderBy => Input.OrderBy;

        //bool IPaginationInfo.Ascending => Input.Ascending;
    }
}