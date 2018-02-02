using System;

namespace ProjectManager.Data
{
    public class BaseEntity
    {

        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string IPAddress { get; set; }

    }
}
