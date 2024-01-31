using CommunityToolkit.Mvvm.ComponentModel;
namespace Finsculpt.ViewModels
{
    public partial class ExpensesBaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;
    }
}
