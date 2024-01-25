using DaW_Exam.Models.Base;

namespace DaW_Exam.Models.Many_to_Many
{
    public class Carte : BaseEntity
    {
        public string ISIN { get; set; }

        public ICollection<AutoriCartiRelation>? AutoriCartiRelations { get; set; }
        //public ICollection<Autor> Autori {  get; set; }

        public Editura? Editura { get; set; }
        public Guid? EdituraId { get; set; }
    }
}
