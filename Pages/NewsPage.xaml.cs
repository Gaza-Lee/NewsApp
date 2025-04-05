namespace NewsApp.Pages;

using Microsoft.VisualBasic;
using NewsApp.Models;
using NewsApp.NewFolder;
using NewsApp.Services;

public partial class NewPage1 : ContentPage
{

    public List<Article> ArticlesList { get; set; }
    public List<Category> CategoryList = new List<Category>
    {
        new Category() {Name = "General"},
        new Category() {Name = "World" },
        new Category() {Name = "Nation"},
        new Category() {Name = "Business"},
        new Category() {Name = "Technology"},
        new Category() {Name = "Entertaiment"},
        new Category() {Name = "Sports"},
        new Category() {Name = "Science"},
        new Category() {Name = "Health"}


    };

    public NewPage1()
	{
		InitializeComponent();
        ArticlesList = new List<Article>();
        CvCategories.ItemsSource = CategoryList;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        // Fetch the news articles when the page appears
        ApiService apiService = new ApiService();
        var newsResult = await apiService.GetNews();
        foreach (var item in newsResult.Articles)
        {
            ArticlesList.Add(item);
        }

        CvNews.ItemsSource = ArticlesList;
    }

}