using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTraining.MVVM
{
	class ViewFactory
	{
		public ViewInfastructure Create()
		{
			EraseDelegateCommand eraseDelegateCommand = new EraseDelegateCommand();
			SaveDelegateCommand saveDelegateCommand = new SaveDelegateCommand();
			Model model = new Model();
			ViewModel viewModel = new ViewModel(model, saveDelegateCommand.Command, eraseDelegateCommand.Command);
			View view = new View();

			return new ViewInfastructure(view, viewModel, model);
		}
	}
}
