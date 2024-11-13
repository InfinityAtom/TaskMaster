namespace TaskMaster
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            blazorWebView.StartPath = "/login";
        }
    }
}
