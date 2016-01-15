using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class ReferenceTypeMap: ClassMapping<ReferenceType>
    {
        public ReferenceTypeMap()
        {
            Table("Reference_Type");
            Id(a => a.ReferenceTypeId, m=>m.Column("Reference_Type_Id"));
            Property(a => a.Comment, m => m.Column("Comment"));
            Component(a => a.UpdateInfo, mapper =>
            {
                mapper.Property(info => info.UpdatedDate, m => m.Column("Updated_Date"));
                mapper.Property(info => info.UpdatedUserName, m => m.Column("Updated_User_Name"));
            });
            Property(a => a.ReferenceTypeCode, m => m.Column("Reference_Type_Code"));
            Property(a => a.ReferenceTypeNameLine, m => m.Column("Reference_Type_Name_Line"));
            Property(a => a.ReferenceTypeNameReverse, m => m.Column("Reference_Type_Name_Reverse"));
            Property(a => a.OnlyOneLimitLine, m => m.Column("Only_One_Limit_Line"));
            Property(a => a.OnlyOneLimitReverse, m => m.Column("Only_One_Limit_Reverse"));
        }
    }
}