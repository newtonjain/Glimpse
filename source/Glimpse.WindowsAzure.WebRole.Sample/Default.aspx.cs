﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Glimpse.WindowsAzure.Storage.Infrastructure;
using Microsoft.ApplicationServer.Caching;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Glimpse.WindowsAzure.WebRole.Sample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Perform operations on Windows Azure storage
            var account = CloudStorageAccount.DevelopmentStorageAccount;
            var blobclient = account.CreateCloudBlobClient();

            var container1 = blobclient.GetContainerReference("glimpse1");
            container1.CreateIfNotExists(operationContext: OperationContextFactory.Current.Create());
            container1.SetPermissions(new BlobContainerPermissions() { PublicAccess = BlobContainerPublicAccessType.Blob }, operationContext: OperationContextFactory.Current.Create());

            var container2 = blobclient.GetContainerReference("glimpse2");
            container2.CreateIfNotExists(operationContext: OperationContextFactory.Current.Create());
            //container2.Metadata.Add("foo", "bar");
            container2.SetMetadata(operationContext: OperationContextFactory.Current.Create());


            // Perform operations on Windows Azure Cache
            var cacheFactory = new DataCacheFactory();
            var cache = cacheFactory.GetDefaultCache();

            cacheFactory.GetDefaultCache().CacheOperationStarted += (o, args) =>
            {
                var x = 1;
            };
            cacheFactory.GetDefaultCache().CacheOperationCompleted += (o, args) =>
            {
                var x = 1;
            };

            // Add some items
            for (int i = 0; i < 250; i++)
            {
                cache.Add(i.ToString(), "value");
            }

            // Read some items
            for (int i = 0; i < 250; i++)
            {
                cache.Get(i.ToString());
            }
        }
    }
}