using System;

using TabletopArmyCreator.Payloads;
using TabletopArmyCreator.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceProviderExtensions
    {
        public static TView GetDialogViewWithDataContext<TView, TViewModel>(this IServiceProvider provider, IBaseParameters parameters) where TView : System.Windows.Controls.UserControl
                                                                                                                                    where TViewModel : IDialogWindowBase
        {
            TView view = provider.GetRequiredService<TView>();
            TViewModel viewModel = provider.GetRequiredService<TViewModel>();
            viewModel.Parameters = parameters;
            view.DataContext = viewModel;

            return view;
        }
    }
}
