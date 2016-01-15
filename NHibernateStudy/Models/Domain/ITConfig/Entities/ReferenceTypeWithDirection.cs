using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Тип связи с указанием направления
    /// </summary>
    [DataContract]
    public class ReferenceTypeWithDirection: ReferenceType
    {
        /// <summary>
        /// Направление связи
        /// </summary>
        [DataMember]
        public ReferenceDirection Direction { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ReferenceTypeWithDirection() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="referenceType"></param>
        /// <param name="direction"></param>
        public ReferenceTypeWithDirection(ReferenceType referenceType, ReferenceDirection direction)
        {
            Direction = direction;
            // ReSharper disable DoNotCallOverridableMethodsInConstructor
            ReferenceTypeId = referenceType.ReferenceTypeId;
            ReferenceTypeNameLine = referenceType.ReferenceTypeNameLine;
            ReferenceTypeNameReverse = referenceType.ReferenceTypeNameReverse;
            ReferenceTypeCode = referenceType.ReferenceTypeCode;
            Comment = referenceType.Comment;
            UpdateInfo = referenceType.UpdateInfo;
            // ReSharper restore DoNotCallOverridableMethodsInConstructor

        }

        /// <summary>
        /// Идентификатор типа вязи с направлением связи
        /// </summary>
        public string ReferenceTypeIdWithDirection
        {
            get { return Direction == ReferenceDirection.AsChild ? ReferenceTypeIdForChild : ReferenceTypeIdForOwner; }
            set
            {
                var dataArray = value.Split('_');
                ReferenceTypeId = int.Parse(dataArray[0]);
                Direction = (ReferenceDirection)int.Parse(dataArray[1]);
            }
        }

        /// <summary>
        /// Имя типа связи с учетом направления
        /// </summary>
        public string ReferenceTypeName
        {
            get
            {
                switch (Direction)
                {
                    case ReferenceDirection.AsChild:
                        return ReferenceTypeNameReverse;
                    case ReferenceDirection.AsOwner:
                        return ReferenceTypeNameLine;
                }
                return null;
            }
        }

        /// <summary>
        /// Имя типа связи с учетом направления, содержащее в том числе код
        /// </summary>
        public string ReferenceNameWithCode
        {
            get
            {
                return string.Format("{1} ({2}{0})"
                    , ReferenceTypeIdWithDirection.EndsWith("_0") ? "a" : "b"
                    , ReferenceTypeName
                    , ReferenceTypeCode); }
        }

        public override bool Equals(object obj)
        {
            var referenceType = obj as ReferenceTypeWithDirection;
            if (referenceType == null) return false;
            return ReferenceTypeIdWithDirection == referenceType.ReferenceTypeIdWithDirection;
        }

        public override int GetHashCode()
        {
            return ReferenceTypeIdWithDirection.GetHashCode();
        }

    }
}