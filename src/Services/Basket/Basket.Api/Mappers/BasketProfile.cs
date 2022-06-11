using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Basket.Api.Mappers
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
		{
			//CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
		}
    }
}