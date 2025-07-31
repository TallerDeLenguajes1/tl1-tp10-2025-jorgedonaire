using System.Net;
using System.Text.Json.Serialization;
namespace espacioDeudor;

public class Deudor
{
    [JsonPropertyName("status")]
    public int status { get; set; }

    [JsonPropertyName("results")]
    public Results results { get; set; }

}

public class Results
{
    [JsonPropertyName("identificacion")]
    public long identificacion { get; set; }

    [JsonPropertyName("denominacion")]
    public string denominacion { get; set; }

    [JsonPropertyName("periodos")]
    public List<Periodos> periodos { get; set; }
}

public class Periodos
{
    [JsonPropertyName("periodo")]
    public string periodo { get; set; }

    [JsonPropertyName("entidades")]
    public List<Entidades> entidades { get; set; }
}

public class Entidades
{
    [JsonPropertyName("entidad")]
    public string entidad { get; set; }

    [JsonPropertyName("situacion")]
    public int situacion { get; set; }

    [JsonPropertyName("fechaSit1")]
    public string fechaSit1 { get; set; }

    [JsonPropertyName("monto")]
    public float monto { get; set; }

    // [JsonPropertyName("diasAtrasoPago")]
    // public int diasAtrasoPago { get; set; }

    // [JsonPropertyName("refinanciaciones")]
    // public bool refinanciaciones { get; set; }
    // [JsonPropertyName("recategorizacionOblig")]
    // public bool recategorizacionOblig { get; set; }
    // [JsonPropertyName("situacionJuridica")]
    // public bool situacionJuridica { get; set; }
    // [JsonPropertyName("irrecDisposicionTecnica")]
    // public bool irrecDisposicionTecnica { get; set; }
    // [JsonPropertyName("enRevision")]
    // public bool enRevision { get; set; }
    [JsonPropertyName("procesoJud")]
    public bool procesoJud { get; set; }           
}