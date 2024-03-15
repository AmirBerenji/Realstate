using Realstate.Model;
using Realstate.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Realstate.ViewModel
{
    public class LandingViewModel : BaseViewModel
    {


        public List<string> Sections => new List<string> { "Trending", "Popular", "Buy", "Rent" };

        public List<Property> Properties => PropertyRepository.AllProperties;

        public Property SelectedProperty {  get; set; }

        public ICommand PropertySelected => new Command(obj =>
        {
            if (SelectedProperty != null)
            {
                Application.Current.MainPage.Navigation.PushAsync(new DetailsPage1(SelectedProperty));

                SelectedProperty = null;
            }
        });
    }
}
