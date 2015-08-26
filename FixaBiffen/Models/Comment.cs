using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixaBiffen.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int JobId { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }

        public Comment() 
        {
            this.Created = DateTime.UtcNow;
        }
    }
}