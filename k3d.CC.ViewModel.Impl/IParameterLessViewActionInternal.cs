using k3d.CC.ViewModel.Interface;

namespace k3d.CC.ViewModel.Impl
{
    internal interface IParameterLessViewActionInternal: IParameterLessViewAction
    {
        void Enable(bool enabled);
    }
}
