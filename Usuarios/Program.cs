using System.Text.Json;
using espacioUsuario;

List<Usuario> ListaDeUsuarios;
ListaDeUsuarios = await UsuariosService.ObtenerUsuarios();

Console.WriteLine("**** LISTA DE USUARIOS COMPLETA****");
foreach (var Usuario in ListaDeUsuarios)
{
    Console.WriteLine($"Nombre: {Usuario.name} - Correo electronico: {Usuario.email} - Domicilio: {Usuario.address.street} {Usuario.address.suite}");
}
Console.WriteLine(" ");
Console.WriteLine("**** LISTA DE PRIMEROS 5 USUARIOS ****");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Nombre: {ListaDeUsuarios[i].name} - Correo electronico: {ListaDeUsuarios[i].email} - Domicilio: {ListaDeUsuarios[i].address.street} {ListaDeUsuarios[i].address.suite}");
}

string JsonString = JsonSerializer.Serialize<List<Usuario>>(ListaDeUsuarios);
File.WriteAllText("usuario.json", JsonString);