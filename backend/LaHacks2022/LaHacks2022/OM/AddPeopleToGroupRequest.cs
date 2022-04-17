namespace LaHacks2022.OM
{
    public class AddPeopleToGroupRequest
    {
        public long GroupId { get; set; }
        public List<long> UserIds { get; set; }
    }
}
