using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class UserLoginInfo:IEntity
    {
        public Guid LogId { get; set; }
        public Guid? UserId { get; set; }
        public string Ipaddress { get; set; }
        public string UserAgent { get; set; }
        public string Languages { get; set; }
    }
}
