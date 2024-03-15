using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate.Model
{
    public class PropertyRepository
    {
        public static List<Property> AllProperties = new List<Property> 
        {
            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage ="https://cdn.pixabay.com/photo/2023/08/11/04/51/fireworks-8182800_640.jpg",
                Images = new List<string> { "https://cdn.pixabay.com/photo/2014/11/21/17/17/house-540796_1280.jpg", "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_640.jpg" }

            },
            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage ="https://cdn.pixabay.com/photo/2023/08/11/04/51/fireworks-8182800_640.jpg",
                Images = new List<string> { "https://cdn.pixabay.com/photo/2014/11/21/17/17/house-540796_1280.jpg", "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_640.jpg" }

            },

            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage ="https://cdn.pixabay.com/photo/2023/08/11/04/51/fireworks-8182800_640.jpg",
                Images = new List<string> { "https://cdn.pixabay.com/photo/2014/11/21/17/17/house-540796_1280.jpg", "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_640.jpg" }

            },

            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage ="https://cdn.pixabay.com/photo/2023/08/11/04/51/fireworks-8182800_640.jpg",
                Images = new List<string> { "https://cdn.pixabay.com/photo/2014/11/21/17/17/house-540796_1280.jpg", "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_640.jpg" }

            },

        };
    }
}
