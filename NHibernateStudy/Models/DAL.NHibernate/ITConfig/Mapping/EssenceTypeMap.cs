using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class EssenceTypeMap: ClassMapping<EssenceType>
    {
        public EssenceTypeMap()
        {
            Table("Essence_Type");
            Id(a => a.EssenceTypeId, m => m.Column("Essence_Type_Id"));
            Lazy(false);
            BatchSize(50);
            Property(a => a.EssenceTypeCode, m => m.Column("Essence_Type_Code"));
            Property(a => a.EssenceTypeName, m => m.Column("Essence_Type_Name"));
            Property(a => a.Comment, m => m.Column("Comment"));
            Component(a => a.UpdateInfo, mapper =>
            {
                mapper.Property(info => info.UpdatedDate, m => m.Column("Updated_Date"));
                mapper.Property(info => info.UpdatedUserName, m => m.Column("Updated_User_Name"));
            });
            ManyToOne(a => a.Status, m =>
            {
                m.Column("Object_Status_Id");
                //m.Lazy(LazyRelation.NoLazy);
                //m.Fetch(FetchKind.Select);
            });
            ManyToOne(a => a.EssenceTypeGroup, m =>
            {
                m.Column("Essence_Type_Group_Id");
                //m.Lazy(LazyRelation.NoLazy);
                //m.Fetch(FetchKind.Select);
            });
        }
    }
}