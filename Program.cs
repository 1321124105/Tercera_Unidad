using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UbicacionBarcoBatallaNaval
{   
    public class Program
    {
    public static void Main(string[] args)
    {
    Random rnd= new Random();
    int horizontal, columna;
    int[,] mar new= int[10,10];

    for( int i= 0; i< 10; i++)
    for(  int j = 0; j < 10; j++)
    mar[i, j] =0;

    console.Write("n/n Favor de ingresar la posicion a ubicar el barco [1_10]:");
    horizontal = int.parse(console.ReadLine());

    if(horizontal >=1 && horizontal <=10){
        columna=rnd.Next(0,6);
        for(int i =0; i< 4; i++)
        mar[horizontal -1,columna +i]=1;

        for(int i=0; i< 10; i++){
            for(int j=0; j <10; j++)
            console.Write(mar[i,j]+ "/t");
            console.Write("/n";)
        }
    }else  
    console.Write("/n Ingresa un numero valido [1_10]");
    console.Readkey();
       



    }

    }






}

