namespace College
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            string btnName = sender.GetType().Name;
        }
    }

}
