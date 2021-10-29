namespace App.Models.Options
{
    public class LezioneOptions
    {
        public int PerPage { get; set; }
        public LezioneOrderOptions Order { get; set; }
    }

    public partial class LezioneOrderOptions
    {
        public string By { get; set; }
        public bool Ascending { get; set; }
        public string[] Allow { get; set; }
    }
}
