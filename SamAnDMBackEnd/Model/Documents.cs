﻿using System.Text.Json.Serialization;

namespace SamAnDMBackEnd.Model
{
    public class Documents
    {
        public int DocumentId { get; set; }
        public int OwnerUserId { get; set; }
        public bool IsProtected { get; set; }
        public string Address { get; set; }
        public string TypeDocument { get; set; }
        public string DocumentName { get; set; }
        public long DocumentSize { get; set; }
        public byte[] DocumentContent { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<FamilyGroup> FamilyGroups { get; set; }

        [JsonIgnore]
        public ICollection<DocumentsHistorics> DocumentsHistorics { get; set; }
    }
}
