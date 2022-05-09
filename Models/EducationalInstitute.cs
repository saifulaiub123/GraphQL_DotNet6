namespace GraphQl_HotChochlete.Models
{
    public class EducationalInstitute : BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<StakeholderEducationalHistory> StakeholderEducationalHistory { get; set; }
        public UserInfo CreatedUserInfo { get; set; }
        public UserInfo UpdatedUserInfo { get; set; }

    }
}
