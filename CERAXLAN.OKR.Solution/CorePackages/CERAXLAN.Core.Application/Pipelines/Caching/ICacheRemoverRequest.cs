﻿
namespace CERAXLAN.Core.Application.Pipelines.Caching
{
    public interface ICacheRemoverRequest
    {
        bool BypassCache { get; }
        string CacheKey { get; }
    }
}
