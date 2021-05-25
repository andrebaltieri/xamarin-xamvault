using System;
using XamVault.Utils;

namespace XamVault.Models
{
    public class VaultItem
    {
        public VaultItem(string key, string value = "")
        {
            Id = Guid.NewGuid();
            Key = key;
            Value = string.IsNullOrEmpty(value) ? PasswordGenerator.Generate() : value;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public void Update(string value)
        {
            Value = value;
            UpdatedAt = DateTime.Now;
        }
    }
}