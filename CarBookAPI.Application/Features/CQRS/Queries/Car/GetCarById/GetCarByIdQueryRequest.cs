using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Car.GetCarById
{
    public class GetCarByIdQueryRequest
    {
        public GetCarByIdQueryRequest(int id)
        {
            this.ID = id;
        }

        public int ID { get; set; }

    }
}
