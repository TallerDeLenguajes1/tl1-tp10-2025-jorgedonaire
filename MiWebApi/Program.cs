using System.Text.Json;
using espacioDeudor;

List<Deudor> listDeudor = new List<Deudor>();
List<string> infoDeudor = new List<string>();
Deudor deudorObtenido = await deudorService.ObtenerDeudor();
Console.WriteLine("***** DATOS DEL DEUDOR *****");
Console.WriteLine($"Nombre: {deudorObtenido.results.denominacion}");
Console.WriteLine($"CUIL: {deudorObtenido.results.identificacion}");
Console.WriteLine(" ");

foreach (var periodos in deudorObtenido.results.periodos)
    {
        DateTime fecha = DateTime.ParseExact(periodos.periodo, "yyyyMM", null);
        string formato = fecha.ToString("yy-MM");
        Console.WriteLine($"\n Ultima Actualizacion de la Deuda {formato}");
        foreach (var bancos in periodos.entidades)
        {
            Console.WriteLine($"\n Entidad : {bancos.entidad} \n Situacion :{bancos.situacion}   Monto : ${bancos.monto}mil  \n Etapa judicial : {(bancos.procesoJud ? "En juicio" : "Sin juicio")}");

            infoDeudor.Add($" Entidad : {bancos.entidad}- Situacion :{bancos.situacion}   Monto : ${bancos.monto}mil - Etapa judicial : {(bancos.procesoJud ? "En juicio" : "Sin juicio")}");
        }
    }
listDeudor.Add(deudorObtenido);

DateTime FechaHoy = DateTime.Today;
string fechacsv = FechaHoy.ToString("yyyyMMdd__HHmmss");
string jsonStringCsv = JsonSerializer.Serialize<List<string>>(infoDeudor);
string jsonString = JsonSerializer.Serialize<List<Deudor>>(listDeudor);

File.WriteAllText($"deudores{fechacsv}.txt", jsonStringCsv);
File.WriteAllText("deudores.json", jsonString);