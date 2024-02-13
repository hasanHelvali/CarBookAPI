using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Banner.RemoveBanner
{
    public class RemoveBannerCommandRequest
    {
        public int ID { get; set; }
        public RemoveBannerCommandRequest(int id)
        {
            ID = id;
        }
    }
}
