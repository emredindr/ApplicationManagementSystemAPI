using System.ComponentModel.DataAnnotations;

namespace ApplicationManagementSystem.Core.Dto.Request
{
    [Serializable]
    public class ListResultReguest : LimitedResultRequest, IPagedResultReguest
    {
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }
    }
}
