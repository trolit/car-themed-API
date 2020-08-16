using car_themed_app_Repository.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace car_themed_app_Repository.Interfaces
{
    public interface IOrdersRepository
    {
        Task<List<Order>> GetAllOrdersAsync();

        Task<Order> GetOrderAsync(int orderId);

        Task<Order> CreateOrderAsync(Order order);

        void DeleteOrder(int orderId);

        void UpdateOrder(Order order);
    }
}
