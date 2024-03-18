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
                Images = new List<string> { 
                    "https://cdn.pixabay.com/photo/2014/11/21/17/17/house-540796_1280.jpg", 
                    "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_640.jpg",
                    "https://cdn.pixabay.com/photo/2018/04/23/14/35/window-3344407_1280.jpg",
                "https://cdn.pixabay.com/photo/2018/01/11/22/35/window-3077128_960_720.jpg",
                "https://cdn.pixabay.com/photo/2017/12/27/14/41/window-3042834_1280.jpg"}

            },
            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage ="https://cdn.pixabay.com/photo/2023/08/11/04/51/fireworks-8182800_640.jpg",
                Images = new List<string> {
                    "https://cdn.pixabay.com/photo/2014/11/21/17/17/house-540796_1280.jpg",
                    "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_640.jpg",
                    "https://cdn.pixabay.com/photo/2018/04/23/14/35/window-3344407_1280.jpg",
                "https://cdn.pixabay.com/photo/2018/01/11/22/35/window-3077128_960_720.jpg",
                "https://cdn.pixabay.com/photo/2017/12/27/14/41/window-3042834_1280.jpg"}

            },

            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage ="https://cdn.pixabay.com/photo/2023/08/11/04/51/fireworks-8182800_640.jpg",
                Images = new List<string> {
                    "https://cdn.pixabay.com/photo/2014/11/21/17/17/house-540796_1280.jpg",
                    "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_640.jpg",
                    "https://cdn.pixabay.com/photo/2018/04/23/14/35/window-3344407_1280.jpg",
                "https://cdn.pixabay.com/photo/2018/01/11/22/35/window-3077128_960_720.jpg",
                "https://cdn.pixabay.com/photo/2017/12/27/14/41/window-3042834_1280.jpg"}

            },

            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage ="https://cdn.pixabay.com/photo/2023/08/11/04/51/fireworks-8182800_640.jpg",
                Images = new List<string> {
                    "https://cdn.pixabay.com/photo/2014/11/21/17/17/house-540796_1280.jpg",
                    "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_640.jpg",
                    "https://cdn.pixabay.com/photo/2018/04/23/14/35/window-3344407_1280.jpg",
                "https://cdn.pixabay.com/photo/2018/01/11/22/35/window-3077128_960_720.jpg",
                "https://cdn.pixabay.com/photo/2017/12/27/14/41/window-3042834_1280.jpg"}

            },

        };
    }
}
