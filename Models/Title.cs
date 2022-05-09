namespace GraphQl_HotChochlete.Models
{
    public class Title : BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<StakeholderPosition> StakeholderPosition { get; set; }
        public UserInfo CreatedUserInfo { get; set; }
        public UserInfo UpdatedUserInfo { get; set; }
    }
}
