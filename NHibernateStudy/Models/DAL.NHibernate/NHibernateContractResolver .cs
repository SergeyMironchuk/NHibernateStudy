using System;
using Newtonsoft.Json.Serialization;
using NHibernate.Proxy;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate

{
    public class NHibernateContractResolver : DefaultContractResolver
    {
        protected override JsonContract CreateContract(Type objectType)
        {
            if (typeof(INHibernateProxy).IsAssignableFrom(objectType))
                return base.CreateContract(objectType.BaseType);

            return base.CreateContract(objectType);
        }
    }
}