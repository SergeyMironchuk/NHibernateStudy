using System;
using System.Collections.Generic;
using System.Web;
using ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping;
using ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping.Security;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig
{
    public static class NHibernateHelper
    {
        private const string CurrentSessionKey = "nhibernate.current_session";
        private static ISessionFactory _sessionFactory;
        private static readonly object LockObject = new object();

        static NHibernateHelper()
        {
            InitNHibernate();
        }

        private static void InitNHibernate()
        {
            if (_sessionFactory == null)
            {
                lock (LockObject)
                {
                    // Создание NHibernate-конфигурации приложения на основании описаний из web.config.
                    // После этого вызова, в том числе, из сборки будут извлечены настройки маппинга, 
                    // заданные в xml-файлах.
                    var configure = new Configuration().Configure();

                    // Настройка маппинга, созданного при помощи mapping-by-code
                    var mapper = new ModelMapper();
                    mapper.AddMappings(new List<Type>
                    {
                        // Перечень классов, описывающих маппинг
                        typeof (AttributeMap),
                        typeof (EssenceMap),
                        typeof (EssenceAttributeValueMap),
                        typeof (EssenceTypeMap),
                        typeof (EssenceTypeAttributeMap),
                        typeof (ObjectStatusMap),
                        typeof (ReferenceTypeMap),
                        typeof (ReferenceMap),
                        typeof (EssenceTypeReferenceTypeMap),
                        typeof (EssenceTypeGroupMap),
                        typeof (RoleMap),
                        typeof (ManagerMap),
                        typeof (ManagerBaseMap),
                        typeof (RoleAccessMap),
                        typeof (RoleAccessLightMap),
                        typeof (ManagerAccessMap),
                        typeof (ManagerAccessLightMap),
                    });
                    // Добавление маппинга, созданного при помощи mapping-by-code, 
                    // в NHibernate-конфигурацию приложения
                    configure.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), null);
                    //configure.LinqToHqlGeneratorsRegistry<CompareValuesGeneratorsRegistry>();
                    //configure.LinqToHqlGeneratorsRegistry<InGeneratorRegistry>();
                    configure.DataBaseIntegration(x =>
                    {
                        x.LogSqlInConsole = true;
                        x.LogFormattedSql = true;
                    });

                    _sessionFactory = configure.BuildSessionFactory();
                }
            }
        }

        public static ISession GetCurrentSession()
        {
            InitNHibernate();
            var context = HttpContext.Current;
            ISession currentSession = null;
            if (context != null) currentSession = context.Items[CurrentSessionKey] as ISession;

            if (currentSession == null)
            {
                currentSession = _sessionFactory.OpenSession();
                if (context != null) context.Items[CurrentSessionKey] = currentSession;
            }

            if (!currentSession.IsOpen)
            {
                currentSession = _sessionFactory.OpenSession();
                if (context != null) context.Items[CurrentSessionKey] = currentSession;
            }

            return currentSession;
        }

        public static void CloseSession()
        {
            InitNHibernate();
            var context = HttpContext.Current;
            ISession currentSession = null;
            if (context != null) currentSession = context.Items[CurrentSessionKey] as ISession;

            if (currentSession == null)
            {
                // No current session
                return;
            }

            if (currentSession.IsOpen)
            {
                currentSession.Close();
            }
            context.Items.Remove(CurrentSessionKey);
        }

        public static void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }
    }
}
