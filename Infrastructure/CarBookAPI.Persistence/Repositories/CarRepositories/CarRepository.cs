using CarBookAPI.Application.Interfaces.CarInterfaces;
using CarBookAPI.Domain.Entities;
using CarBookAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetCarsListWithBrand()
        {
            var values= await _context.Cars.Include(x => x.Brand).ToListAsync();
            return values;
        }
    }
}
