using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atlassian.Stash.Api.Entities;
using Atlassian.Stash.Api.Helpers;
using Atlassian.Stash.Api.Workers;

namespace Atlassian.Stash.Api.Api
{
    public class Permissions
    {
        private readonly HttpCommunicationWorker _httpWorker;
        private const string PermissionsUrl = "/rest/branch-permissions/1.0/projects/{0}/repos/{1}/restricted";

        internal Permissions(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }

        public async Task<ResponseWrapper<BranchPermission>> Get(string projectKey, string repositorySlug, RequestOptions requestOptions = null)
        {
            var requestUrl = UrlBuilder.FormatRestApiUrl(PermissionsUrl, requestOptions, projectKey, repositorySlug);

            var response = await _httpWorker.GetAsync<ResponseWrapper<BranchPermission>>(requestUrl).ConfigureAwait(false);

            return response;
        }
    }
}
