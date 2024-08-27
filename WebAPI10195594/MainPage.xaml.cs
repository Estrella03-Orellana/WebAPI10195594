using WebAPI10195594.Modelo;
using WebAPI10195594.Servicios;
namespace WebAPI10195594
{
    public partial class MainPage : ContentPage
    {
       

        private readonly IRickAndMortyService _rickAndMortyServices;

        public MainPage(IRickAndMortyService service)
        {
            InitializeComponent();
            _rickAndMortyServices = service;
        }

        private  async void  OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            var data = await _rickAndMortyServices.Obtener();
            listViewPersonajes.ItemsSource = data;

            loading.IsVisible = false;
        }
    }

}
