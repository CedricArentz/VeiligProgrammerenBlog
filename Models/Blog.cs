using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeiligProgrammerenBlog.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public int AuteurId { get; set; }
        public Auteur Auteur { get; set; }
        public List<Commentaar> Commentaar { get; set; }
        public string Titel { get; set; }
        public string Afbeelding { get; set; }
        public DateTime Plaatsingsdatum { get; set; }
        public DateTime LaatsteUpdate { get; set; }
        public string Inhoud { get; set; }
        public string Beeld { get; set; }

}
}
