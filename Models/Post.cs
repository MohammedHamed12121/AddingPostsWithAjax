using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopupsWebWithAjax.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }
        public string? Image { get; set; }
    }
}