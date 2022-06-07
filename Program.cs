using System.IO;

Console.WriteLine("Ingrese el directorio:");
string path = Console.ReadLine();

List<string> ListadodeCarpetasEnDirectorio = Directory.GetFiles(path).ToList();
List<string> archivos=new List<string>();

Console.WriteLine("\nCarpetas en repositorio " + path + "\n");

foreach (var archivo in ListadodeCarpetasEnDirectorio)
{
    Console.WriteLine(archivo);
    archivos.Add(Path.GetFileNameWithoutExtension(archivo)+","+Path.GetExtension(archivo));
    
    
}
File.WriteAllLines("CarpetasEnDirectorio.csv", archivos);
