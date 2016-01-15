using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class ReferenceMap: ClassMapping<Reference>
    {
        public ReferenceMap()
        {
            Table("Reference");
            Id(a => a.ReferenceId, m => m.Column("Reference_Id"));
            Property(a => a.Comment, m => m.Column("Comment"));
            ManyToOne(a => a.Status, m => m.Column("Object_Status_Id"));
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
            ManyToOne(a => a.ReferenceType, m => m.Column("Reference_Type_Id"));
            ManyToOne(a => a.EssenceChild, m => m.Column("Essence_Child_Id"));
            ManyToOne(a => a.EssenceOwner, m => m.Column("Essence_Owner_Id"));
        }
    }
}