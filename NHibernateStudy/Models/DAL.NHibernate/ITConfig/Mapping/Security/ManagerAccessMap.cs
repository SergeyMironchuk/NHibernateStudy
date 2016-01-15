using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping.Security
{
    public class ManagerAccessMap: ClassMapping<ManagerAccess>
    {
        public ManagerAccessMap()
        {
            Table("SECURITY.Manager_Access");
            Id(roleAccess => roleAccess.Id, mapper =>
            {
                mapper.Column("Id");
                mapper.Generator(new IdentityGeneratorDef());
            });
            ManyToOne(roleAccess => roleAccess.Manager, mapper => mapper.Column("Manager_ID"));
            ManyToOne(roleAccess => roleAccess.EssenceType, mapper => mapper.Column("Essence_Type_ID"));
            ManyToOne(roleAccess => roleAccess.Attribute, mapper => mapper.Column("Attribute_ID"));
            Component(roleAccess => roleAccess.Permission, mapper =>
            {
                mapper.Property(permission => permission.AllowRead, propertyMapper => propertyMapper.Column("Allow_Read"));
                mapper.Property(permission => permission.AllowWrite, propertyMapper => propertyMapper.Column("Allow_Write"));
            });
        }
    }
}