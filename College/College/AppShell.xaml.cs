namespace College
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("TechStd",typeof(TechStdPage));
        }
    }
}
