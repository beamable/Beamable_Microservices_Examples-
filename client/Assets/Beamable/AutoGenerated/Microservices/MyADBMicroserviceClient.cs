//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beamable.Server.Clients
{
    using System;
    using Beamable.Platform.SDK;
    using Beamable.Server;
    
    
    /// <summary> A generated client for <see cref="Beamable.Server.MyADBMicroservice.MyADBMicroserviceExample.MyADBMicroservice"/> </summary
    public sealed class MyADBMicroserviceClient : Beamable.Server.MicroserviceClient
    {
        
        /// <summary>
        /// Call the ConnectToDatabase method on the MyADBMicroservice microservice
        /// <see cref="Beamable.Server.MyADBMicroservice.MyADBMicroserviceExample.MyADBMicroservice.ConnectToDatabase"/>
        /// </summary>
        public Beamable.Common.Promise<bool> ConnectToDatabase()
        {
            string[] serializedFields = new string[0];
            return this.Request<bool>("MyADBMicroservice", "ConnectToDatabase", serializedFields);
        }
    }
}