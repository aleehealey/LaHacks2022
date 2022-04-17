using Model;

namespace LaHacks2022.OM
{
    public class User : LaHacksUser
    {
        public List<LaHacksGroup> GroupsUserOwns { get; set; }
        public List<LaHacksGroup> GroupsUserIn { get; set; }
    }
}
