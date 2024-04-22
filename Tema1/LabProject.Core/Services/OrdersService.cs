﻿using Tema1.Core.Mapping;
using Tema1.Database.Dtos.Request;
using Tema1.Database.Dtos.Response;
using Tema1.Database.Repositories;
using Tema1.Database.Entities;

namespace Tema1.Core.Services
{
    public class OrdersService
    {
        private OrdersRepository orderRepository { get; set; }

        public OrdersService(OrdersRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void AddOrder(AddOrderRequest payload)
        {
            var project = payload.ToEntity();

            orderRepository.Add(project);
        }
       

        public GetOrderResponse GetOrders(GetOrderRequest payload)
        {
            var orders = orderRepository.GetOrders(payload);

            var result = new GetOrderResponse();
            result.Orders = orders.ToOrderDtos();
            result.Count = orderRepository.CountOrders(payload);

            return result;
        }
    }
}
