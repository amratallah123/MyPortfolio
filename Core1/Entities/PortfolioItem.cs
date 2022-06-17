using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class PortfolioItem : EntityBase
    {   
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
