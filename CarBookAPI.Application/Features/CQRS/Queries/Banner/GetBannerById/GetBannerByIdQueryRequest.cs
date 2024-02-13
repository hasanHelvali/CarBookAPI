using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBannerById
{
    public class GetBannerByIdQueryRequest
    {
        public int ID { get; set; }
        public GetBannerByIdQueryRequest(int id)
        {
            this.ID = id;
        }
    }
}
