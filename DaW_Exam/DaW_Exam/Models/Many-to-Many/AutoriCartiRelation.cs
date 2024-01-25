namespace DaW_Exam.Models.Many_to_Many
{
    public class AutoriCartiRelation
    {
        public Guid? CarteId { get; set; }
        public Carte? Carte { get; set; }

        public Guid? AutorId {  get; set; }
        public Autor? Autor { get; set; }
    }
}
