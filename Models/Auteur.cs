using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeiligProgrammerenBlog.Models
{
    public class Auteur
    {
        [Key]
        public int AuteurID { get; set; }
        public DateTime Aanmelddatum { get; set; }
    }
}
