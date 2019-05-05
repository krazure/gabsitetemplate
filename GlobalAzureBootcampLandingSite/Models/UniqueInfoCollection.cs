using System.Collections.ObjectModel;

namespace GlobalAzureBootcampLandingSite.Models
{
    public class UniqueInfoCollection<TItem> : KeyedCollection<string, TItem>
        where TItem : class, IUniqueInfo
    {
        protected override string GetKeyForItem(TItem item) => item.Id;
    }
}