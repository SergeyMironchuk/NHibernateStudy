namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Право доступа
    /// </summary>
    public class Permission
    {
        private bool? _allowRead;

        /// <summary>
        /// Доступ на чтение.
        ///     null - не определен
        ///     true - разрешен
        ///     false - запрещен
        /// </summary>
        public virtual bool? AllowRead
        {
            get
            {
                if (_allowRead == null && AllowWrite != null && AllowWrite.Value) return true;
                return _allowRead;
            }
            set
            {
                _allowRead = value;
            }
        }
        /// <summary>
        /// Доступ на запись.
        ///     null - не определен
        ///     true - разрешен
        ///     false - запрещен
        /// </summary>
        public virtual bool? AllowWrite { get; set; }

        public override string ToString()
        {
            var result = "na";
            if (_allowRead != null || AllowWrite != null)
                result = string.Format("{0} {1}"
                    , _allowRead == null ? "" : (_allowRead.Value ? "Ra" : "Rd")
                    , AllowWrite == null ? "" : (AllowWrite.Value ? "Wa" : "Wd")
                    ).Trim();
            return result;
        }
    }
}