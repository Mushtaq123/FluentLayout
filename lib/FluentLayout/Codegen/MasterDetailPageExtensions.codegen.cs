// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class MasterDetailPageExtensions
    {


        public static TBindable WithMasterDetailPageIsPresentedChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.IsPresentedChanged += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageIsPresentedChangedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "IsPresentedChanged");

            return self;
        }

        public static TBindable WithMasterDetailPageBackButtonPressedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.BackButtonPressedEventArgs> handlerAction) where TBindable : MasterDetailPage
        {
            self.BackButtonPressed += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageBackButtonPressedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BackButtonPressed");

            return self;
        }

        public static TBindable WithMasterDetailPageLayoutChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.LayoutChanged += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageLayoutChangedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "LayoutChanged");

            return self;
        }

        public static TBindable WithMasterDetailPageAppearingEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.Appearing += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageAppearingHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Appearing");

            return self;
        }

        public static TBindable WithMasterDetailPageDisappearingEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.Disappearing += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageDisappearingHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Disappearing");

            return self;
        }

        public static TBindable WithMasterDetailPageChildrenReorderedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.ChildrenReordered += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageChildrenReorderedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildrenReordered");

            return self;
        }

        public static TBindable WithMasterDetailPageFocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : MasterDetailPage
        {
            self.Focused += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageFocusedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Focused");

            return self;
        }

        public static TBindable WithMasterDetailPageMeasureInvalidatedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.MeasureInvalidated += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageMeasureInvalidatedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "MeasureInvalidated");

            return self;
        }

        public static TBindable WithMasterDetailPageSizeChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.SizeChanged += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageSizeChangedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "SizeChanged");

            return self;
        }

        public static TBindable WithMasterDetailPageUnfocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : MasterDetailPage
        {
            self.Unfocused += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageUnfocusedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Unfocused");

            return self;
        }

        public static TBindable WithMasterDetailPageBatchCommittedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> handlerAction) where TBindable : MasterDetailPage
        {
            self.BatchCommitted += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageBatchCommittedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BatchCommitted");

            return self;
        }

        public static TBindable WithMasterDetailPageFocusChangeRequestedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.VisualElement.FocusRequestArgs> handlerAction) where TBindable : MasterDetailPage
        {
            self.FocusChangeRequested += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageFocusChangeRequestedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "FocusChangeRequested");

            return self;
        }

        public static TBindable WithMasterDetailPageChildAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : MasterDetailPage
        {
            self.ChildAdded += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageChildAddedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildAdded");

            return self;
        }

        public static TBindable WithMasterDetailPageChildRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : MasterDetailPage
        {
            self.ChildRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageChildRemovedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildRemoved");

            return self;
        }

        public static TBindable WithMasterDetailPageDescendantAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : MasterDetailPage
        {
            self.DescendantAdded += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageDescendantAddedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantAdded");

            return self;
        }

        public static TBindable WithMasterDetailPageDescendantRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : MasterDetailPage
        {
            self.DescendantRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageDescendantRemovedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantRemoved");

            return self;
        }

        public static TBindable WithMasterDetailPagePlatformSetEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.PlatformSet += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPagePlatformSetHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PlatformSet");

            return self;
        }

        public static TBindable WithMasterDetailPagePropertyChangedEvent<TBindable>(this TBindable self,
            System.ComponentModel.PropertyChangedEventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.PropertyChanged += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPagePropertyChangedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanged");

            return self;
        }

        public static TBindable WithMasterDetailPageBindingContextChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.BindingContextChanged += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPageBindingContextChangedHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BindingContextChanged");

            return self;
        }

        public static TBindable WithMasterDetailPagePropertyChangingEvent<TBindable>(this TBindable self,
            Xamarin.Forms.PropertyChangingEventHandler handlerAction) where TBindable : MasterDetailPage
        {
            self.PropertyChanging += handlerAction;

            return self;
        }

        public static TBindable ClearMasterDetailPagePropertyChangingHandlers<TBindable>(this TBindable self) where TBindable : MasterDetailPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanging");

            return self;
        }
        
        public static TBindable BindIsGestureEnabledMasterDetailPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : MasterDetailPage
                => self.Bind(MasterDetailPage.IsGestureEnabledProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindIsPresentedMasterDetailPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : MasterDetailPage
                => self.Bind(MasterDetailPage.IsPresentedProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindMasterBehaviorMasterDetailPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : MasterDetailPage
                => self.Bind(MasterDetailPage.MasterBehaviorProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}