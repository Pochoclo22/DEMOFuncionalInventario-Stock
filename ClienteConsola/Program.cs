using Grpc.Net.Client;
using SistemaHardware;
using System.Net.Http;

var httpHandler = new HttpClientHandler();
httpHandler.ServerCertificateCustomValidationCallback =
    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

using var channel = GrpcChannel.ForAddress("https://localhost:7233", new GrpcChannelOptions { HttpHandler = httpHandler });
var client = new Inventario.InventarioClient(channel);

Console.WriteLine("--- CLIENTE INICIADO ---");
Console.WriteLine("Escribí 'salir' para terminar el programa.");

while (true)
{
    try
    {
        Console.Write("\nIngrese el nombre del componente (ej: RTX 5090): ");
        string producto = Console.ReadLine() ?? "";

        if (producto.ToLower() == "salir") break;

        var reply = await client.ConsultarStockAsync(new StockRequest { NombreProducto = producto });

        Console.WriteLine($"SERVIDOR DICE: {reply.Mensaje}");
        Console.WriteLine($"CANTIDAD EN STOCK: {reply.Cantidad}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nERROR: {ex.Message}");
      
        break;
    }
}

Console.WriteLine("\nConexión finalizada. Presione cualquier tecla para salir...");
Console.ReadKey();