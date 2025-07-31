using System.Text.Json;
using espacioTarea;

List<Tarea> ListaDeTareas;
ListaDeTareas = await TareaService.ObtenerTareas();
List<Tarea> ListaDeTareasCompletadas = new List<Tarea>();
List<Tarea> ListaDeTareasPendientes = new List<Tarea>();

Console.WriteLine("Todas las tareas");
foreach (var tarea in ListaDeTareas)
{
    // Console.WriteLine($"ID de usuario: {tarea.UserId} - ID: {tarea.Id} - Titulo: {tarea.Title} - Estado: {tarea.Completed}");
    Console.WriteLine($"Titulo: {tarea.Title} - Estado: {tarea.Completed}");
    if (tarea.Completed == true)
    {
        ListaDeTareasCompletadas.Add(tarea);
    }
    else
    {
        ListaDeTareasPendientes.Add(tarea);
    }
}
Console.WriteLine(" ");

    Console.WriteLine("Tareas Pendientes");
    foreach (var tareaPendiente in ListaDeTareasPendientes)
    {
        Console.WriteLine($"Titulo: {tareaPendiente.Title} - Estado: {tareaPendiente.Completed}");
    }
    Console.WriteLine(" ");
    Console.WriteLine("Tareas Completas");
    foreach (var tareaCompleta in ListaDeTareasCompletadas)
    {
        Console.WriteLine($"Titulo: {tareaCompleta.Title} - Estado: {tareaCompleta.Completed}");
    }
    Console.WriteLine(" ");

string JsonString = JsonSerializer.Serialize<List<Tarea>>(ListaDeTareas);
File.WriteAllText("tareas.json", JsonString);