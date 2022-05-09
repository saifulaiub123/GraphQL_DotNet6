namespace GraphQl_HotChochlete.Models
{
    public class StakeholderInfo : BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string OtherNumber { get; set; }
        public string PoliticalInterest { get; set; }
        public string PoliticalInfluence { get; set; }
        public string Batch { get; set; }
        public string CommunicationBy { get; set; }
        public string OverallRelationType { get; set; }
        public string Remarks { get; set; }
        public string OtherInformation { get; set; }
        public string ProfileImage { get; set; }
        public string BusinessCard { get; set; }
        public string Email { get; set; }
        public bool IsPrivate { get; set; }

        public List<StakeholderPosition> StakeholderPosition { get; set; }
        public List<StakeholderVisit> StakeholderVisits { get; set; }
        public List<StakeholderEducationalHistory> StakeholderEducationalHistory { get; set; }
        public List<BusinessCard> BusinessCards { get; set; }
        public UserInfo CreatedUserInfo { get; set; }
        public UserInfo UpdatedUserInfo { get; set; }
    }
}
