namespace DaW_Exam.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
