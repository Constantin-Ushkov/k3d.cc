﻿using k3d.Common.Diagnostics;

namespace k3d.CC.ViewModel.Impl.MainView
{
    internal class MainViewAction : ViewModelAction
    {
        public MainViewAction(IViewModelFactoryInternal factory, IMainViewInternal view) : base(factory)
        {
            Assert.Argument.IsNotNull(view, nameof(view));
            _view = view;
        }

        protected readonly IMainViewInternal _view;
    }
}
