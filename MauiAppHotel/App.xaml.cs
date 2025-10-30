
namespace MauiAppHotel //nome do arquivo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem()); //declarando a pagina inicial do app
         }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400; //largura
            window.Height = 600; //altura
            return window;
        }
    }
}
