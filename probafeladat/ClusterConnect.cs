using Couchbase;
using Couchbase.Authentication;
using Couchbase.Configuration.Client;
using System;
using System.Collections.Generic;

namespace probafeladat
{
    public class ClusterCOnnect
    {
        public ClusterCOnnect()
        {

            var config = new ClientConfiguration
            {
                Servers = new List<Uri> {
        new Uri("http://192.168.56.101:8091"),
        new Uri("http://192.168.56.102:8091")
    },
                BucketConfigs = new Dictionary<string, BucketConfiguration> {{
            "mybucket", new BucketConfiguration{
                BucketName = "mybucket"
            }
        }
     }
            };
            //create the authenticator for passing in the user and password for RBAC
            var credentials = new PasswordAuthenticator("Administrator", "password");
 
            ClusterHelper.Initialize(config, credentials);
            var bucket = ClusterHelper.GetBucket("mybucket");

        }
    }
}
