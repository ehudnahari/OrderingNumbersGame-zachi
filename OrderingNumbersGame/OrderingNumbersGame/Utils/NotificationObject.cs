using System;
using System.ComponentModel;
using System.Linq.Expressions;
using GalaSoft.MvvmLight;

namespace OrderingNumbersGame.Utils
{
	public abstract class NotificationObject : ViewModelBase, IDisposable
	{
		protected virtual void OnPropertyChanged(string propertyName)
		{
			RaisePropertyChanged(propertyName);
		}

		protected void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
		{
			var propertyName = GetPropertyName(propertyExpression);
			OnPropertyChanged(propertyName);
		}

		protected virtual bool SetProperty<T>(ref T field, T value, Expression<Func<T>> propertyExpression)
		{
			return Set(propertyExpression, ref field, value);
		}

		protected virtual bool SetProperty<T>(ref T field, T value, Action<T, T> callback, string propertyName)
		{
			var oldValue = field;
			var result = Set(propertyName, ref field, value);
			if (result)
			{
				callback(oldValue, value);

			}
			return result;
		}

		public virtual void Dispose()
		{
			if (PropertyChangedHandler != null)
			{
				foreach (var toRemove in PropertyChangedHandler.GetInvocationList())
				{
					PropertyChanged -= (PropertyChangedEventHandler)toRemove;
				}
			}
		}
	}

}
