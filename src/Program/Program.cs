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
            IPicture image3=final.Send(picture);

            IPipe Pipe5

            IFilter FiltroSave2=new FilterSave(2);
            IPipe Pipe5 = new PipeSerial(FiltroSave2,Pipe6);
            
            IFilter FiltroNG=new FilterNegative();
            IPipe Pipe4= new PipeSerial(FiltroNG, Pipe5);

            IFilter FiltroSave=new FilterSave(1);
            IPipe Pipe3 = new PipeSerial(FiltroSave, Pipe4);

            IFilter FiltroGS= new FilterGreyscale();
            PipeSerial Pipe2=new PipeSerial(FiltroGS, Pipe3);

            IFilter Filtro1=new FilterGreyscale();
            PipeSerial Pipe1=new PipeSerial(Filtro1,Pipe2);
            IPicture image=Pipe1.Send(picture);
        }
    }
}
