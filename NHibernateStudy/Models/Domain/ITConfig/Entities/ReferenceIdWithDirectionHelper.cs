using System;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    public static class ReferenceIdWithDirectionHelper
    {
        public static int GetReferenceTypeId(this string direction)
        {
            int result = 0;
            var directionArray = direction.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            if (directionArray.Length < 2) return 0;
            int.TryParse(directionArray[0], out result);
            return result;
        }

        public static ReferenceDirection GetReferenceDirection(this string direction)
        {
            ReferenceDirection result;
            var directionArray = direction.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            if (directionArray.Length < 2) return ReferenceDirection.Unknown;
            return Enum.TryParse(directionArray[1], out result) ? result : ReferenceDirection.Unknown;
        }
    }
}