using System.Text.Json;
using espacioDeudor;
class deudorService
{
    private static readonly HttpClient cliente = new HttpClient();
    public static async Task<Deudor> ObtenerDeudor()
    {
        var url = "https://api.bcra.gob.ar/centraldedeudores/v1.0/Deudas/23373113069";
        HttpResponseMessage respuesta = await cliente.GetAsync(url);
        respuesta.EnsureSuccessStatusCode();
        string responseBody = await respuesta.Content.ReadAsStringAsync();
        Deudor deudorObt = JsonSerializer.Deserialize<Deudor>(responseBody);
        return deudorObt;
    }
}