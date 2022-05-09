namespace GraphQl_HotChochlete.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DivisionId { get; set; }
        public string DistrictBngName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string WebUrl { get; set; }
        public List<StakeholderPosition> StakeholderPosition { get; set; }
    }
}
