using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollectionsExercise02
{
    class Shoe
    {
        public Shoe(Style style, string color)
        {
            Style = style;
            Color = color;
        }
        public Style Style { get; private set; }
        public string Color { get; private set; }
        public string Description
        {
            get { return $"A {Color} {Style}"; }
        }

    }
}
