namespace GraphQl_HotChochlete.Models
{
    public class StakeholderEducationalHistory : BaseModel
    {
        public int Id { get; set; }
        public string StakeholderInfoId { get; set; }
        public string Title { get; set; }
        public string Level { get; set; }
        public string EducationalInstituteId { get; set; }
        public int Year { get; set; }
        public string Batch { get; set; }

        public EducationalInstitute EducationalInstitute { get; set; }
        public StakeholderInfo StakeholderInfo { get; set; }
        public UserInfo CreatedUserInfo { get; set; }
        public UserInfo UpdatedUserInfo { get; set; }

    }
}