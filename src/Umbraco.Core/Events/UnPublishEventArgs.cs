﻿using System.Collections.Generic;

namespace Umbraco.Core.Events
{
    public class UnPublishEventArgs<TEntity> : CancellableObjectEventArgs<IEnumerable<TEntity>>
    {
         /// <summary>
		/// Constructor accepting multiple entities that are used in the unpublish operation
		/// </summary>
		/// <param name="eventObject"></param>
		/// <param name="canCancel"></param>
		public UnPublishEventArgs(IEnumerable<TEntity> eventObject, bool canCancel)
			: base(eventObject, canCancel)
		{
		}

		/// <summary>
		/// Constructor accepting multiple entities that are used in the unpublish operation
		/// </summary>
		/// <param name="eventObject"></param>
		public UnPublishEventArgs(IEnumerable<TEntity> eventObject)
			: base(eventObject)
		{
		}

		/// <summary>
		/// Constructor accepting a single entity instance
		/// </summary>
		/// <param name="eventObject"></param>
		public UnPublishEventArgs(TEntity eventObject)
			: base(new List<TEntity> { eventObject })
		{
		}

		/// <summary>
		/// Constructor accepting a single entity instance
		/// </summary>
		/// <param name="eventObject"></param>
		/// <param name="canCancel"></param>
        public UnPublishEventArgs(TEntity eventObject, bool canCancel)
			: base(new List<TEntity> { eventObject }, canCancel)
		{
		}

		/// <summary>
		/// Returns all entities that were unpublished during the operation
		/// </summary>
		public IEnumerable<TEntity> UnPublishedEntities
		{
			get { return EventObject; }
		}
    }
}