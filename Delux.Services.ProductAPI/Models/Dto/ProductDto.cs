using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Delux.Services.ProductAPI.Models.Dtos
{
    public class ProductDto
    {
        public ProductDto()
        {
            count = 1;
        }
        [Range(1,100)]
        public int count { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
