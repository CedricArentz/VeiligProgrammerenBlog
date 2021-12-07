using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeiligProgrammerenBlog.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public int AuteurID { get; set; }
        public string Titel { get; set; }
        public string Afbeelding { get; set; }
        public string Plaatsingsdatum { get; set; }
        public string LaatsteUpdate { get; set; }
        public string Inhoud { get; set; }
        public string Beeld { get; set; }

}
}
