using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class EssenceTypeGroupMap: ClassMapping<EssenceTypeGroup>
    {
        public EssenceTypeGroupMap()
        {
            Table("Essence_Type_Group");
            Id(a => a.GroupId, m => m.Column("Essence_Type_Group_Id"));
            Lazy(false);
            BatchSize(50);
            Property(a => a.GroupCode, m => m.Column("Essence_Type_Group_Code"));
            Property(a => a.GroupName, m => m.Column("Essence_Type_Group_Name"));
            Property(a => a.Comment, m => m.Column("Comment"));
            Component(a => a.UpdateInfo, mapper =>
            {
                mapper.Property(info => info.UpdatedDate, m => m.Column("Updated_Date"));
                mapper.Property(info => info.UpdatedUserName, m => m.Column("Updated_User_Name"));
            });
        }         
    }
}