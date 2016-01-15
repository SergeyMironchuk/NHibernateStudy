using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class AttributeMap: ClassMapping<Attribute>
    {
        public AttributeMap()
        {
            Table("Attributes");
            Lazy(false);
            Id(a => a.AttributeId, m => m.Column("Attribute_Id"));
            Property(a => a.AttributeCode, m => m.Column("Attribute_Code"));
            Property(a => a.AttributeName, m => m.Column("Attribute_Name"));
            Property(a => a.Comment, m => m.Column("Comment"));
            Property(a => a.CheckMask, m => m.Column("Check_Mask"));
            Component<UpdateInfo>(a => a.UpdateInfo, mapper =>
            {
                mapper.Property(info => info.UpdatedDate, m => m.Column("Updated_Date"));
                mapper.Property(info => info.UpdatedUserName, m => m.Column("Updated_User_Name"));
            });
            Component<DateInfo>(a => a.DateInfo, mapper =>
            {
                mapper.Property(info => info.DateBeg, m => m.Column("Date_Beg"));
                mapper.Property(info => info.DateEnd, m => m.Column("Date_End"));
            });
        }
    }
}