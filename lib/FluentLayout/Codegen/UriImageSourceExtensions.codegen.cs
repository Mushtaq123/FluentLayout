// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class UriImageSourceExtensions
    {

        
        public static UriImageSource BindUriUriImageSource(this UriImageSource self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null)
                => self.Bind(UriImageSource.UriProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}