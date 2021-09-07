using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Configuration:IEntity
    {
        public string ConfigurationCode { get; set; }
        public string ConfigurationValue { get; set; }
        public string ConfigurationDescription { get; set; }
    }
}
