using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BD.WTTS.UI.Views.Pages;

public partial class AuthenticatorImportPage : PageBase<AuthenticatorImportPageViewModel>
{
    public AuthenticatorImportPage()
    {
        InitializeComponent();

        DataContext ??= new AuthenticatorImportPageViewModel();
    }
}