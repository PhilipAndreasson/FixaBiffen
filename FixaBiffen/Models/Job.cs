using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixaBiffen.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public string Img { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public Job()
        {
            this.Created = DateTime.UtcNow;
            this.Modified = DateTime.UtcNow;
        }
    }
}