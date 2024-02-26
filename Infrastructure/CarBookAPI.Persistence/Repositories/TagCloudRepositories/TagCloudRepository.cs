using CarBookAPI.Application.Interfaces.TagCloudInterfaces;
using CarBookAPI.Domain.Entities;
using CarBookAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarBookContext _context;

        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<TagCloud>> GetTagCloudsByBlogID(int id)
        {
            var values=await _context.TagClouds.Where(x=>x.ID==id).ToListAsync();
            return values;
        }
    }
}
