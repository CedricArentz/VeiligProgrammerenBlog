using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeiligProgrammerenBlog.Models
{
    public class Commentaar
    {
        public int CommentaarID { get; set; }
        public string GeplaatstDoor { get; set; }
        public string CommentaarInhoud { get; set; }
        public string AantalRespects { get; set; }
        public string PlaatsingsDatum { get; set; }
        public string BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
