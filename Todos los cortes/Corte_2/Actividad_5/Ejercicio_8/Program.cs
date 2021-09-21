using System;

namespace Punto8
{
    class Program
    {
        static void Main(string[] args)
        {
double  Suma, NumMayor,  MayorRec;
int  indice_art,indice_sucursal ;
double Articulos_Surcursal2=0;
double totalEmpresa=0;

double [] Precio = new double [5];
double [,] Cantidad = new double [4,5];


for (indice_art=1; indice_art<4; indice_art++){
System.Console.WriteLine("Ingrese precio del articulo " + indice_art +":");
Precio[indice_art]=double.Parse(Console.ReadLine());
}

for (indice_sucursal=1; indice_sucursal<4; indice_sucursal++){
for (indice_art=1; indice_art<4; indice_art++){
System.Console.WriteLine("ingrese Cant. de articulos "+ indice_art  +" en sucursal "+ indice_sucursal +":");
Cantidad[indice_sucursal,indice_art]=double.Parse(Console.ReadLine());
}
}
System.Console.WriteLine("Cantidades por articulo");
for(indice_art=1; indice_art<4; indice_art++){
Suma=Cantidad[0,indice_art]+ Cantidad [1,indice_art ] + Cantidad [ 2 , indice_art ] + Cantidad [ 3 , indice_art];
System.Console.WriteLine("Total del articulo " + indice_art + ":" + Suma);
}

//Para sucursal 2
for(indice_art=1; indice_art<4; indice_art++) {
Articulos_Surcursal2=Articulos_Surcursal2+ Cantidad[1,indice_art];
}
System.Console.WriteLine("Total surcursal 2 : "+Articulos_Surcursal2);
System.Console.WriteLine("Surcusal 1, Articulo 3: "+Cantidad[0,2]);

MayorRec=0;
NumMayor=0;

for(indice_sucursal=1;indice_sucursal<4;indice_sucursal++){
double totalSucursal=0;
for(indice_art=1; indice_art<4; indice_art++){
totalSucursal=totalSucursal+(Cantidad[indice_sucursal,indice_art]*Precio[indice_art]);
}
System.Console.WriteLine("Recaudaciones sucursal " +indice_sucursal + ':' + totalSucursal);
if(totalSucursal>MayorRec){
MayorRec=totalSucursal;
NumMayor=indice_sucursal+1;
}
totalEmpresa=totalEmpresa+totalSucursal;
}

System.Console.WriteLine("Recaudacion total:" +totalEmpresa);
System.Console.WriteLine("Sucursal de mayor recaudacion:"+ NumMayor);
        }
    }
}
