﻿using car_themed_app_DataLayer;
using car_themed_app_Repository.Interfaces;
using car_themed_app_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_themed_app.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly AppDbContext _context;

        public OrdersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            List<Order> orders = await _context.Orders.Include("Dealer").ToListAsync();
            return orders;
        }

        public async Task<Order> GetOrderAsync(int orderId)
        {
            Order order = await _context.Orders.Include("Dealer").FirstOrDefaultAsync(o => o.Id == orderId);
            return order;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            await _context.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public void DeleteOrder(int orderId)
        {
            Order orderToDelete = _context.Orders.FirstOrDefault(o => o.Id == orderId);
            _context.Remove(orderToDelete);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Update(order);
            _context.SaveChanges();
        }
    }
}
