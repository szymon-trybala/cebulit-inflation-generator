using System;
using Cebulit.InflationGenerator.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cebulit.InflationGenerator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriceController : ControllerBase
    {
        public const int InflationPercentage = 5;
            
        [HttpPost("productSet")]
        public PriceResponseDto GetProductSetPrice(ProductSetDto dto)
        {
            var priceMultiplier = (1 + (0.01 * InflationPercentage));
            var inflatedPrice = Convert.ToDouble(dto.Price) * priceMultiplier;
            return new PriceResponseDto
            {
                Price = ((int) Math.Round(inflatedPrice / 10.0)) * 10
            };
        }

        [HttpPost("product")]
        public PriceResponseDto GetProductPrice(ProductDto dto)
        {
            var priceMultiplier = (1 + (0.01 * InflationPercentage));
            var inflatedPrice = Convert.ToDouble(dto.Price) * priceMultiplier;
            return new PriceResponseDto
            {
                Price = ((int) Math.Round(inflatedPrice / 10.0)) * 10
            };        
        }
    }
}