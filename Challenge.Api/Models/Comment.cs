﻿using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public string Content { get; set; }
    }
}