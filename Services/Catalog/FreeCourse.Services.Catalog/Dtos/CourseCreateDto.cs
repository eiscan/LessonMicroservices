using FreeCourse.Services.Catalog.Models;
using System;

namespace FreeCourse.Services.Catalog.Dtos
{
    internal class CourseCreateDto
    {
        public string Name { get; set; }
        public string Ddescription { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public Feature Feature { get; set; }
        public string CategoryId { get; set; }
    }
}
