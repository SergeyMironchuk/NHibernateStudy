using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping.Security
{
    public class RoleMap : ClassMapping<Role>
    {
        public RoleMap()
        {
            Table("SECURITY.Role");
            Id(role => role.RoleId, mapper => mapper.Column("Role_Id"));
            Property(role => role.RoleName, mapper => mapper.Column("Role_Name"));
            Bag(role => role.ManagersInRole,
                mapper =>
                {
                    mapper.Key(k => k.Column("Role_Id"));
                    mapper.Table("SECURITY.Role_Manager");
                    //mapper.SqlInsert("insert into SECURITY.Role_Manager (Role_ID, Manager_ID) values (?, ?)");
                    //mapper.SqlDelete("delete SECURITY.Role_Manager where Role_ID=? and Manager_ID=?");
                },
                relation => relation.ManyToMany(mapper => mapper.Column("Manager_Id")));
            //SqlInsert("insert into SECURITY.Role (Role_Name, Role_Id) values (?,?)");
            //SqlUpdate("update SECURITY.Role set Role_NAME = ? where Role_Id=?");
            //SqlDelete("delete SECURITY.Role where Role_Id=?");
        }
    }
}