using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate.Control
{
    public class CustomBorder : Border
    {
        public CustomBorder()
        {
            TranslationX= new Random().Next(-500,500);
            Rotation = Math.Max(TranslationX, 100);
            AddCornerRadius();

            Loaded += (s, e) =>
            {
                this.TranslateTo(0, 0, 1500, Easing.SinInOut);
                this.RotateTo(0, 1500, Easing.SinInOut);
            };
        }
        private List<int> CornerValues = new List<int> { 30, 30, 30, 30};

        private void AddCornerRadius()
        {
            var index = new Random().Next(CornerValues.Count);
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(CornerValues[index])
            };
        }
    }
}
