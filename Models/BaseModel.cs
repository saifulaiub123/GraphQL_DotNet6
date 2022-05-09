namespace GraphQl_HotChochlete.Models
{
    public class BaseModel
    {
        public int CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
