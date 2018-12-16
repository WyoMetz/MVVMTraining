using System;
using System.Windows.Input;

namespace MVVMTraining.MVVM
{
	public class DelegateCommand : ICommand
	{
		#region Attributes
		private readonly Action<object> execute;
		private readonly Predicate<object> canExecute;
		#endregion

		#region Events
		public event EventHandler CanExecuteChanged;
		#endregion

		#region Public Methods

		public DelegateCommand(Action<object> execute)
		{
			this.execute = execute ?? throw new ArgumentNullException("execute");
		}

		public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
		{
			this.execute = execute ?? throw new ArgumentNullException("execute");
			this.canExecute = canExecute ?? throw new ArgumentNullException("execute");
		}

		public bool CanExecute(object parameter)
		{
			if (canExecute == null)
			{
				return true;
			}
			else
			{
				return canExecute(parameter);
			}
		}

		public void Execute(object parameter)
		{
			execute(parameter);
		}

		public void RaiseCanExecuteChanged()
		{
			OnCanExecuteChanged();
		}

		protected virtual void OnCanExecuteChanged()
		{
			EventHandler handler = CanExecuteChanged;
			if (handler != null)
			{
				handler.Invoke(this, EventArgs.Empty);
			}
		}
		#endregion
	}
}