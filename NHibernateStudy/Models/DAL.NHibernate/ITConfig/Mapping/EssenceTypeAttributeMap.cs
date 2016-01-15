using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class EssenceTypeAttributeMap: ClassMapping<EssenceTypeAttribute>
    {
        public EssenceTypeAttributeMap()
        {
            Table("Essence_Type_Attribute");
            Id(a => a.EssenceTypeAttributeId, m => m.Column("Essence_Type_Attribute_Id"));
            Property(a => a.Comment, m => m.Column("Comment"));
            Property(a => a.IsMandatory, m => m.Column("Is_Mandatory"));
            Component(a => a.UpdateInfo, mapper =>
            {
                mapper.Property(info => info.UpdatedDate, m => m.Column("Updated_Date"));
                mapper.Property(info => info.UpdatedUserName, m => m.Column("Updated_User_Name"));
            });
            ManyToOne(a => a.Attribute, m => m.Column("Attribute_Id"));
            ManyToOne(a => a.EssenceType, m => m.Column("Essence_Type_Id"));
        }
    }
}