using DaW_Exam.Models.Base;
using DaW_Exam.Models.Many_to_Many;

namespace DaW_Exam.Models
{
    public class Editura : BaseEntity
    {
        public string Judet { get; set; }

        public ICollection<Carte>? Carti {  get; set; }

        public Autor? Autor { get; set; }
        public Guid? AutorId { get; set; }
    }
}
