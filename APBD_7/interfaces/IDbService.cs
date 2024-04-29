using APBD_7.Models;

namespace APBD_7.interfaces;

public interface IDbService
{
    Task<Warehouse?> GetWarehouseById(int id);
    Task<Product?> GetProductById(int idProduct);
    Task<Order?> GetOrderByProductIdAndAmount(int idProduct, int amount);
    Task<Product_Warehouse?> GetProductWarehouseByOrderId(int orderId);
    void UpdateOrderFulfilledAt(DateTime date);
    Task<Product_Warehouse?> InsertToProductWarehouse(int warehouseId, int productId, int orderId, int amount, DateTime createdAt);
    Task<Product_Warehouse?> GetLastCreatedProductWarehouse();
}