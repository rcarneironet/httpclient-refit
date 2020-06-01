using HttpClientFactoryProject.Models;

namespace HttpClientFactoryProject.Abstractions
{
    public interface IWhateverApi : IBaseApiCallAsync<WhateverModel>
    {
    }
}
