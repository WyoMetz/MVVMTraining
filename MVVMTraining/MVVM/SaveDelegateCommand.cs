using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMTraining.MVVM
{
	public class SaveDelegateCommand
	{
		public DelegateCommand Command { get; private set; }

		private ViewModel viewModel;

		public ViewModel ViewModel
		{
			get
			{
				return viewModel;
			}
			set
			{
				if(viewModel != value)
				{
					if(viewModel != null)
					{
						viewModel.PropertyChanged -= OnViewModelPropertyChanged;
					}
					viewModel = value;
					viewModel.PropertyChanged += OnViewModelPropertyChanged;
				}
			}
		}

		public SaveDelegateCommand()
		{
			Command = new DelegateCommand(ExecuteSave, CanSave);
		}

		public void ExecuteSave(object unused)
		{
			MessageBox.Show("Save Done");
		}

		public bool CanSave(object unused)
		{
			return true;
		}

		private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			Command.RaiseCanExecuteChanged();
		}
	}
}
