using System;
using System.Collections.Generic;
using Glimpse.Core.Extensibility;

namespace Glimpse.Core.Framework
{
    public class GlimpseConfiguration : IGlimpseConfiguration
    {
        private ICollection<IClientScript> clientScripts;
        private IResource defaultResource;
        private string endpointBaseUri;
        private IFrameworkProvider frameworkProvider;
        private IHtmlEncoder htmlEncoder;
        private ILogger logger;
        private IMessageBroker messageBroker;
        private IPersistenceStore persistenceStore;
        private ICollection<IPipelineInspector> pipelineInspectors;
        private IProxyFactory proxyFactory;
        private ResourceEndpointConfiguration resourceEndpoint;
        private ICollection<IResource> resources;
        private ICollection<IRuntimePolicy> runtimePolicies;
        private ISerializer serializer;
        private ICollection<ITab> tabs;
        private Func<IExecutionTimer> timerStrategy;
        private Func<RuntimePolicy> runtimePolicyStrategy;

        public GlimpseConfiguration(
            IFrameworkProvider frameworkProvider, 
            ResourceEndpointConfiguration endpointConfiguration,
            ICollection<IClientScript> clientScripts,
            ILogger logger,
            RuntimePolicy defaultRuntimePolicy,
            IHtmlEncoder htmlEncoder,
            IPersistenceStore persistenceStore,
            ICollection<IPipelineInspector> pipelineInspectors,
            ICollection<IResource> resources,
            ISerializer serializer,
            ICollection<ITab> tabs,
            ICollection<IRuntimePolicy> runtimePolicies,
            IResource defaultResource,
            IProxyFactory proxyFactory,
            IMessageBroker messageBroker,
            string endpointBaseUri,
            Func<IExecutionTimer> timerStrategy,
            Func<RuntimePolicy> runtimePolicyStrategy)
        {
            if (frameworkProvider == null)
            {
                throw new ArgumentNullException("frameworkProvider");
            }

            if (endpointConfiguration == null)
            {
                throw new ArgumentNullException("endpointConfiguration");
            }

            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }

            if (htmlEncoder == null)
            {
                throw new ArgumentNullException("htmlEncoder");
            }

            if (persistenceStore == null)
            {
                throw new ArgumentNullException("persistenceStore");
            }

            if (clientScripts == null)
            {
                throw new ArgumentNullException("clientScripts");
            }

            if (resources == null)
            {
                throw new ArgumentNullException("pipelineInspectors");
            }

            if (serializer == null)
            {
                throw new ArgumentNullException("serializer");
            }

            if (tabs == null)
            {
                throw new ArgumentNullException("tabs");
            }

            if (runtimePolicies == null)
            {
                throw new ArgumentNullException("runtimePolicies");
            }

            if (defaultResource == null)
            {
                throw new ArgumentNullException("defaultResource");
            }

            if (proxyFactory == null)
            {
                throw new ArgumentNullException("proxyFactory");
            }

            if (messageBroker == null)
            {
                throw new ArgumentNullException("messageBroker");
            }

            if (endpointBaseUri == null)
            {
                throw new ArgumentNullException("endpointBaseUri");
            }

            if (timerStrategy == null)
            {
                throw new ArgumentNullException("timerStrategy");
            }

            if (runtimePolicyStrategy == null)
            {
                throw new ArgumentNullException("runtimePolicyStrategy");
            }

            Logger = logger;
            ClientScripts = clientScripts;
            FrameworkProvider = frameworkProvider;
            HtmlEncoder = htmlEncoder;
            PersistenceStore = persistenceStore;
            PipelineInspectors = pipelineInspectors;
            ResourceEndpoint = endpointConfiguration;
            Resources = resources;
            Serializer = serializer;
            Tabs = tabs;
            RuntimePolicies = runtimePolicies;
            DefaultRuntimePolicy = defaultRuntimePolicy;
            DefaultResource = defaultResource;
            ProxyFactory = proxyFactory;
            MessageBroker = messageBroker;
            EndpointBaseUri = endpointBaseUri;
            TimerStrategy = timerStrategy;
            RuntimePolicyStrategy = runtimePolicyStrategy;
        }

        public ICollection<IClientScript> ClientScripts
        {
            get
            {
                return clientScripts;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                clientScripts = value;
            }
        }

        public IResource DefaultResource
        {
            get
            {
                return defaultResource;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                defaultResource = value;
            }
        }

        public RuntimePolicy DefaultRuntimePolicy { get; set; }

        public string EndpointBaseUri
        {
            get
            {
                return endpointBaseUri;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                endpointBaseUri = value;
            }
        }

        public IFrameworkProvider FrameworkProvider
        {
            get
            {
                return frameworkProvider;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                frameworkProvider = value;
            }
        }

        public IHtmlEncoder HtmlEncoder
        {
            get
            {
                return htmlEncoder;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                htmlEncoder = value;
            }
        }

        public ILogger Logger
        {
            get
            {
                return logger;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                logger = value;
            }
        }

        public IMessageBroker MessageBroker
        {
            get
            {
                return messageBroker;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                messageBroker = value;
            }
        }

        public IPersistenceStore PersistenceStore
        {
            get
            {
                return persistenceStore;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                persistenceStore = value;
            }
        }

        public ICollection<IPipelineInspector> PipelineInspectors
        {
            get
            {
                return pipelineInspectors;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                pipelineInspectors = value;
            }
        }

        public IProxyFactory ProxyFactory
        {
            get
            {
                return proxyFactory;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                proxyFactory = value;
            }
        }

        public ResourceEndpointConfiguration ResourceEndpoint
        {
            get
            {
                return resourceEndpoint;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                resourceEndpoint = value;
            }
        }

        public ICollection<IResource> Resources
        {
            get
            {
                return resources;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                resources = value;
            }
        }

        public ICollection<IRuntimePolicy> RuntimePolicies
        {
            get
            {
                return runtimePolicies;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                runtimePolicies = value;
            }
        }

        public Func<RuntimePolicy> RuntimePolicyStrategy
        {
            get
            {
                return runtimePolicyStrategy;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                runtimePolicyStrategy = value;
            }
        }

        public ISerializer Serializer
        {
            get
            {
                return serializer;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                serializer = value;
            }
        }

        public ICollection<ITab> Tabs
        {
            get
            {
                return tabs;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                tabs = value;
            }
        }

        public Func<IExecutionTimer> TimerStrategy 
        { 
            get
            {
                return timerStrategy;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                timerStrategy = value;
            }
        }
    }
}
