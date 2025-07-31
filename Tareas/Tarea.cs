using System.Text.Json.Serialization;

namespace espacioTarea;
public class Tarea
{
    int userId;
    int id;
    string ?title;
    bool completed;

    [JsonPropertyName("userId")]
    public int UserId { get => userId; set => userId = value; }
    [JsonPropertyName("id")]
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("title")]
    public string Title { get => title; set => title = value; }
    [JsonPropertyName("completed")]
    public bool Completed { get => completed; set => completed = value; }
}