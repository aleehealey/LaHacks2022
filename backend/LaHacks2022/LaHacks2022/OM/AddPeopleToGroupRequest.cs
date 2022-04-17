namespace LaHacks2022.OM
{
    public class AddPeopleToGroupRequest
    {
        public string GroupCode { get; set; }
        public List<long> UserIds { get; set; }
    }
}
