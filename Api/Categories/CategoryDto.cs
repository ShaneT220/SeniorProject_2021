using System;
using System.Collections.Generic;
using Api.Items;

namespace Api.Categories
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid MenuId { get; set; }

        public IEnumerable<ItemDto> Items { get; set; }

    }
}