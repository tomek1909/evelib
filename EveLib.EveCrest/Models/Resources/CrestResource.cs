﻿// ***********************************************************************
// Assembly         : EveLib.EveCrest
// Author           : Lars Kristian
// Created          : 12-16-2014
//
// Last Modified By : Lars Kristian
// Last Modified On : 12-17-2014
// ***********************************************************************
// <copyright file="CrestResource.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using eZet.EveLib.EveCrestModule.Models.Links;

namespace eZet.EveLib.EveCrestModule.Models.Resources {
    /// <summary>
    ///     Class CrestResource.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CrestResource<T> : ICrestResource<T> where T : class, ICrestResource<T> {

        /// <summary>
        ///     Gets or sets the crest instance used to query resources.
        /// </summary>
        /// <value>The crest instance</value>
        public EveCrest EveCrest { get; set; }

  
        /// <summary>
        ///     Gets or sets the response headers.
        /// </summary>
        /// <value>The response headers.</value>
        public WebHeaderCollection ResponseHeaders { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this resource is deprecated.
        /// </summary>
        /// <value><c>true</c> if this instance is deprecated; otherwise, <c>false</c>.</value>
        public virtual bool IsDeprecated { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        public virtual string ContentType { get; protected set; }

        /// <summary>
        ///     Queries the resource asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut&gt;.</returns>
        public Task<TOut> QueryAsync<TOut>(Func<T, Href<TOut>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            return EveCrest.LoadAsync(objFunc.Invoke(this as T));
        }

        /// <summary>
        ///     Queries the resource.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut&gt;.</returns>
        public virtual TOut Query<TOut>(Func<T, Href<TOut>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            return EveCrest.Load(objFunc.Invoke(this as T));
        }

        /// <summary>
        ///     Queries the resource asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut&gt;.</returns>
        public Task<TOut> QueryAsync<TOut>(Func<T, ILinkedEntity<TOut>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            return EveCrest.LoadAsync(objFunc.Invoke(this as T));
        }

        /// <summary>
        ///     Queries the resource.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut&gt;.</returns>
        public virtual TOut Query<TOut>(Func<T, ILinkedEntity<TOut>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            return EveCrest.Load(objFunc.Invoke(this as T));
        }

        /// <summary>
        ///     Queries a collection of resources asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut[]&gt;.</returns>
        public virtual Task<IEnumerable<TOut>> QueryAsync<TOut>(Func<T, IEnumerable<Href<TOut>>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            IEnumerable<Href<TOut>> items = objFunc.Invoke(this as T);
            return EveCrest.LoadAsync(items);
        }

        /// <summary>
        ///     Queries a collection of resources.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut[]&gt;.</returns>
        public virtual IEnumerable<TOut> Query<TOut>(Func<T, IEnumerable<Href<TOut>>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            IEnumerable<Href<TOut>> items = objFunc.Invoke(this as T);
            return EveCrest.Load(items);
        }

        /// <summary>
        ///     Queries a collection of resources asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut[]&gt;.</returns>
        public virtual Task<IEnumerable<TOut>> QueryAsync<TOut>(Func<T, IEnumerable<ILinkedEntity<TOut>>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            IEnumerable<ILinkedEntity<TOut>> items = objFunc.Invoke(this as T);
            return EveCrest.LoadAsync(items);
        }

        /// <summary>
        ///     Queries a collection of resources.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut[]&gt;.</returns>
        public virtual IEnumerable<TOut> Query<TOut>(Func<T, IEnumerable<ILinkedEntity<TOut>>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            IEnumerable<ILinkedEntity<TOut>> items = objFunc.Invoke(this as T);
            return EveCrest.Load(items);
        }

    }
}