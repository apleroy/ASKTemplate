using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using ASK.Repository;
using ASK.Services;
using Microsoft.Practices.Unity;

namespace ASK.WebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var container = new UnityContainer();

            #region UnitOfWork

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            #endregion

            #region Caching

            container.RegisterType<ICacheService, MemoryCacheService>();

            #endregion

            #region RequestMapping and Persistence

            container.RegisterType<IAlexaRequestMapper, AlexaRequestMapper>();
            container.RegisterType<IAlexaRequestPersistenceService, AlexaRequestPersistenceService>();

            #endregion

            #region Request and Validation

            container.RegisterType<IAlexaRequestValidationService, AlexaRequestValidationService>();
            container.RegisterType<IAlexaRequestService, AlexaRequestService>();

            #endregion

            #region Handler Strategies

            container.RegisterType<IAlexaRequestHandlerStrategy, CancelIntentHandlerStrategy>("CancelIntentHandlerStrategy");
            container.RegisterType<IAlexaRequestHandlerStrategy, StopIntentHandlerStrategy>("StopIntentHandlerStrategy");
            container.RegisterType<IAlexaRequestHandlerStrategy, HelloWorldIntentHandlerStrategy>("HelloWorldIntentHandlerStrategy");
            container.RegisterType<IAlexaRequestHandlerStrategy, HelpIntentHandlerStrategy>("HelpIntentHandlerStrategy");
            container.RegisterType<IAlexaRequestHandlerStrategy, LaunchRequestHandlerStrategy>("LaunchRequestHandlerStrategy");
            container.RegisterType<IAlexaRequestHandlerStrategy, SessionEndedRequestHandlerStrategy>("SessionEndedRequestHandlerStrategy");

            container.RegisterType<IEnumerable<IAlexaRequestHandlerStrategy>, IAlexaRequestHandlerStrategy[]>();
            container.RegisterType<IAlexaRequestHandlerStrategyFactory, AlexaRequestHandlerStrategyFactory>();

            #endregion

            #region Repository Services

            #endregion


            config.DependencyResolver = new UnityResolver(container);


            // does certificate and header level validation for all api requests
            // make route specific if needed
            config.MessageHandlers.Add(new AlexaRequestValidationHandler());
        }
    }
}
