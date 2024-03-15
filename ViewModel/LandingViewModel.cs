using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate.ViewModel
{
    public class LandingViewModel : BaseViewModel
    {

        public List<string> Sections => new List<string> { "Trending", "Popular", "Buy", "Rent" };
    }
}
