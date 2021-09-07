
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Alaca.Core.Entities
{
    public class IEntity: IBaseEntity
    {
        public DateTime? CreateDate { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateUser { get; set; }
    }
    public interface IBaseEntity
    {
        public DateTime? CreateDate { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateUser { get; set; }
    }
}
