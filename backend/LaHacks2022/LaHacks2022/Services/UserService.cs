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
        public async Task<LaHacksUser> GetUser(long userId)
        {
            var user = await _model.GetUser_Id(userId);
            if (user == null || user.Count <= 0) throw new Exception("User doens't exist");
            return user.First();
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
            await _model.InsertGroup(userId, "", DateTime.Now);
            return true;
        }

        // add people to group
        public async Task<bool> AddPeopleToGroup(long groupId, List<long> userIds)
        {
            var tasks = new List<Task>();
            foreach (var userId in userIds)
            {
                var task = _model.InsertGroupLinkUser(groupId, userId, DateTime.Now);
                tasks.Add(task);
            }
            await Task.WhenAll(tasks.ToArray());
            return true;
        }

        // get activity recomendations - for group
        public async Task<bool> ScheduleEvents(long groupId)
        {
            return null;
        }
    }
}
