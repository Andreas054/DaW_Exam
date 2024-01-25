using DaW_Exam.Models.Base;

namespace DaW_Exam.Models.Many_to_Many
{
    public class Autor : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<AutoriCartiRelation>? AutoriCartiRelations { get; set; }
        //public ICollection<Carte> Carti { get; set; }

        public Editura? Editura { get; set; }
    }
}
