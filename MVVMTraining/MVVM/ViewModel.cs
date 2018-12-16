using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVMTraining.MVVM
{
	public class ViewModel : INotifyPropertyChanged
	{
		private readonly Model model;

		public string Name
		{
			get
			{
				return this.model.Name;
			}
			set
			{
				if (this.model.Name != value)
				{
					this.model.Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		public string Address
		{
			get
			{
				return this.model.Address;
			}
			set
			{
				if(this.model.Address != value)
				{
					this.model.Address = value;
					this.OnPropertyChanged("Address");
				}
			}
		}

		public bool IsMale
		{
			get
			{
				return model.IsMale;
			}
			set
			{
				if(model.IsMale != value)
				{
					model.IsMale = value;
					OnPropertyChanged("IsMale");
				}
			}
		}

		public int BirthDay
		{
			get
			{
				return model.BirthDate.Day;
			}
			set
			{
				if (model.BirthDate.Day != value)
				{
					model.BirthDate = new DateTime(model.BirthDate.Year, model.BirthDate.Month, value);
					OnPropertyChanged("BirthDay");
				}
			}
		}

		public int BirthMonth
		{
			get
			{
				return model.BirthDate.Month;
			}
			set
			{
				if (model.BirthDate.Month != value)
				{
					model.BirthDate = new DateTime(model.BirthDate.Year, value, model.BirthDate.Day);
					OnPropertyChanged("BirthMonth");
				}
			}
		}

		public int BirthYear
		{
			get
			{
				return model.BirthDate.Year;
			}
			set
			{
				if (model.BirthDate.Year != value)
				{
					model.BirthDate = new DateTime(value, model.BirthDate.Month, model.BirthDate.Day);
					OnPropertyChanged("BirthYear");
				}
			}
		}

		public ICommand SaveCommand { get; private set; }
		public ICommand EraseCommand { get; private set; }

		public ViewModel(Model model, ICommand saveCommand, ICommand eraseCommand)
		{
			this.model = model;
			this.SaveCommand = saveCommand;
			this.EraseCommand = eraseCommand;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string PropertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
		}
	}
}
