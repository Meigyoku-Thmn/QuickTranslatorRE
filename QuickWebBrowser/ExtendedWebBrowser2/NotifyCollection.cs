﻿using System;
using System.Collections.ObjectModel;

namespace ExtendedWebBrowser2
{
    internal class NotifyCollection<T> : Collection<T>
    {
        public event EventHandler CollectionChanged;

        protected virtual void OnCollectionChanged(EventArgs e)
        {
            CollectionChanged?.Invoke(this, e);
        }

        protected override void ClearItems()
        {
            base.ClearItems();
            OnCollectionChanged(EventArgs.Empty);
        }

        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            OnCollectionChanged(EventArgs.Empty);
        }

        protected override void RemoveItem(int index)
        {
            base.RemoveItem(index);
            OnCollectionChanged(EventArgs.Empty);
        }

        protected override void SetItem(int index, T item)
        {
            base.SetItem(index, item);
            OnCollectionChanged(EventArgs.Empty);
        }
    }
}
