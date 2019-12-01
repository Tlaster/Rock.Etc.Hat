using System.Threading.Tasks;
using Refit;
using Rocket.Chat.Net.Model;
using Rocket.Chat.Net.Parameter;

namespace Rocket.Chat.Net.Api
{
    public interface IInformation
    {
        /// <summary>
        ///     A simple method, requires no authentication, that returns information about the server including version
        ///     information.
        /// </summary>
        /// <returns>
        ///     <see cref="ServerInfoResponse" />
        /// </returns>
        [Get("/api/info")]
        Task<ServerInfoResponse> Info();

        /// <summary>
        ///     A method, that searches by users or channels on all users and channels available on server. It supports the Offset,
        ///     Count, and Sort Query Parameters along with Query and Fields Query Parameters.
        ///     Requires Auth
        /// </summary>
        /// <param name="query">
        ///     When type is users you can send an additional workspace field, that can be local (default) or all.
        ///     workspace=all will work only if Federation is enabled.
        /// </param>
        /// <param name="offset">number of items to “skip” in the query, is zero based so it starts off at 0 being the first item.</param>
        /// <param name="count">
        ///     the number of items to “get” in the query, is one based so to get only one you would pass in 1. If
        ///     you want to get all of the records, then pass in 0 but this will only work if the setting (see below) allows it.
        /// </param>
        /// <returns></returns>
        [Get("/api/v1/directory")]
        Task<PagedResponse<DirectoryResponse>> Directory(DirectoryQueryParameter query, long offset, long count);

        /// <summary>
        ///     Searches for users or rooms that are visible to the user. WARNING: It will only return rooms that user didn’t join
        ///     yet.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [Get("/api/v1/spotlight")]
        Task<SpotlightResponse> Spotlight(string query);

        [Get("/api/v1/statistics")]
        Task<StatisticsResponse> Statistics(bool refresh = true);
    }
}