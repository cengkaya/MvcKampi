using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content

    {
        [Key]
        public int Contentid { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }

        public int Headingid { get; set; }
        public virtual Heading Heading { get; set; }

        public int? Writerid { get; set; }
        public Writer Writer { get; set; }
        

      
    }
}
