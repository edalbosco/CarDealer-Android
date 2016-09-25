using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarDealer.Helpers;
using Xamarin.Forms;
using System.ComponentModel;

namespace CarDealer
{
    public partial class App : Application
    {

 //       public NavigationService Navigation { get; set; }
        public INavigation Navigation { get; set; }

        public static new App Current { get; private set; }

        public bool Authenticated
        {
            get
            {
                return authenticated;
            }

            set
            {
                authenticated = value; OnPropertyChanged();
            }
        }

        private bool authenticated;

        public App()
        {
            InitializeComponent();

            Current = this;

            //    var root = new CarDealer.Pages.LocationsPage();
            var root = new NavigationPage (new CarDealer.Pages.MainPage());
         //   var root = new CarDealer.Pages.MainPage();

            MainPage = root;//.RootPage(true);
                            //MainPage = new CarDealer.Pages.LoginPage();

            App.Current.Navigation = root.Navigation;

            MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
   //         MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.Black);

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


    }
}

/*


Chave de API

Esta chave de API pode ser usada neste projeto e com qualquer API compatível com ela.Para usar essa chave no seu aplicativo, transfira-a com o parâmetro key=API_KEY.

Data da criação	
25 de set de 2016 11:57:23
Criada por
edalbosco @gmail.com(você)
Chave de API
AIzaSyD6XJfoVogvF79HWdYFbQLp-I3Gdl3ZvlE
Nome

CarDealersAppKey
Restrição de chave

Restringir uma chave é especificar quais websites, endereços IP ou aplicativos podem utilizá-la.Saiba mais




Nenhum

Referenciadores de HTTP(sites da Web)


Endereços IP(servidores da Web, cron jobs etc.)


Apps para Android

Apps para iOS
 Restringir o uso de seus apps para Android
Adicione o nome do seu pacote e a impressão digital do certificado de login SHA-1 para restringir o uso aos seus aplicativos para Android Saiba mais
Receba o nome do pacote do arquivo AndroidManifest.xml.Depois, use o comando a seguir para receber a impressão digital:

keytool -list -v -keystore mystore.keystore
$
Nome do pacote Impressão digital para certificação SHA-1	

br.inf.mds.cardealers

BA:22:57:B6:68:88:1C:25:98:8B:21:FB:DD:F7:AD:7B:44:DF:C0:C3

*/