using Grpc.Core;
using SistemaHardware; 

namespace ServidorHardware.Services;

public class HardwareService : Inventario.InventarioBase
{
    public override Task<StockReply> ConsultarStock(StockRequest request, ServerCallContext context)
    {
        int stock = (request.NombreProducto.ToUpper() == "RTX 5090") ? 5 : 0;

        return Task.FromResult(new StockReply
        {
            Cantidad = stock,
            Mensaje = stock > 0 ? "Producto encontrado" : "Sin stock"
        });
    }
}