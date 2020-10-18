﻿using System;
namespace gha_newwebapp.wwwroot.Models
{
    public class Product
    {
        
        public string Id { get; set; }

        public string Maker { get; set; }

        [JsonPropertyName("img")]

        public string Image { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int[] Ratings { get; set; }

        public override ToString() => JsonSerializer.Serialize<Product>(this);
     
    }   
}

