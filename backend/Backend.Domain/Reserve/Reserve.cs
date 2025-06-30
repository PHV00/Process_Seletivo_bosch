using System.Security.AccessControl;

namespace Backend.Domain
{
    public class Reserve : BaseEntity<int>
    {
        public string ResourceType;

        public string ResponsibleName;

        public DateTime DateTimeStart;

        public int HourDuration;
    }
}