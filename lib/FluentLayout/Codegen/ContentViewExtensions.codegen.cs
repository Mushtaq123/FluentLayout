// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class ContentViewExtensions
    {


        public static TBindable WithLayoutChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : ContentView
        {
            self.LayoutChanged += handlerAction;

            return self;
        }

        public static TBindable ClearLayoutChangedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "LayoutChanged");

            return self;
        }

        public static TBindable WithChildrenReorderedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : ContentView
        {
            self.ChildrenReordered += handlerAction;

            return self;
        }

        public static TBindable ClearChildrenReorderedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildrenReordered");

            return self;
        }

        public static TBindable WithFocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : ContentView
        {
            self.Focused += handlerAction;

            return self;
        }

        public static TBindable ClearFocusedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Focused");

            return self;
        }

        public static TBindable WithMeasureInvalidatedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : ContentView
        {
            self.MeasureInvalidated += handlerAction;

            return self;
        }

        public static TBindable ClearMeasureInvalidatedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "MeasureInvalidated");

            return self;
        }

        public static TBindable WithSizeChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : ContentView
        {
            self.SizeChanged += handlerAction;

            return self;
        }

        public static TBindable ClearSizeChangedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "SizeChanged");

            return self;
        }

        public static TBindable WithUnfocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : ContentView
        {
            self.Unfocused += handlerAction;

            return self;
        }

        public static TBindable ClearUnfocusedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Unfocused");

            return self;
        }

        public static TBindable WithBatchCommittedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> handlerAction) where TBindable : ContentView
        {
            self.BatchCommitted += handlerAction;

            return self;
        }

        public static TBindable ClearBatchCommittedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BatchCommitted");

            return self;
        }

        public static TBindable WithFocusChangeRequestedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.VisualElement.FocusRequestArgs> handlerAction) where TBindable : ContentView
        {
            self.FocusChangeRequested += handlerAction;

            return self;
        }

        public static TBindable ClearFocusChangeRequestedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "FocusChangeRequested");

            return self;
        }

        public static TBindable WithChildAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : ContentView
        {
            self.ChildAdded += handlerAction;

            return self;
        }

        public static TBindable ClearChildAddedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildAdded");

            return self;
        }

        public static TBindable WithChildRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : ContentView
        {
            self.ChildRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearChildRemovedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildRemoved");

            return self;
        }

        public static TBindable WithDescendantAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : ContentView
        {
            self.DescendantAdded += handlerAction;

            return self;
        }

        public static TBindable ClearDescendantAddedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantAdded");

            return self;
        }

        public static TBindable WithDescendantRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : ContentView
        {
            self.DescendantRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearDescendantRemovedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantRemoved");

            return self;
        }

        public static TBindable WithPlatformSetEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : ContentView
        {
            self.PlatformSet += handlerAction;

            return self;
        }

        public static TBindable ClearPlatformSetEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PlatformSet");

            return self;
        }

        public static TBindable WithPropertyChangedEvent<TBindable>(this TBindable self,
            System.ComponentModel.PropertyChangedEventHandler handlerAction) where TBindable : ContentView
        {
            self.PropertyChanged += handlerAction;

            return self;
        }

        public static TBindable ClearPropertyChangedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanged");

            return self;
        }

        public static TBindable WithBindingContextChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : ContentView
        {
            self.BindingContextChanged += handlerAction;

            return self;
        }

        public static TBindable ClearBindingContextChangedEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BindingContextChanged");

            return self;
        }

        public static TBindable WithPropertyChangingEvent<TBindable>(this TBindable self,
            Xamarin.Forms.PropertyChangingEventHandler handlerAction) where TBindable : ContentView
        {
            self.PropertyChanging += handlerAction;

            return self;
        }

        public static TBindable ClearPropertyChangingEventHandlers<TBindable>(this TBindable self) where TBindable : ContentView
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanging");

            return self;
        }
        
        public static TBindable BindContentContentView<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : ContentView
                => self.Bind(ContentView.ContentProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}