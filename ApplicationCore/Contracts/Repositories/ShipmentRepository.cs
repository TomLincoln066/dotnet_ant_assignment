using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly DbContext _context;

        public ShipmentRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Shipment>> GetAllAsync()
        {
            return await _context.Set<Shipment>().ToListAsync();
        }

        public async Task<Shipment> GetByIdAsync(int id)
        {
            return await _context.Set<Shipment>().FindAsync(id);
        }
    }
}
