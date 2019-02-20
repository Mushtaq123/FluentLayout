// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class TabbedPageExtensions
    {


        public static TBindable WithTabbedPageCurrentPageChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.CurrentPageChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageCurrentPageChangedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "CurrentPageChanged");

            return self;
        }

        public static TBindable WithTabbedPagePagesChangedEvent<TBindable>(this TBindable self,
            System.Collections.Specialized.NotifyCollectionChangedEventHandler handlerAction) where TBindable : TabbedPage
        {
            self.PagesChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPagePagesChangedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PagesChanged");

            return self;
        }

        public static TBindable WithTabbedPageLayoutChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.LayoutChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageLayoutChangedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "LayoutChanged");

            return self;
        }

        public static TBindable WithTabbedPageAppearingEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.Appearing += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageAppearingHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Appearing");

            return self;
        }

        public static TBindable WithTabbedPageDisappearingEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.Disappearing += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageDisappearingHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Disappearing");

            return self;
        }

        public static TBindable WithTabbedPageChildrenReorderedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.ChildrenReordered += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageChildrenReorderedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildrenReordered");

            return self;
        }

        public static TBindable WithTabbedPageFocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : TabbedPage
        {
            self.Focused += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageFocusedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Focused");

            return self;
        }

        public static TBindable WithTabbedPageMeasureInvalidatedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.MeasureInvalidated += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageMeasureInvalidatedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "MeasureInvalidated");

            return self;
        }

        public static TBindable WithTabbedPageSizeChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.SizeChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageSizeChangedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "SizeChanged");

            return self;
        }

        public static TBindable WithTabbedPageUnfocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : TabbedPage
        {
            self.Unfocused += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageUnfocusedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Unfocused");

            return self;
        }

        public static TBindable WithTabbedPageBatchCommittedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> handlerAction) where TBindable : TabbedPage
        {
            self.BatchCommitted += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageBatchCommittedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BatchCommitted");

            return self;
        }

        public static TBindable WithTabbedPageFocusChangeRequestedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.VisualElement.FocusRequestArgs> handlerAction) where TBindable : TabbedPage
        {
            self.FocusChangeRequested += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageFocusChangeRequestedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "FocusChangeRequested");

            return self;
        }

        public static TBindable WithTabbedPageChildAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TabbedPage
        {
            self.ChildAdded += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageChildAddedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildAdded");

            return self;
        }

        public static TBindable WithTabbedPageChildRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TabbedPage
        {
            self.ChildRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageChildRemovedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildRemoved");

            return self;
        }

        public static TBindable WithTabbedPageDescendantAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TabbedPage
        {
            self.DescendantAdded += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageDescendantAddedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantAdded");

            return self;
        }

        public static TBindable WithTabbedPageDescendantRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TabbedPage
        {
            self.DescendantRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageDescendantRemovedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantRemoved");

            return self;
        }

        public static TBindable WithTabbedPagePlatformSetEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.PlatformSet += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPagePlatformSetHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PlatformSet");

            return self;
        }

        public static TBindable WithTabbedPagePropertyChangedEvent<TBindable>(this TBindable self,
            System.ComponentModel.PropertyChangedEventHandler handlerAction) where TBindable : TabbedPage
        {
            self.PropertyChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPagePropertyChangedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanged");

            return self;
        }

        public static TBindable WithTabbedPageBindingContextChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TabbedPage
        {
            self.BindingContextChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPageBindingContextChangedHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BindingContextChanged");

            return self;
        }

        public static TBindable WithTabbedPagePropertyChangingEvent<TBindable>(this TBindable self,
            Xamarin.Forms.PropertyChangingEventHandler handlerAction) where TBindable : TabbedPage
        {
            self.PropertyChanging += handlerAction;

            return self;
        }

        public static TBindable ClearTabbedPagePropertyChangingHandlers<TBindable>(this TBindable self) where TBindable : TabbedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanging");

            return self;
        }
        
        public static TBindable BindBarBackgroundColorTabbedPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TabbedPage
                => self.Bind(TabbedPage.BarBackgroundColorProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindBarTextColorTabbedPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TabbedPage
                => self.Bind(TabbedPage.BarTextColorProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}