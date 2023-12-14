namespace BookLibrary.Models.ViewModels
{
    public class HomeViewModel
    {
        public Dictionary<string, List<string>> Tabs { get; set; }
        public ShowCase NewRelease { get; set; }

        public ShowCase MostPopular { get; set; } 
    }

    public class ShowCase
    {
        public IList<BookSummarizedViewModel> BookList { get; set; } = new List<BookSummarizedViewModel>();
        public int Books { get; set; }
        public int CDs { get; set; }
    }
}
