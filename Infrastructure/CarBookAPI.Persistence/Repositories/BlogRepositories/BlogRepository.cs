using CarBookAPI.Application.Interfaces.BlogInterfaces;
using CarBookAPI.Domain.Entities;
using CarBookAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository:IBlogRepository
    {
        private readonly CarBookContext _context;

        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetLast3BlogsWithAuthors()
        {
            var values = await _context.Blogs.Include(x => x.Author).OrderByDescending(x=>x.BlogID).Take(3).ToListAsync();
            return values.ToList();
        }


    }
}
