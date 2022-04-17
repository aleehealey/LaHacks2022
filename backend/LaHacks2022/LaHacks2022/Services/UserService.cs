using LaHacks2022.OM;
using Model;

namespace LaHacks2022.Services
{
    public class UserService
    {

        private LaHacksModelContainer _model;
        public UserService(LaHacksModelContainer model)
        {
            _model = model;
        }


        // get user (send token)
        // return token with google token in it as well as userId
        public async Task<User> GetUser(long userId)
        {
            var users = await _model.GetUser_Id(userId);
            if (users == null || users.Count <= 0) throw new Exception("User doens't exist");

            var user = users.First();

            var groupsUserOwns = await _model.GetGroup_UserId(userId);
            var groupsUserInLinks = await _model.GetGroupLinkUser_UserId(userId);
            
            var groups = await GetAllGroups(groupsUserInLinks);

            return new User()
            {
                GroupsUserOwns = groupsUserOwns,
                GroupsUserIn = groups,
            };

        }

        public async Task<List<LaHacksGroup>> GetAllGroups(List<LaHacksGroupLinkUser> links)
        {
            var tasks = new List<Task<List<LaHacksGroup>>>();
            foreach (var link in links)
            {
                var task = _model.GetGroup_Id((long)link.GroupId);
                tasks.Add(task);
            }
            var results = await Task.WhenAll(tasks.ToArray());
            var groups = new List<LaHacksGroup>();
            foreach (var groupsList in results)
            {
                if (groupsList.Count > 0)
                {
                    groups.AddRange(groupsList);
                }
            }
            return groups;
        }

        // add activities
        public async Task<bool> AddActivities(long userId, List<long> activityIds)
        {
            var tasks = new List<Task>();
            foreach (var activity in activityIds)
            {
                var task = _model.InsertActivityUserLink(userId, activity, DateTime.Now);
                tasks.Add(task);
            }
            await Task.WhenAll(tasks.ToArray());
            return true;
        }

        // Create group
        public async Task<bool> CreateGroup(long userId)
        {
            await _model.InsertGroup(userId, "", GenerateCode(), DateTime.Now);
            return true;
        }

        public string GenerateCode()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max).ToString();
        }

        // add people to group
        public async Task<bool> AddPeopleToGroup(string groupCode, List<long> userIds)
        {
            var groupId = await GetGroupIdByCode(groupCode);
            var tasks = new List<Task>();
            foreach (var userId in userIds)
            {
                var task = _model.InsertGroupLinkUser(groupId, userId, DateTime.Now);
                tasks.Add(task);
            }
            await Task.WhenAll(tasks.ToArray());
            return true;
        }

        public async Task<long> GetGroupIdByCode(string code)
        {
            var groupList = await _model.GetGroup_Code(code);
            if (groupList == null || groupList.Count == 0) throw new Exception("No group exists");

            return (long)groupList.First().Id;
        }

        // get activity recomendations - for group
        public async Task<bool> ScheduleEvents(long groupId)
        {
            return null;
        }
    }
}
