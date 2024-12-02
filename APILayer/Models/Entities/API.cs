﻿namespace APILayer.Models.Entities
{
    public class API
    {
        public int ApiId { get; set; }
        public required string OwnerId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set;}
        public string? TechnicalSpecs { get; set;}
        public decimal BasePrice { get; set; }
        public string Status { get; set; } = "Active"; // Inactive
        public int OverallSubscription { get; set; }
        public DateTime CreateAt { get; set; }

        // Relationships
        public User? Owner { get; set; }
        public ICollection<APIVersion>? Versions { get; set; }
        public ICollection<APIDocumentation>? Documentations { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<FeaturedAPI>? FeaturedAPIs { get; set; }
    }
}