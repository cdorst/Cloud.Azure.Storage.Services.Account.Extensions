// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Cloud.Azure.Storage.Services.Account.Extensions
{
    /// <summary>Extension to add CloudStorageAccount services</summary>
    public static class AddCloudStorageAccountServicesExtension
    {
        /// <summary>Adds CloudStorageAccount services</summary>
        public static IServiceCollection AddCloudStorageAccountServices(this IServiceCollection services, string connectionString) => services.Configure<AzureStorageConnectionOptions>(options => options.ConnectionString = connectionString).AddSingleton<ICloudStorageAccountGetter, CloudStorageAccountGetter>();
    }
}
