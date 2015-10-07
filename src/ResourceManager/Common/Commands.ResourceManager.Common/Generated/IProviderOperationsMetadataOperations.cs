// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Internal.Resources.Models;

namespace Microsoft.Azure.Management.Internal.Resources
{
    /// <summary>
    /// Operations for getting provider operations metadata.
    /// </summary>
    public partial interface IProviderOperationsMetadataOperations
    {
        /// <summary>
        /// Gets provider operations metadata
        /// </summary>
        /// <param name='resourceProviderNamespace'>
        /// Namespace of the resource provider.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Provider operations metadata
        /// </returns>
        Task<ProviderOperationsMetadataGetResult> GetAsync(string resourceProviderNamespace, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets provider operations metadata list
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Provider operations metadata list
        /// </returns>
        Task<ProviderOperationsMetadataListResult> ListAsync(CancellationToken cancellationToken);
    }
}