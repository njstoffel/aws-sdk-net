/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Snowball.Model;
using Amazon.Snowball.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Snowball
{
    /// <summary>
    /// Implementation for accessing Snowball
    ///
    /// AWS Snowball is a petabyte-scale data transport solution that uses secure appliances
    /// to transfer large amounts of data between your on-premises data centers and Amazon
    /// Simple Storage Service (Amazon S3). The Snowball commands described here provide access
    /// to the same functionality that is available in the AWS Snowball Management Console,
    /// which enables you to create and manage jobs for Snowball. To transfer data locally
    /// with a Snowball appliance, you'll need to use the Snowball client or the Amazon S3
    /// API adapter for Snowball. For more information, see the <a href="http://docs.aws.amazon.com/AWSImportExport/latest/ug/api-reference.html">User
    /// Guide</a>.
    /// </summary>
    public partial class AmazonSnowballClient : AmazonServiceClient, IAmazonSnowball
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonSnowballClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSnowballClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSnowballConfig()) { }

        /// <summary>
        /// Constructs AmazonSnowballClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowballClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSnowballConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSnowballClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSnowballClient Configuration Object</param>
        public AmazonSnowballClient(AmazonSnowballConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSnowballClient(AWSCredentials credentials)
            : this(credentials, new AmazonSnowballConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowballClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSnowballConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Credentials and an
        /// AmazonSnowballClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSnowballClient Configuration Object</param>
        public AmazonSnowballClient(AWSCredentials credentials, AmazonSnowballConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSnowballConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSnowballConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSnowballClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSnowballClient Configuration Object</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSnowballConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSnowballConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSnowballConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowballClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSnowballClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSnowballClient Configuration Object</param>
        public AmazonSnowballClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSnowballConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CancelCluster

        internal CancelClusterResponse CancelCluster(CancelClusterRequest request)
        {
            var marshaller = new CancelClusterRequestMarshaller();
            var unmarshaller = CancelClusterResponseUnmarshaller.Instance;

            return Invoke<CancelClusterRequest,CancelClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CancelCluster">REST API Reference for CancelCluster Operation</seealso>
        public Task<CancelClusterResponse> CancelClusterAsync(CancelClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelClusterRequestMarshaller();
            var unmarshaller = CancelClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CancelClusterRequest,CancelClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelJob

        internal CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var marshaller = new CancelJobRequestMarshaller();
            var unmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobRequest,CancelJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelJobRequestMarshaller();
            var unmarshaller = CancelJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJobRequest,CancelJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAddress

        internal CreateAddressResponse CreateAddress(CreateAddressRequest request)
        {
            var marshaller = new CreateAddressRequestMarshaller();
            var unmarshaller = CreateAddressResponseUnmarshaller.Instance;

            return Invoke<CreateAddressRequest,CreateAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateAddress">REST API Reference for CreateAddress Operation</seealso>
        public Task<CreateAddressResponse> CreateAddressAsync(CreateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAddressRequestMarshaller();
            var unmarshaller = CreateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddressRequest,CreateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster

        internal CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterRequest,CreateClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterRequest,CreateClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateJob

        internal CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var marshaller = new CreateJobRequestMarshaller();
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobRequest,CreateJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateJobRequestMarshaller();
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobRequest,CreateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddress

        internal DescribeAddressResponse DescribeAddress(DescribeAddressRequest request)
        {
            var marshaller = new DescribeAddressRequestMarshaller();
            var unmarshaller = DescribeAddressResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressRequest,DescribeAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeAddress">REST API Reference for DescribeAddress Operation</seealso>
        public Task<DescribeAddressResponse> DescribeAddressAsync(DescribeAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAddressRequestMarshaller();
            var unmarshaller = DescribeAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressRequest,DescribeAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddresses

        internal DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        public Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCluster

        internal DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var marshaller = new DescribeClusterRequestMarshaller();
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterRequest,DescribeClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterRequestMarshaller();
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterRequest,DescribeClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob

        internal DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var marshaller = new DescribeJobRequestMarshaller();
            var unmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobRequest,DescribeJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeJobRequestMarshaller();
            var unmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobRequest,DescribeJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobManifest

        internal GetJobManifestResponse GetJobManifest(GetJobManifestRequest request)
        {
            var marshaller = new GetJobManifestRequestMarshaller();
            var unmarshaller = GetJobManifestResponseUnmarshaller.Instance;

            return Invoke<GetJobManifestRequest,GetJobManifestResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobManifest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetJobManifest">REST API Reference for GetJobManifest Operation</seealso>
        public Task<GetJobManifestResponse> GetJobManifestAsync(GetJobManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobManifestRequestMarshaller();
            var unmarshaller = GetJobManifestResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobManifestRequest,GetJobManifestResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobUnlockCode

        internal GetJobUnlockCodeResponse GetJobUnlockCode(GetJobUnlockCodeRequest request)
        {
            var marshaller = new GetJobUnlockCodeRequestMarshaller();
            var unmarshaller = GetJobUnlockCodeResponseUnmarshaller.Instance;

            return Invoke<GetJobUnlockCodeRequest,GetJobUnlockCodeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobUnlockCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobUnlockCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetJobUnlockCode">REST API Reference for GetJobUnlockCode Operation</seealso>
        public Task<GetJobUnlockCodeResponse> GetJobUnlockCodeAsync(GetJobUnlockCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobUnlockCodeRequestMarshaller();
            var unmarshaller = GetJobUnlockCodeResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobUnlockCodeRequest,GetJobUnlockCodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSnowballUsage

        internal GetSnowballUsageResponse GetSnowballUsage(GetSnowballUsageRequest request)
        {
            var marshaller = new GetSnowballUsageRequestMarshaller();
            var unmarshaller = GetSnowballUsageResponseUnmarshaller.Instance;

            return Invoke<GetSnowballUsageRequest,GetSnowballUsageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSnowballUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnowballUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetSnowballUsage">REST API Reference for GetSnowballUsage Operation</seealso>
        public Task<GetSnowballUsageResponse> GetSnowballUsageAsync(GetSnowballUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSnowballUsageRequestMarshaller();
            var unmarshaller = GetSnowballUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnowballUsageRequest,GetSnowballUsageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListClusterJobs

        internal ListClusterJobsResponse ListClusterJobs(ListClusterJobsRequest request)
        {
            var marshaller = new ListClusterJobsRequestMarshaller();
            var unmarshaller = ListClusterJobsResponseUnmarshaller.Instance;

            return Invoke<ListClusterJobsRequest,ListClusterJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListClusterJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusterJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListClusterJobs">REST API Reference for ListClusterJobs Operation</seealso>
        public Task<ListClusterJobsResponse> ListClusterJobsAsync(ListClusterJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListClusterJobsRequestMarshaller();
            var unmarshaller = ListClusterJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListClusterJobsRequest,ListClusterJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersRequest,ListClustersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListClustersRequestMarshaller();
            var unmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersRequest,ListClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsRequest,ListJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsRequest,ListJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCluster

        internal UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var marshaller = new UpdateClusterRequestMarshaller();
            var unmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterRequest,UpdateClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateClusterRequestMarshaller();
            var unmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterRequest,UpdateClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateJob

        internal UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var marshaller = new UpdateJobRequestMarshaller();
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobRequest,UpdateJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateJobRequestMarshaller();
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobRequest,UpdateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}