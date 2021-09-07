using Alaca.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Menu : MenuBase
    {
        public virtual Menu MenuItem { get; set; }
        public virtual HashSet<Menu> Menus { get; set; } = new();
        public virtual HashSet<UserRoleMenu> UserRoleMenu { get; set; }
    }

    public partial class Menu
    {
        private bool _IsExpented;
        [NotMapped]
        [System.ComponentModel.DefaultValue(true)]
        public bool IsExpented
        {
            get
            {
                return _IsExpented;
            }
            set
            {
                _IsExpented = value;
            }
        }
    }
}
