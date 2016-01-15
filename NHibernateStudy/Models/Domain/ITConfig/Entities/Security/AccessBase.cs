namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Класс права доступа
    /// </summary>
    public class AccessBase
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Доступ определен для элементов заданного Типа (если <see cref="Attribute"/>==null).
        /// Или для значения Атрибута в заданном Типе элемента (если <see cref="Attribute"/>!=null).
        /// </summary>
        public virtual EssenceType EssenceType { get; set; }

        /// <summary>
        /// Доступ определен для значения Атрибута в любом типе элемента (если <see cref="EssenceType"/>==null).
        /// Или для значения Атрибута в заданном Типе элемента (если <see cref="EssenceType"/>==null).
        /// </summary>
        public virtual Attribute Attribute { get; set; }

        private Permission _permission;
        /// <summary>
        /// Право доступа
        /// </summary>
        public virtual Permission Permission {
            get { return _permission ?? new Permission(); }
            set { _permission = value; }
        }
    }
}