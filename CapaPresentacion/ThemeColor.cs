using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        //Agregamos una lista de colores de tipo string en formato html
        public static List<string> ColorLista = new List<string>() { "#3F51B5",
                                                                        "#009688",
                                                                        "#FF5722",
                                                                        "#607D8B",
                                                                        "#FF9800",
                                                                        "#9C27B0",
                                                                        "#2196F3",
                                                                        "#EA676C",
                                                                        "#E41A4A",
                                                                        "#5978BB",
                                                                        "#018790",
                                                                        "#0E3441",
                                                                        "#00B0AD",
                                                                        "#721D47",
                                                                        "#EA4833",
                                                                        "#F37521",
                                                                        "#A12059",
                                                                        "#126881",
                                                                        "#364D5B",
                                                                        "#0094BC",
                                                                        "#E4126B",
                                                                        "#43B76E",
                                                                        "#B71C46",
                                                                        };

        //Metodo para cambiar el brillo del color
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //si el factor de correcion es menor a 0(negativo), el color se oscurece
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;

            }
            //si el factor de correcion es mayor a 0 (positivo) el color se aclara
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor * green;
                blue = (255 - blue) * correctionFactor + blue;

            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
