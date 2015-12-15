using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBase.Common.Http
{
    public class ApiResponse<T> where T : class, new()
    {
        public async Task<Response> Send(Request request)
        {
            using (var httpClient = MakeHttpClient())
            {
                using (var httpRequest = MakeHttpRequest(request))
                {
                    using (var httpResponse = await httpClient.SendAsync(httpRequest))
                    {
                        return await MakeResponse(httpResponse, request);
                    }
                }
            }
        }
    }
}
