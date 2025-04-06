using NewsApp.Models;
using NewsApp.NewFolder;

namespace NewsApp.Pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article article)
	{
		InitializeComponent();
        ImgNews.Source = article.Image;
		Lbltitle.Text = article.Title;
		LblContent.Text = article.Content;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PopAsync();
    }
}