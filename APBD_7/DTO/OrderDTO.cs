using APBD_7.Models;

namespace APBD_7.DTO;

public record CreateProductWarehouseDto(int IdProduct, int IdWarehouse, int Amount, DateTime CreatedAt);