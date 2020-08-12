using System.Windows;

namespace MaterialDesignThemes.Wpf
{
    public static class ProgressBarAssist
    {
        public static readonly DependencyProperty IsIndeterminateProperty = DependencyProperty.RegisterAttached(
            "IsIndeterminate", typeof(bool), typeof(ProgressBarAssist), new FrameworkPropertyMetadata(default(bool)));
        public static bool GetIsIndeterminate(DependencyObject element) => (bool)element.GetValue(IsIndeterminateProperty);
        public static void SetIsIndeterminate(DependencyObject element, bool value) => element.SetValue(IsIndeterminateProperty, value);
    }
}
