// See https://aka.ms/new-console-template for more information

using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;
using PersonasYGrupos.Models;

IListaBuilder MiGenerador = new InicialBuilder();
var elementos = MiGenerador.dameEmpleados();


//Mostrar todos los empleados que son chicos.
Console.WriteLine("\nMostrar todos los empleados que son chicos");
var Consulta1 =
    from item in elementos
        where item.Sex == 'M'
        select item;
foreach (var texto in Consulta1)
{
    Console.WriteLine(texto.FName + " es: "+ texto.Sex);
}

//Mostrar todos los empleados que tienen más de 16 años.
Console.WriteLine("\nMostrar todos los empleados que tienen más de 16 años");
var Consulta2= from item in elementos where (DateTime.Today).Year - (item.DOB).Year > 16 select item;

foreach (var texto in Consulta2)
{
    Console.WriteLine(texto.FName + " tiene + de 16 años (" + (texto.DOB).Year + ")");
}

//Mostrar todos los empleados que son chicas, ordenado por FName.
Console.WriteLine("\nMostrar todos los empleados que que son chicas, ordenado por nombre:");

var Consulta3 = elementos.Where(item => item.Sex == 'F').OrderBy(item => item.FName);

foreach (var texto in Consulta3)
{
    Console.WriteLine(texto.FName + " es: " + (texto.Sex));
}

//Mostrar los empleados cuyo nombre comience por j y sea chico, ordenar por edad
Console.WriteLine("\nMostrar todos los empleados cuyo nombre comience por J y sea chico, ordenado por edad:");
var Consulta4 = 
    from item in elementos
    where item.FName.StartsWith("J") && item.Sex=='M'
    orderby item.DOB
    select item;

foreach (var texto in Consulta4)
{
    Console.WriteLine(texto.FName + " es: " + (texto.Sex)+" y su año de Nacimiento es: " + (texto.DOB).Year);
}

//Sacar los empleados agrupados por Sex.
Console.WriteLine("\nMostrar todos los empleados agrupados por sexo:");
var Consulta5 = elementos.GroupBy(item => item.Sex);

foreach (var texto in Consulta5)
{
    Console.WriteLine("\nSexo "+ texto.Key + ":");
    foreach (var texto2 in texto)
    {
        Console.Write(texto2.FName + " ");
    }
}

//Sacar los empleados ordenados por FName y Agrupados por Sex.
Console.WriteLine("\nMostrar todos los empleados ordenados por nombrey agrupados por sexo:");
var Consulta6 = elementos.OrderBy(item=>item.FName).GroupBy(item=>item.Sex);

foreach (var texto in Consulta6)
{
    Console.WriteLine("\nSexo " + texto.Key + ":");
    foreach (var texto2 in texto)
    {
        Console.Write(texto2.FName + " ");
    }
}
Console.WriteLine("\nMisma que lo anterior de otra forma:");

var Consulta6bis =
    from item in elementos
    orderby item.FName
    group item by item.Sex
    into item2
    select item2;
foreach (var texto in Consulta6bis)
{
    Console.WriteLine("\nSexo " + texto.Key + ":");
    foreach (var texto2 in texto)
    {
        Console.Write(texto2.FName + " ");
    }
}
//Mostrar todos los empleados que tienen menos de 16 años.
Console.WriteLine("\n\nMostrar todos los empleados que tienen menos de 16 años:");
var Consulta12 = from item in elementos where (DateTime.Today).Year - (item.DOB).Year < 16 select item;

foreach (var texto in Consulta12)
{
    Console.WriteLine(texto.FName + " nació el año: " + (texto.DOB).Year);
}