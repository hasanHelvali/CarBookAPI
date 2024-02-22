﻿using CarBookAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public Task<List<Blog>> GetLast3BlogsWithAuthors();
    }
}