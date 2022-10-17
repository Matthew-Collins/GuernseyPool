namespace GuernseyPool
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnScoreCardWinterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.ScoreCardPage(new Model.ScoreCard(true)));
        }

        private void OnScoreCardSummerClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.ScoreCardPage(new Model.ScoreCard(false)));
        }

    }
}