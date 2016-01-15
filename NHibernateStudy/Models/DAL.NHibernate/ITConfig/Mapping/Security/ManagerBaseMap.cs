using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping.Security
{
    public class ManagerBaseMap: ClassMapping<ManagerBase>
    {
        public ManagerBaseMap()
        {
            Table("SECURITY.Manager");
            Id(authority => authority.ManagerId, mapper => mapper.Column("Manager_ID"));
            Property(authority => authority.RealName, mapper => mapper.Column("Real_Name"));
            //SqlInsert("insert into SECURITY.Authority (Login_Name, Manager_ID) values (?, ?)");
            //SqlUpdate("update SECURITY.Authority set Login_Name=? where Manager_ID=?");
            //SqlDelete("delete SECURITY.Authority where Manager_ID=?");
        }
    }
}