﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ICartoonService")]
    public interface ICartoonService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartoonService/QueryCartoons", ReplyAction="http://tempuri.org/ICartoonService/QueryCartoonsResponse")]
        string QueryCartoons(string xpathQuery);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartoonService/QueryCartoons", ReplyAction="http://tempuri.org/ICartoonService/QueryCartoonsResponse")]
        System.Threading.Tasks.Task<string> QueryCartoonsAsync(string xpathQuery);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface ICartoonServiceChannel : ServiceReference.ICartoonService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class CartoonServiceClient : System.ServiceModel.ClientBase<ServiceReference.ICartoonService>, ServiceReference.ICartoonService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CartoonServiceClient() : 
                base(CartoonServiceClient.GetDefaultBinding(), CartoonServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICartoonService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CartoonServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CartoonServiceClient.GetBindingForEndpoint(endpointConfiguration), CartoonServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CartoonServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CartoonServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CartoonServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CartoonServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CartoonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string QueryCartoons(string xpathQuery)
        {
            return base.Channel.QueryCartoons(xpathQuery);
        }
        
        public System.Threading.Tasks.Task<string> QueryCartoonsAsync(string xpathQuery)
        {
            return base.Channel.QueryCartoonsAsync(xpathQuery);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICartoonService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICartoonService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:14885/CartoonQueryService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CartoonServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICartoonService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CartoonServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICartoonService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICartoonService,
        }
    }
}
