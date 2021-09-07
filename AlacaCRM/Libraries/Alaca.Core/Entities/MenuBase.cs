using Alaca.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Alaca.Core.Entities
{
    public partial class MenuBase : IEntity
    {
        public Guid MenuId { get; set; }
        public string Icon { get; set; }
        public Guid? MainMenuId { get; set; }
        public string MenuName { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }

}
