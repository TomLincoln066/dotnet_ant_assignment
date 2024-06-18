using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly IShipmentRepository _shipmentRepository;

        public ShipmentService(IShipmentRepository shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }

        public async Task<IEnumerable<ShipmentDto>> GetAllShipmentsAsync()
        {
            var shipments = await _shipmentRepository.GetAllAsync();
            return shipments.Select(s => new ShipmentDto
            {
                Destination = s.Destination,
                Weight = s.Weight,
                EstimatedDeliveryDate = s.EstimatedDeliveryDate
            });
        }

        public async Task<ShipmentDto> GetShipmentByIdAsync(int id)
        {
            var shipment = await _shipmentRepository.GetByIdAsync(id);
            if (shipment == null) return null;
            return new ShipmentDto
            {
                Destination = shipment.Destination,
                Weight = shipment.Weight,
                EstimatedDeliveryDate = shipment.EstimatedDeliveryDate
            };
        }
    }
}
