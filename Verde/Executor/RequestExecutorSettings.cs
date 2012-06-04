﻿using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Security.Principal;

namespace Verde.Executor
{
    /// <summary>
    /// The settings for a simulated HTTP MVC request.
    /// </summary>
    /// <remarks>
    /// All properties are optional.
    /// </remarks>
    public class RequestExecutorSettings
    {
        public RequestExecutorSettings(Uri requestUrl)
        {
            this.Url = requestUrl;
        }

        /// <summary>
        /// Specify the HttpRequest. 
        /// </summary>
        /// <remarks>
        /// Generally you can leave this null and set properties like <see cref="Url"/>, <see cref="Cookies"/>, <see cref="Form"/>, etc.
        /// </remarks>
        public HttpRequestBase HttpRequest { get; set; }

        /// <summary>
        /// The Url of the request
        /// </summary>
        public Uri Url { get; private set; }

        /// <summary>
        /// The request cookies.
        /// </summary>
        public HttpCookieCollection Cookies { get; set; }
        
        /// <summary>
        /// The request form values.
        /// </summary>
        public NameValueCollection Form { get; set; }
        
        /// <summary>
        /// The request user agent.
        /// </summary>
        public string UserAgent { get; set; }
        
        /// <summary>
        /// The HTTP method for the request.
        /// </summary>
        /// <remarks>If left blank, the value will be implicitly set.</remarks>
        public string HttpMethod { get; set; }

        /// <summary>
        /// The collection of HTTP headers in the request.
        /// </summary>
        public NameValueCollection RequestHeaders { get; set; }
        
        /// <summary>
        /// The referring url.
        /// </summary>
        public Uri Referrer { get; set; }

        /// <summary>
        /// The http server utility.
        /// </summary>
        public HttpServerUtilityBase Server { get; set; }

        /// <summary>
        /// The collection of files in the request.
        /// </summary>
        public HttpFileCollectionBase Files { get; set; }

        /// <summary>
        /// The current user
        /// </summary>
        public IIdentity User { get; set; }

        /// <summary>
        /// The content type of the request.
        /// </summary>
        public string RequestContentType { get; set; }

        public bool IsAuthenticated { get; set; }

        /// <summary>
        /// The http response.
        /// </summary>
        /// <remarks>
        /// Generally it is not necessary to set this unless a custom <see cref="HttpResponseBase"/> implementation is required.
        /// </remarks>
        public HttpResponseBase HttpResponse { get; set; }

        /// <summary>
        /// The collection of HTTP context items.
        /// </summary>
        public IDictionary HttpContextItems { get; set; }

        /// <summary>
        /// The session state.
        /// </summary>
        /// <remarks>Only need to set this for special circumstances where a custom implementation of <see cref="HttpSessionStateBase"/> is required.
        /// </remarks>
        public HttpSessionStateBase SessionState { get; set;}

        /// <summary>
        /// The collection of session state items.
        /// </summary>
        public SessionStateItemCollection SessionStateItems { get; set; }

        /// <summary>
        /// The SessionId
        /// </summary>
        public string SessionId { get; set;}

        /// <summary>
        /// Specify if the simulated request should be a new session.
        /// </summary>
        public bool IsNewSession { get; set;}
    }
}