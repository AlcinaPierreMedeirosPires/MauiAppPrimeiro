namespace MauiAppPrimeiro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new View.ListaProduto());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            return new Window(new AppShell());
        }
    }
}