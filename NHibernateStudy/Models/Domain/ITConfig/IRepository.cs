using System.Linq;
using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig
{
    public interface IRepository
    {
        IQueryable<Essence> GetEssences();
        IQueryable<Attribute> GetAttributes();
        IQueryable<Manager> GetManagers();
    }
}