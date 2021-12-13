using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Core;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Shapes;

namespace KxamarinToolkit
{
    public class MediaElementView : MediaElement
    {

        public MediaElementView()
        {
        }
       

        public override IDispatcher Dispatcher => base.Dispatcher;

        public override bool Equals(object obj)
        {
            return obj is MediaElementView view &&
                   EqualityComparer<IDispatcher>.Default.Equals(Dispatcher, view.Dispatcher) &&
                   EqualityComparer<object>.Default.Equals(BindingContext, view.BindingContext) &&
                   AutomationId == view.AutomationId &&
                   ClassId == view.ClassId &&
                   EqualityComparer<IList<Effect>>.Default.Equals(Effects, view.Effects) &&
                   Id.Equals(view.Id) &&
                   EqualityComparer<VisualElement>.Default.Equals(ParentView, view.ParentView) &&
                   StyleId == view.StyleId &&
                   EqualityComparer<ReadOnlyCollection<Element>>.Default.Equals(LogicalChildren, view.LogicalChildren) &&
                   EqualityComparer<Element>.Default.Equals(RealParent, view.RealParent) &&
                   EqualityComparer<Element>.Default.Equals(Parent, view.Parent) &&
                   EqualityComparer<IEffectControlProvider>.Default.Equals(EffectControlProvider, view.EffectControlProvider) &&
                   EqualityComparer<IPlatform>.Default.Equals(Platform, view.Platform) &&
                   EqualityComparer<INavigation>.Default.Equals(Navigation, view.Navigation) &&
                   EqualityComparer<Style>.Default.Equals(Style, view.Style) &&
                   EqualityComparer<IList<string>>.Default.Equals(StyleClass, view.StyleClass) &&
                   EqualityComparer<IList<string>>.Default.Equals(@class, view.@class) &&
                   EqualityComparer<NavigationProxy>.Default.Equals(NavigationProxy, view.NavigationProxy) &&
                   EqualityComparer<IVisual>.Default.Equals(Visual, view.Visual) &&
                   FlowDirection == view.FlowDirection &&
                   AnchorX == view.AnchorX &&
                   AnchorY == view.AnchorY &&
                   EqualityComparer<Color>.Default.Equals(BackgroundColor, view.BackgroundColor) &&
                   EqualityComparer<Brush>.Default.Equals(Background, view.Background) &&
                   EqualityComparer<IList<Behavior>>.Default.Equals(Behaviors, view.Behaviors) &&
                   EqualityComparer<Xamarin.Forms.Rectangle>.Default.Equals(Bounds, view.Bounds) &&
                   Height == view.Height &&
                   HeightRequest == view.HeightRequest &&
                   InputTransparent == view.InputTransparent &&
                   IsEnabled == view.IsEnabled &&
                   IsFocused == view.IsFocused &&
                   IsVisible == view.IsVisible &&
                   MinimumHeightRequest == view.MinimumHeightRequest &&
                   MinimumWidthRequest == view.MinimumWidthRequest &&
                   Opacity == view.Opacity &&
                   Rotation == view.Rotation &&
                   RotationX == view.RotationX &&
                   RotationY == view.RotationY &&
                   Scale == view.Scale &&
                   ScaleX == view.ScaleX &&
                   ScaleY == view.ScaleY &&
                   TabIndex == view.TabIndex &&
                   IsTabStop == view.IsTabStop &&
                   TranslationX == view.TranslationX &&
                   TranslationY == view.TranslationY &&
                   EqualityComparer<IList<TriggerBase>>.Default.Equals(Triggers, view.Triggers) &&
                   Width == view.Width &&
                   WidthRequest == view.WidthRequest &&
                   X == view.X &&
                   Y == view.Y &&
                   EqualityComparer<Geometry>.Default.Equals(Clip, view.Clip) &&
                   Batched == view.Batched &&
                   DisableLayout == view.DisableLayout &&
                   IsInNativeLayout == view.IsInNativeLayout &&
                   IsNativeStateConsistent == view.IsNativeStateConsistent &&
                   IsPlatformEnabled == view.IsPlatformEnabled &&
                   EqualityComparer<ResourceDictionary>.Default.Equals(Resources, view.Resources) &&
                   EqualityComparer<IGestureController>.Default.Equals(GestureController, view.GestureController) &&
                   EqualityComparer<IList<IGestureRecognizer>>.Default.Equals(GestureRecognizers, view.GestureRecognizers) &&
                   EqualityComparer<LayoutOptions>.Default.Equals(HorizontalOptions, view.HorizontalOptions) &&
                   EqualityComparer<Thickness>.Default.Equals(Margin, view.Margin) &&
                   EqualityComparer<LayoutOptions>.Default.Equals(VerticalOptions, view.VerticalOptions) &&
                   Aspect == view.Aspect &&
                   AutoPlay == view.AutoPlay &&
                   BufferingProgress == view.BufferingProgress &&
                   CanSeek == view.CanSeek &&
                   CurrentState == view.CurrentState &&
                   EqualityComparer<TimeSpan?>.Default.Equals(Duration, view.Duration) &&
                   IsLooping == view.IsLooping &&
                   KeepScreenOn == view.KeepScreenOn &&
                   ShowsPlaybackControls == view.ShowsPlaybackControls &&
                   Position.Equals(view.Position) &&
                   EqualityComparer<MediaSource>.Default.Equals(Source, view.Source) &&
                   VideoHeight == view.VideoHeight &&
                   VideoWidth == view.VideoWidth &&
                   Volume == view.Volume &&
                   Speed == view.Speed;
        }

        public override IList<GestureElement> GetChildElements(Point point)
        {
            return base.GetChildElements(point);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override SizeRequest GetSizeRequest(double widthConstraint, double heightConstraint)
        {
            return base.GetSizeRequest(widthConstraint, heightConstraint);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void ChangeVisualState()
        {
            base.ChangeVisualState();
        }

        protected override void InvalidateMeasure()
        {
            base.InvalidateMeasure();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }

        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
        }

        protected override void OnChildRemoved(Element child)
        {
            base.OnChildRemoved(child);
        }

        protected override void OnChildRemoved(Element child, int oldLogicalIndex)
        {
            base.OnChildRemoved(child, oldLogicalIndex);
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            return base.OnMeasure(widthConstraint, heightConstraint);
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }

        protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanging(propertyName);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
        }

        protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
        {
            return base.OnSizeRequest(widthConstraint, heightConstraint);
        }

        protected override void OnTabIndexPropertyChanged(int oldValue, int newValue)
        {
            base.OnTabIndexPropertyChanged(oldValue, newValue);
        }

        protected override void OnTabStopPropertyChanged(bool oldValue, bool newValue)
        {
            base.OnTabStopPropertyChanged(oldValue, newValue);
        }

        protected override int TabIndexDefaultValueCreator()
        {
            return base.TabIndexDefaultValueCreator();
        }

        protected override bool TabStopDefaultValueCreator()
        {
            return base.TabStopDefaultValueCreator();
        }
    }
}
