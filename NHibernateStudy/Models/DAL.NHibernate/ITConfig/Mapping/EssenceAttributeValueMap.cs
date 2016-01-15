using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class EssenceAttributeValueMap: ClassMapping<EssenceAttributeValue>
    {
        public EssenceAttributeValueMap()
        {
            Table("Essence_Attribute_Value");
            Lazy(false);
            BatchSize(50);
            Id(a => a.EssenceAttributeValueId, m => m.Column("Essence_Attribute_Value_Id"));
            Property(a => a.Value, m => m.Column("Value"));
            //ManyToOne(a => a.Essence, m => m.Column("Essence_Id"));
            ManyToOne(a => a.Attribute, m => m.Column("Attribute_Id"));
            Property(a => a.Comment, m => m.Column("Comment"));
            Component(a => a.UpdateInfo, mapper =>
            {
                mapper.Property(info => info.UpdatedDate, m => m.Column("Updated_Date"));
                mapper.Property(info => info.UpdatedUserName, m => m.Column("Updated_User_Name"));
            });
            Component(a => a.DateInfo, mapper =>
            {
                mapper.Property(info => info.DateBeg, m => m.Column("Date_Beg"));
                mapper.Property(info => info.DateEnd, m => m.Column("Date_End"));
            });
        }
    }
}