using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTraining.MVVM
{
	class ViewInfastructure
	{
		public View View { get; private set; }

		public ViewModel ViewModel { get; private set; }

		public Model Model { get; private set; }

		public ViewInfastructure(View view, ViewModel viewModel, Model model)
		{
			this.View = view;
			this.ViewModel = viewModel;
			this.Model = model;
		}
	}
}
