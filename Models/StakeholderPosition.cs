namespace GraphQl_HotChochlete.Models
{
    public class StakeholderPosition : BaseModel
    {
        public int Id { get; set; }
        public string StakeholderInfoId { get; set; }
        public string TitleId { get; set; }
        public string OrganizationId { get; set; }
        public int DistrictId { get; set; }
        public string Address { get; set; }
        public string OfficeNumber { get; set; }
        public string Fax { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? LastDate { get; set; }
        public string Remarks { get; set; }
        public string Email { get; set; }
        public int EngagementCategory { get; set; }
        public int StakeholderCategory { get; set; }
        public int OtherIndustryCategory { get; set; }

        public Title Title { get; set; }
        public Organization Organization { get; set; }
        public District District { get; set; }

        public StakeholderInfo StakeholderInfo { get; set; }
        public UserInfo CreatedUserInfo { get; set; }
        public UserInfo UpdatedUserInfo { get; set; }
    }
}