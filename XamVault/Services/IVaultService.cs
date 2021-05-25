using System.Collections.ObjectModel;
using XamVault.Models;

namespace XamVault.Services
{
    public interface IVaultService
    {
        ObservableCollection<VaultItem> Get();
    }
}
