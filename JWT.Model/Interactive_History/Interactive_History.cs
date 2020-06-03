using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWT.Model
{
    public class Interactive_History
    {
        public Interactive_History()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { set; get; }
        [Required]
        public string Key { set; get; }
        public DateTime Times { set; get; }
        [Required]
        [MaxLength(250)]
        public string Actor { set; get; }
        [Required]
        public string Content { set; get; }
        public string TimeCreate { set; get; }

    }
}
