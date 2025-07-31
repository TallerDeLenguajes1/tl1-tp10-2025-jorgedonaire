using System.Net;
using System.Text.Json;
using espacioUsuario;
class UsuariosService
{
    private static readonly HttpClient cliente = new HttpClient();
    public static async Task<List<Usuario>> ObtenerUsuarios()
    {
        var url = "https://jsonplaceholder.typicode.com/users";
        HttpResponseMessage respuesta = await cliente.GetAsync(url);
        respuesta.EnsureSuccessStatusCode();
        string responseBody = await respuesta.Content.ReadAsStringAsync();
        List<Usuario> listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(responseBody);
        return listaUsuarios;
    }
}