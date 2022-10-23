using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)//Hay que hacer una nueva clase filtro que lo unico que haga es guardar la imagen despues de un paso, e implementarla despues de cada filtro
        {
            PictureProvider provider = new PictureProvider(); ////a eliminar

            IPicture picture = provider.GetPicture(@"luke.jpg");
            IPipe final=new PipeNull();

            IFilter FiltroSave2=new FilterSave(2);
            IPipe Pipe4 = new PipeSerial(FiltroSave2,final);
            
            IFilter FiltroNG=new FilterNegative();    
            IPipe Pipe3 = new PipeSerial(FiltroNG, Pipe4);

            IFilter FiltroSave= new FilterSave(1);
            PipeSerial Pipe2=new PipeSerial(FiltroSave, Pipe3);

            IFilter Filtro1=new FilterGreyscale();
            PipeSerial Pipe1=new PipeSerial(Filtro1,Pipe2);
            IPicture image=Pipe1.Send(picture);
        }
    }
}
