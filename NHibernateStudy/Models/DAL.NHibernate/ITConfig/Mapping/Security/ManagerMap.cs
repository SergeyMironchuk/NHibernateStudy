using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping.Security
{
    public class ManagerMap : JoinedSubclassMapping<Manager>
    {
        public ManagerMap()
        {
            Table("SECURITY.Authority");
            Key(k => k.Column("Manager_ID"));
            Property(a => a.LoginName, m => m.Column("Login_Name"));
            Bag(role => role.RolesForManager,
                mapper =>
                {
                    mapper.Key(k => k.Column("Manager_Id"));
                    mapper.Table("SECURITY.Role_Manager");
                },
                relation => relation.ManyToMany(mapper => mapper.Column("Role_Id")));
            //SqlInsert("insert into SECURITY.Manager (Real_Name, Manager_ID) values (?, ?)");
            //SqlUpdate("update SECURITY.Manager set Real_Name=? where Manager_ID=?");
            //SqlDelete("delete SECURITY.Manager Manager_ID=?");
        }
    }
}