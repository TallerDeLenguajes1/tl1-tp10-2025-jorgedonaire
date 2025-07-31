using System.Net;
using System.Text.Json;
using espacioTarea;
public static class TareaService
{
    private static readonly HttpClient cliente = new HttpClient();
    public static async Task<List<Tarea>> ObtenerTareas()
    {
        var url = "https://jsonplaceholder.typicode.com/todos/";
        HttpResponseMessage respuesta = await cliente.GetAsync(url);
        respuesta.EnsureSuccessStatusCode();
        string responseBody = await respuesta.Content.ReadAsStringAsync();
        List<Tarea> listaTareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);        
        return listaTareas;
    }
}