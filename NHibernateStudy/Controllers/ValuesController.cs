using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.UI.WebControls;
using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig;
using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;

namespace ATB.RPO.NHibernateStudy.Controllers
{
    public class ValuesController : ApiController
    {
        private static readonly Random Rand = new Random();

        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        protected IRepository Repository { get; set; }

        // GET api/values
        public IEnumerable<Essence> Get()
        {
            var skip = Rand.Next(200);
            return Repository.GetEssences()
                .Skip(skip)
                .Take(10)
                .ToList()
                .Select(e => e.CloneWithoutReferences())
                ;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}