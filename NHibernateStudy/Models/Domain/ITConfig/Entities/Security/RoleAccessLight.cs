namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Право доступа для роли
    /// </summary>
    public class RoleAccessLight
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public virtual long Id { get; set; }
        /// <summary>
        /// Роль
        /// </summary>
        public virtual Role Role { get; set; }
        /// <summary>
        /// Доступ определен для элементов заданного Типа (если <see cref="AttributeId"/>==null).
        /// Или для значения Атрибута в заданном типе элемента (если <see cref="AttributeId"/>!=null).
        /// </summary>
        public virtual int? EssenceTypeId { get; set; }
        /// <summary>
        /// Доступ определен для значения Атрибута в любом типе элемента (если <see cref="EssenceTypeId"/>==null).
        /// Или для значения Атрибута в заданном типе элемента (если <see cref="EssenceTypeId"/>==null).
        /// </summary>
        public virtual int? AttributeId { get; set; }
        /// <summary>
        /// Право доступа
        /// </summary>
        public virtual Permission Permission { get; set; }
    }
}