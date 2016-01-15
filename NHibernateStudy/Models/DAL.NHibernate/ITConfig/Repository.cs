using System.Linq;
using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig;
using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security;
using NHibernate;
using NHibernate.Linq;
using Attribute = ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Attribute;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig
{
    public class Repository: IRepository
    {
        private ISession _session;

        public IQueryable<Essence> GetEssences()
        {
            _session = NHibernateHelper.GetCurrentSession();
            return _session.Query<Essence>()
                //.Fetch(e => e.Type).ThenFetch(t => t.EssenceTypeGroup)
                //.Fetch(e => e.Type).ThenFetch(t => t.Status)
                //.Fetch(e => e.Status)
                ;
        }

        public IQueryable<Attribute> GetAttributes()
        {
            _session = NHibernateHelper.GetCurrentSession();
            return _session.Query<Attribute>();
        }

        public IQueryable<Manager> GetManagers()
        {
            _session = NHibernateHelper.GetCurrentSession();
            return _session.Query<Manager>();
        }
    }
}