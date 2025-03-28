﻿using k3d.CC.ViewModel.Impl.Factory;
using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl.Controller
{
    internal interface IControllerInternal : IViewModelController
    {
        Factory.IViewModelFactory Factory { get; }
        IViewModelCollection Views { get; }

        void DisplayView<T>(bool modal) where T : class, IViewModelInternal;
        void ReportError(string message, Exception? exception = null);
    }
}
