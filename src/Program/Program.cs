﻿using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)//Hay que hacer una nueva clase filtro que lo unico que haga es guardar la imagen despues de un paso, e implementarla despues de cada filtro
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");

            IPipe Pipe3=new PipeNull();
            IFilter Filtro2=new FilterNegative();

            PipeSerial Pipe2=new PipeSerial(Filtro2, Pipe3);

            IFilter Filtro1=new FilterGreyscale();

            PipeSerial Pipe1=new PipeSerial(Filtro1,Pipe2);

            IPicture image=Pipe1.Send(picture);

            provider.SavePicture(image, @"Imagen_Editada.jpg");
        }
    }
}
