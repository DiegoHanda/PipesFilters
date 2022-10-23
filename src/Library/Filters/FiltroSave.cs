using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        PictureProvider provider = new PictureProvider();
        public int numero;
        public FilterSave(int numero)
        {
            this.numero=numero;
        }
        public IPicture Filter(IPicture image)
        {
            IPicture result = image.Clone();
            provider.SavePicture(image, @$"Imagen_Editada{this.numero}.jpg");
            return result;
        }
    }
}