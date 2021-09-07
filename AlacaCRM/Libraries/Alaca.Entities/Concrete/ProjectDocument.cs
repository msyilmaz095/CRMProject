using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ProjectDocument : IEntity
    {
        public Guid ProjectDocumentId { get; set; }
        public string ProjectDocumentName { get; set; }
        public string DocumentType { get; set; }
        public float? Size { get; set; }
        public string Description { get; set; }
    }
}
