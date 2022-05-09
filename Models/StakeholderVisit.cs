namespace GraphQl_HotChochlete.Models
{
    public class StakeholderVisit : BaseModel
    {
        public int Id { get; set; }
        public string StakeholderInfoId { get; set; }
        public DateTime VisitedDate { get; set; }
        public int VisitedBy { get; set; }
        public string VisitedLocation { get; set; }
        public double Duration { get; set; }
        public int NoOfGifts { get; set; }
        public string ContactMethodOthers { get; set; }
        public string RelationType { get; set; }
        public string Remarks { get; set; }
        public string Subject { get; set; }
        public string KeyOutcomes { get; set; }
        public string NextSteps { get; set; }
        public string AdvocacyTool { get; set; }
        public bool IsPrivate { get; set; }
        public int EngagementCategory { get; set; }
        public int StakeholderCategory { get; set; }
        public int OtherIndustryCategory { get; set; }

        public StakeholderInfo StakeholderInfo { get; set; }

        public UserInfo VisitedByUserInfo { get; set; }
        public UserInfo CreatedUserInfo { get; set; }
        public UserInfo UpdatedUserInfo { get; set; }

    }
}
