using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWT.Model
{
    public class DefaultColumn
    {
        public int STT { set; get; }
        [Required]
        public string UserCreate { set; get; }
        public string UserModifine { set; get; }
        public DateTime? LastModifine { set; get; }
        public bool? Lock { set; get; } = false;
    }
}
