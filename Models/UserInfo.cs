namespace GraphQl_HotChochlete.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Function { get; set; }


        public List<BusinessCard> CreateBusinessCards { get; set; }
        public List<BusinessCard> UpdatedBusinessCards { get; set; }

        public List<EducationalInstitute> CreatedEducationalInstitute { get; set; }
        public List<EducationalInstitute> UpdatedEducationalInstitute { get; set; }

        public List<Organization> CreatedOrganization { get; set; }
        public List<Organization> UpdatedOrganization { get; set; }


        public List<StakeholderEducationalHistory> CreatedStakeholderEducationalHistory { get; set; }
        public List<StakeholderEducationalHistory> UpdatedStakeholderEducationalHistory { get; set; }

        public List<StakeholderInfo> CreatedStakeholderInfo { get; set; }
        public List<StakeholderInfo> UpdatedStakeholderInfo { get; set; }


        public List<StakeholderPosition> CreatedStakeholderPosition { get; set; }
        public List<StakeholderPosition> UpdatedStakeholderPosition { get; set; }

        public List<StakeholderVisit> VisitedByStakeholderVisit { get; set; }
        public List<StakeholderVisit> CreatedStakeholderVisit { get; set; }
        public List<StakeholderVisit> UpdatedStakeholderVisit { get; set; }

        public List<Title> CreatedTitle { get; set; }
        public List<Title> UpdatedCreatedTitle { get; set; }
    }
}