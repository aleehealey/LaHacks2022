using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class LaHacksUser
    {
        public long? Id { get; set; }
        public string? Gmail { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Location { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
    public class LaHacksActivity
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
    public class LaHacksActivityUserLink
    {
        public long? Id { get; set; }
        public long? UserId { get; set; }
        public long? ActivityId { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
    public class LaHacksGroup
    {
        public long? Id { get; set; }
        public long? UserId { get; set; }
        public string? Location { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
    public class LaHacksGroupLinkUser
    {
        public long? Id { get; set; }
        public long? GroupId { get; set; }
        public long? UserId { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
