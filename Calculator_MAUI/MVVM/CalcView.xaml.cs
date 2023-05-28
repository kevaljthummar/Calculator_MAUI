using Calculator_MAUI.MVVM.ViewModel;

namespace Calculator_MAUI;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();
	}
}
