using System;
using System.Drawing;
using CognitiveCoreUCU;

namespace CompAndDel
{
    /// <summary>
    /// Un filtro que recibe, procesa y retorna imágenes. El filtro puede retornar la misma imagen o una nueva imagen
    /// creada por él.
    /// </remarks>
    public interface IFilter
    {
        /// <summary>
        /// Procesa la imagen pasada por parametro y retorna la misma imagen o una nueva.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La misma imagen o una nueva imagen creada por el filtro.</returns>
        /// 

        // CognitiveFace cog = new CognitiveFace(false);
        // cog.Recognize(@"Imagen_Editada1.jpg");
        
        // No se pudo hacer la implementacion de ejercicio 4 al obtener el siguiente mensaje de error al intentar
        // crear una nueva instacia: `Interfaces cannot contain instance fields [Library]`
        IPicture Filter(IPicture image);
    }
}
