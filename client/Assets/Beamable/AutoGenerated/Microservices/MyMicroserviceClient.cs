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
    
    
    /// <summary> A generated client for <see cref="Beamable.Examples.Features.Microservices.MyMicroservice"/> </summary
    public sealed class MyMicroserviceClient : Beamable.Server.MicroserviceClient
    {
        
        /// <summary>
        /// Call the AddMyValues method on the MyMicroservice microservice
        /// <see cref="Beamable.Examples.Features.Microservices.MyMicroservice.AddMyValues"/>
        /// </summary>
        public Beamable.Common.Promise<int> AddMyValues(int a, int b)
        {
            string serialized_a = this.SerializeArgument<int>(a);
            string serialized_b = this.SerializeArgument<int>(b);
            string[] serializedFields = new string[] {
                    serialized_a,
                    serialized_b};
            return this.Request<int>("MyMicroservice", "AddMyValues", serializedFields);
        }
        
        /// <summary>
        /// Call the GetPlayerLevel method on the MyMicroservice microservice
        /// <see cref="Beamable.Examples.Features.Microservices.MyMicroservice.GetPlayerLevel"/>
        /// </summary>
        public Beamable.Common.Promise<int> GetPlayerLevel()
        {
            string[] serializedFields = new string[0];
            return this.Request<int>("MyMicroservice", "GetPlayerLevel", serializedFields);
        }
        
        /// <summary>
        /// Call the SetPlayerLevel method on the MyMicroservice microservice
        /// <see cref="Beamable.Examples.Features.Microservices.MyMicroservice.SetPlayerLevel"/>
        /// </summary>
        public Beamable.Common.Promise<bool> SetPlayerLevel(int playerLevel)
        {
            string serialized_playerLevel = this.SerializeArgument<int>(playerLevel);
            string[] serializedFields = new string[] {
                    serialized_playerLevel};
            return this.Request<bool>("MyMicroservice", "SetPlayerLevel", serializedFields);
        }
    }
}
