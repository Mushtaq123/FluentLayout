// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class NavigationPageExtensions
    {

        
        public static TBindable BindBackButtonTitleNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.BackButtonTitleProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable SetBackButtonTitle<TBindable>(this TBindable bindable, String value) where TBindable : BindableObject
            => bindable.Set(NavigationPage.BackButtonTitleProperty, value);
        
        public static TBindable BindHasNavigationBarNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.HasNavigationBarProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable SetHasNavigationBar<TBindable>(this TBindable bindable, Boolean value) where TBindable : BindableObject
            => bindable.Set(NavigationPage.HasNavigationBarProperty, value);
        
        public static TBindable BindHasBackButtonNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.HasBackButtonProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable SetHasBackButton<TBindable>(this TBindable bindable, Boolean value) where TBindable : BindableObject
            => bindable.Set(NavigationPage.HasBackButtonProperty, value);
        
[Obsolete]
        public static TBindable BindTintNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.TintProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindBarBackgroundColorNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.BarBackgroundColorProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindBarTextColorNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.BarTextColorProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindTitleIconNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.TitleIconProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable SetTitleIcon<TBindable>(this TBindable bindable, FileImageSource value) where TBindable : BindableObject
            => bindable.Set(NavigationPage.TitleIconProperty, value);
        
        public static TBindable BindTitleViewNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.TitleViewProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable SetTitleView<TBindable>(this TBindable bindable, View value) where TBindable : BindableObject
            => bindable.Set(NavigationPage.TitleViewProperty, value);
        
        public static TBindable BindCurrentPageNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.CurrentPageProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindRootPageNavigationPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : NavigationPage
                => self.Bind(NavigationPage.RootPageProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}