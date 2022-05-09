namespace GraphQl_HotChochlete.Models
{
    public class BusinessCard : BaseModel
    {
        public int Id { get; set; }
        public string StakeholderInfoId { get; set; }
        public string Uri { get; set; }
        public string FileName { get; set; }
        public bool IsPrivate { get; set; }

        public StakeholderInfo StakeholderInfo { get; set; }
        public UserInfo CreatedUserInfo { get; set; }
        public UserInfo UpdatedUserInfo { get; set; }
    }
}
