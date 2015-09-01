namespace Atlassian.Stash.Api.Helpers
{
    public class BranchRequestOptions : RequestOptions
    {
        public string FilterText { get; set; }
        public BranchOrderBy OrderBy { get; set; }
    }

    public enum BranchOrderBy
    {
        Alphabetical,
        Modification
    }
}
