using System;

namespace Backend
{
    [PetaPoco.TableName("Users")]
    [PetaPoco.PrimaryKey("id")]
    public partial class User
    {
        [PetaPoco.Column("id")] public Int64 Id { get; set; }
        [PetaPoco.Column("username")] public String Username{ get; set; }
    }

    [PetaPoco.TableName("Tasklists")]
    [PetaPoco.PrimaryKey("id")]
    public partial class Tasklist
    {
        [PetaPoco.Column("id")] public Int64 Id { get; set; }
        [PetaPoco.Column("name")] public String Name { get; set; }
        [PetaPoco.Column("deadline")] public Int32 Deadline { get; set; }
    }

    [PetaPoco.TableName("Tasks")]
    [PetaPoco.PrimaryKey("id")]
    public partial class Task
    {
        [PetaPoco.Column("id")] public Int64 Id { get; set; }
        [PetaPoco.Column("name")] public String Name { get; set; }
        [PetaPoco.Column("descripion")] public String Description { get; set; }
        [PetaPoco.Column("deadline")] public Int32 Deadline { get; set; }
        [PetaPoco.Column("status")] public Int32 Status { get; set; }
        [PetaPoco.Column("owner_tasklist")] public Int64 TasklistId { get; set; }
        [PetaPoco.Column("assignee_user")] public Int64 UserId { get; set; }
    }
}
