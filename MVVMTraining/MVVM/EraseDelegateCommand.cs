using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTraining.MVVM
{
	public class EraseDelegateCommand
	{
		public DelegateCommand Command { get; private set; }

		public ViewModel ViewModel { get; set; }

		public EraseDelegateCommand()
		{
			this.Command = new DelegateCommand(this.ExecuteErase, this.CanErase);
		}

		public void ExecuteErase(object unused)
		{
			ViewModel.Address = string.Empty;
			ViewModel.BirthDay = 1;
			ViewModel.BirthMonth = 1;
			ViewModel.BirthYear = 1990;
			ViewModel.IsMale = true;
			ViewModel.Name = string.Empty;
		}

		public bool CanErase(object unused)
		{
			return true;
		}
	}
}
