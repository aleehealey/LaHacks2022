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
public class LaHacksModelContainer                                               
{                                                                                       
    private SprocRunner _sprocRunner;                                                    
    public LaHacksModelContainer(string connectionString)                 
    {                                                                                   
        _sprocRunner = new SprocRunner(connectionString);
    }                                                                                   
public async Task<List<LaHacksUser>> GetUser_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[GetUser_Id]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksUser> objs = new List<LaHacksUser>();
while (dr.Read())
{
LaHacksUser obj = new LaHacksUser()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],Gmail = (dr["Gmail"] == DBNull.Value) ? null : (string?)dr["Gmail"],
FirstName = (dr["FirstName"] == DBNull.Value) ? null : (string?)dr["FirstName"],
LastName = (dr["LastName"] == DBNull.Value) ? null : (string?)dr["LastName"],
Location = (dr["Location"] == DBNull.Value) ? null : (string?)dr["Location"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InsertUser(string @gmail, string @firstName, string @lastName, string @location, DateTime @createdDate)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@gmail", @gmail));
sqlParameters.Add(new SqlParameter("@firstName", @firstName));
sqlParameters.Add(new SqlParameter("@lastName", @lastName));
sqlParameters.Add(new SqlParameter("@location", @location));
sqlParameters.Add(new SqlParameter("@createdDate", @createdDate));

var result = await _sprocRunner.RunQueryAsync("[InsertUser]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<bool> InvalidateUser_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[InvalidateUser_Id]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksActivity>> GetActivity_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[GetActivity_Id]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksActivity> objs = new List<LaHacksActivity>();
while (dr.Read())
{
LaHacksActivity obj = new LaHacksActivity()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],Name = (dr["Name"] == DBNull.Value) ? null : (string?)dr["Name"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InsertActivity(string @name, DateTime @createdDate)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@name", @name));
sqlParameters.Add(new SqlParameter("@createdDate", @createdDate));

var result = await _sprocRunner.RunQueryAsync("[InsertActivity]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<bool> InvalidateActivity_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[InvalidateActivity_Id]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksActivityUserLink>> GetActivityUserLink_UserId(long @userId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@userId", @userId));

var result = await _sprocRunner.RunQueryAsync("[GetActivityUserLink_UserId]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksActivityUserLink> objs = new List<LaHacksActivityUserLink>();
while (dr.Read())
{
LaHacksActivityUserLink obj = new LaHacksActivityUserLink()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],UserId = (dr["UserId"] == DBNull.Value) ? null : (long?)dr["UserId"],
ActivityId = (dr["ActivityId"] == DBNull.Value) ? null : (long?)dr["ActivityId"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InvalidateActivityUserLink_UserId(long @userId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@userId", @userId));

var result = await _sprocRunner.RunQueryAsync("[InvalidateActivityUserLink_UserId]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksActivityUserLink>> GetActivityUserLink_ActivityId(long @activityId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@activityId", @activityId));

var result = await _sprocRunner.RunQueryAsync("[GetActivityUserLink_ActivityId]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksActivityUserLink> objs = new List<LaHacksActivityUserLink>();
while (dr.Read())
{
LaHacksActivityUserLink obj = new LaHacksActivityUserLink()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],UserId = (dr["UserId"] == DBNull.Value) ? null : (long?)dr["UserId"],
ActivityId = (dr["ActivityId"] == DBNull.Value) ? null : (long?)dr["ActivityId"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InvalidateActivityUserLink_ActivityId(long @activityId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@activityId", @activityId));

var result = await _sprocRunner.RunQueryAsync("[InvalidateActivityUserLink_ActivityId]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksActivityUserLink>> GetActivityUserLink_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[GetActivityUserLink_Id]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksActivityUserLink> objs = new List<LaHacksActivityUserLink>();
while (dr.Read())
{
LaHacksActivityUserLink obj = new LaHacksActivityUserLink()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],UserId = (dr["UserId"] == DBNull.Value) ? null : (long?)dr["UserId"],
ActivityId = (dr["ActivityId"] == DBNull.Value) ? null : (long?)dr["ActivityId"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InsertActivityUserLink(long @userId, long @activityId, DateTime @createdDate)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@userId", @userId));
sqlParameters.Add(new SqlParameter("@activityId", @activityId));
sqlParameters.Add(new SqlParameter("@createdDate", @createdDate));

var result = await _sprocRunner.RunQueryAsync("[InsertActivityUserLink]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<bool> InvalidateActivityUserLink_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[InvalidateActivityUserLink_Id]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksGroup>> GetGroup_UserId(long @userId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@userId", @userId));

var result = await _sprocRunner.RunQueryAsync("[GetGroup_UserId]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksGroup> objs = new List<LaHacksGroup>();
while (dr.Read())
{
LaHacksGroup obj = new LaHacksGroup()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],UserId = (dr["UserId"] == DBNull.Value) ? null : (long?)dr["UserId"],
Location = (dr["Location"] == DBNull.Value) ? null : (string?)dr["Location"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InvalidateGroup_UserId(long @userId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@userId", @userId));

var result = await _sprocRunner.RunQueryAsync("[InvalidateGroup_UserId]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksGroup>> GetGroup_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[GetGroup_Id]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksGroup> objs = new List<LaHacksGroup>();
while (dr.Read())
{
LaHacksGroup obj = new LaHacksGroup()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],UserId = (dr["UserId"] == DBNull.Value) ? null : (long?)dr["UserId"],
Location = (dr["Location"] == DBNull.Value) ? null : (string?)dr["Location"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InsertGroup(long @userId, string @location, DateTime @createdDate)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@userId", @userId));
sqlParameters.Add(new SqlParameter("@location", @location));
sqlParameters.Add(new SqlParameter("@createdDate", @createdDate));

var result = await _sprocRunner.RunQueryAsync("[InsertGroup]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<bool> InvalidateGroup_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[InvalidateGroup_Id]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksGroupLinkUser>> GetGroupLinkUser_GroupId(long @groupId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@groupId", @groupId));

var result = await _sprocRunner.RunQueryAsync("[GetGroupLinkUser_GroupId]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksGroupLinkUser> objs = new List<LaHacksGroupLinkUser>();
while (dr.Read())
{
LaHacksGroupLinkUser obj = new LaHacksGroupLinkUser()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],GroupId = (dr["GroupId"] == DBNull.Value) ? null : (long?)dr["GroupId"],
UserId = (dr["UserId"] == DBNull.Value) ? null : (long?)dr["UserId"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InvalidateGroupLinkUser_GroupId(long @groupId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@groupId", @groupId));

var result = await _sprocRunner.RunQueryAsync("[InvalidateGroupLinkUser_GroupId]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksGroupLinkUser>> GetGroupLinkUser_UserId(long @userId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@userId", @userId));

var result = await _sprocRunner.RunQueryAsync("[GetGroupLinkUser_UserId]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksGroupLinkUser> objs = new List<LaHacksGroupLinkUser>();
while (dr.Read())
{
LaHacksGroupLinkUser obj = new LaHacksGroupLinkUser()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],GroupId = (dr["GroupId"] == DBNull.Value) ? null : (long?)dr["GroupId"],
UserId = (dr["UserId"] == DBNull.Value) ? null : (long?)dr["UserId"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InvalidateGroupLinkUser_UserId(long @userId)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@userId", @userId));

var result = await _sprocRunner.RunQueryAsync("[InvalidateGroupLinkUser_UserId]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<List<LaHacksGroupLinkUser>> GetGroupLinkUser_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[GetGroupLinkUser_Id]", sqlParameters.ToArray(), (dr) =>
{
List<LaHacksGroupLinkUser> objs = new List<LaHacksGroupLinkUser>();
while (dr.Read())
{
LaHacksGroupLinkUser obj = new LaHacksGroupLinkUser()
{
Id = (dr["Id"] == DBNull.Value) ? null : (long?)dr["Id"],GroupId = (dr["GroupId"] == DBNull.Value) ? null : (long?)dr["GroupId"],
UserId = (dr["UserId"] == DBNull.Value) ? null : (long?)dr["UserId"],
IsValid = (dr["IsValid"] == DBNull.Value) ? null : (bool?)dr["IsValid"],
CreatedDate = (dr["CreatedDate"] == DBNull.Value) ? null : (DateTime?)dr["CreatedDate"],

};
objs.Add(obj);
}
return objs;
}
);
return result;
}
public async Task<bool> InsertGroupLinkUser(long @groupId, long @userId, DateTime @createdDate)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@groupId", @groupId));
sqlParameters.Add(new SqlParameter("@userId", @userId));
sqlParameters.Add(new SqlParameter("@createdDate", @createdDate));

var result = await _sprocRunner.RunQueryAsync("[InsertGroupLinkUser]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
public async Task<bool> InvalidateGroupLinkUser_Id(long @id)
{
var sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("@id", @id));

var result = await _sprocRunner.RunQueryAsync("[InvalidateGroupLinkUser_Id]", sqlParameters.ToArray(), (dr) =>
true
);
return result;
}
}                                                                                       
public class SprocRunner                                                                                          
{                                                                                                                 
    private SqlConnection _connection;                                                                            
    public SprocRunner(string connectionString)                                                                   
    {                                                                                                             
        _connection = new SqlConnection(connectionString);                                                        
        _connection.Open();                                                                                       
    }                                                                                                             
                                                                                                                  
    public async Task<T> RunQueryAsync<T>(string sprocName, SqlParameter[] sqlParams, Func<SqlDataReader, T> func)
    {                                                                                                             
        var command = new SqlCommand(sprocName, _connection);                                                     
        command.CommandType = System.Data.CommandType.StoredProcedure;                                            
        foreach (var sqlParam in sqlParams)                                                                       
        {                                                                                                         
            command.Parameters.Add(sqlParam);                                                                     
        }                                                                                                         
        var reader = await command.ExecuteReaderAsync();                                                          
        var result = func(reader);                                                                                
        reader.Close();                                                                                           
        return result;                                                                                            
    }                                                                                                             
                                                                                                                  
    public T RunQuery<T>(string sprocName, SqlParameter[] sqlParams, Func<SqlDataReader, T> func)                 
    {                                                                                                             
        var command = new SqlCommand(sprocName, _connection);                                                     
        command.CommandType = System.Data.CommandType.StoredProcedure;                                            
        foreach (var sqlParam in sqlParams)                                                                       
        {                                                                                                         
            command.Parameters.Add(sqlParam);                                                                     
        }                                                                                                         
        var reader = command.ExecuteReader();                                                                     
        var result = func(reader);                                                                                
        reader.Close();                                                                                           
        return result;                                                                                            
    }                                                                                                             
                                                                                                                  
    ~SprocRunner()                                                                                                
    {                                                                                                             
        _connection.Close();                                                                                      
    }                                                                                                             
}             