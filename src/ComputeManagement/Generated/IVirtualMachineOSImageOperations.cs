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

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Service Management API includes operations for managing the OS
    /// images in your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157175.aspx for
    /// more information)
    /// </summary>
    public partial interface IVirtualMachineOSImageOperations
    {
        /// <summary>
        /// Share an already replicated OS image. This operation is only for
        /// publishers. You have to be registered as image publisher with
        /// Windows Azure to be able to call this.
        /// </summary>
        /// <param name='imageName'>
        /// The name of the virtual machine image to share.
        /// </param>
        /// <param name='permission'>
        /// The sharing permission: public, msdn, or private.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginSharingAsync(string imageName, string permission, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unreplicate an OS image to multiple target locations. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this. Note:
        /// The operation removes the published copies of the user OS Image.
        /// It does not remove the actual user OS Image. To remove the actual
        /// user OS Image, the publisher will have to call Delete OS Image.
        /// </summary>
        /// <param name='imageName'>
        /// The name of the virtual machine image to replicate. Note: The OS
        /// Image Name should be the user OS Image, not the published name of
        /// the OS Image.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginUnreplicatingAsync(string imageName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Create OS Image operation adds an operating system image that
        /// is stored in a storage account and is available from the image
        /// repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157192.aspx
        /// for more information)
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Virtual Machine Image operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Parameters returned from the Create Virtual Machine Image operation.
        /// </returns>
        Task<VirtualMachineOSImageCreateResponse> CreateAsync(VirtualMachineOSImageCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete OS Image operation deletes the specified OS image from
        /// your image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157203.aspx
        /// for more information)
        /// </summary>
        /// <param name='imageName'>
        /// The name of the image to delete.
        /// </param>
        /// <param name='deleteFromStorage'>
        /// Specifies that the source blob for the image should also be deleted
        /// from storage.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string imageName, bool deleteFromStorage, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get OS Image operation retrieves the details for an operating
        /// system image from the image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157191.aspx
        /// for more information)
        /// </summary>
        /// <param name='imageName'>
        /// The name of the OS image to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A virtual machine image associated with your subscription.
        /// </returns>
        Task<VirtualMachineOSImageGetResponse> GetAsync(string imageName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets OS Image's properties and its replication details. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this.
        /// </summary>
        /// <param name='imageName'>
        /// The name of the virtual machine image to replicate.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Details OS Images operation response.
        /// </returns>
        Task<VirtualMachineOSImageGetDetailsResponse> GetDetailsAsync(string imageName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List OS Images operation retrieves a list of the operating
        /// system images from the image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157191.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List OS Images operation response.
        /// </returns>
        Task<VirtualMachineOSImageListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Replicate an OS image to multiple target locations. This operation
        /// is only for publishers. You have to be registered as image
        /// publisher with Windows Azure to be able to call this.
        /// </summary>
        /// <param name='imageName'>
        /// The name of the virtual machine OS image to replicate.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Replicate Virtual Machine Image
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the published name of the image.
        /// </returns>
        Task<VirtualMachineOSImageReplicateResponse> ReplicateAsync(string imageName, VirtualMachineOSImageReplicateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Share an already replicated OS image. This operation is only for
        /// publishers. You have to be registered as image publisher with
        /// Windows Azure to be able to call this.
        /// </summary>
        /// <param name='imageName'>
        /// The name of the virtual machine image to share.
        /// </param>
        /// <param name='permission'>
        /// The sharing permission: public, msdn, or private.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> ShareAsync(string imageName, string permission, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unreplicate an OS image to multiple target locations. This
        /// operation is only for publishers. You have to be registered as
        /// image publisher with Windows Azure to be able to call this. Note:
        /// The operation removes the published copies of the user OS Image.
        /// It does not remove the actual user OS Image. To remove the actual
        /// user OS Image, the publisher will have to call Delete OS Image.
        /// </summary>
        /// <param name='imageName'>
        /// The name of the virtual machine image to replicate. Note: The OS
        /// Image Name should be the user OS Image, not the published name of
        /// the OS Image.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> UnreplicateAsync(string imageName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Update OS Image operation updates an OS image that in your
        /// image repository.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157198.aspx
        /// for more information)
        /// </summary>
        /// <param name='imageName'>
        /// The name of the virtual machine image to be updated.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Virtual Machine Image operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Parameters returned from the Create Virtual Machine Image operation.
        /// </returns>
        Task<VirtualMachineOSImageUpdateResponse> UpdateAsync(string imageName, VirtualMachineOSImageUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
