using System.Threading.Tasks;
using Atlassian.Stash.Api.Entities;
using Atlassian.Stash.Api.Helpers;
using Atlassian.Stash.Api.Workers;

namespace Atlassian.Stash.Api.Api
{
    public class RepoPermissions
    {
        private readonly HttpCommunicationWorker _httpWorker;
        private const string PermissionsUrl = "/rest/api/1.0/projects/{0}/repos/{1}/permissions/users";
        private const string PutUrl = "/rest/api/1.0/projects/{0}/repos/{1}/permissions/users?name={2}&permission={3}";

        internal RepoPermissions(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }

        public async Task<ResponseWrapper<RepoPermission>> Get(string projectKey, string repositorySlug,
            RequestOptions requestOptions = null)
        {
            var requestUrl = UrlBuilder.FormatRestApiUrl(PermissionsUrl, requestOptions, projectKey, repositorySlug);

            var response = await _httpWorker.GetAsync<ResponseWrapper<RepoPermission>>(requestUrl).ConfigureAwait(false);

            return response;
        }

        public async Task Set(string projectKey, string repositorySlug, string username, string repoPermission)
        {
            var requestUrl = UrlBuilder.FormatRestApiUrl(PutUrl, null, projectKey, repositorySlug, username, repoPermission);

            await _httpWorker.PutAsync<RepoPermission>(requestUrl, null).ConfigureAwait(false);
        }
    }
}
