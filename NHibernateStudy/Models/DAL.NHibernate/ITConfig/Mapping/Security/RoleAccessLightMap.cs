using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping.Security
{
    public class RoleAccessLightMap: ClassMapping<RoleAccessLight>
    {
        public RoleAccessLightMap()
        {
            Table("SECURITY.Role_Access");
            Id(roleAccess => roleAccess.Id, mapper => mapper.Column("Id"));
            ManyToOne(roleAccess => roleAccess.Role, mapper => mapper.Column("Role_ID"));
            Property(roleAccess => roleAccess.EssenceTypeId, mapper => mapper.Column("Essence_Type_ID"));
            Property(roleAccess => roleAccess.AttributeId, mapper => mapper.Column("Attribute_ID"));
            Component(roleAccess => roleAccess.Permission, mapper =>
            {
                mapper.Property(permission => permission.AllowRead, propertyMapper => propertyMapper.Column("Allow_Read"));
                mapper.Property(permission => permission.AllowWrite, propertyMapper => propertyMapper.Column("Allow_Write"));
            });
        }
    }
}