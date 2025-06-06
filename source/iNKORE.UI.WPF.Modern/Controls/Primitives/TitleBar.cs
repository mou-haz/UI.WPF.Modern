﻿using iNKORE.UI.WPF.Modern.Controls.Helpers;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace iNKORE.UI.WPF.Modern.Controls.Primitives
{
    [StyleTypedProperty(Property = StylePropertyName, StyleTargetType = typeof(TitleBarControl))]
    [StyleTypedProperty(Property = ButtonStylePropertyName, StyleTargetType = typeof(TitleBarButton))]
    [StyleTypedProperty(Property = BackButtonStylePropertyName, StyleTargetType = typeof(TitleBarButton))]
    public static class TitleBar
    {
        private const string StylePropertyName = "Style";
        private const string ButtonStylePropertyName = "ButtonStyle";
        private const string BackButtonStylePropertyName = "BackButtonStyle";

        public static ComponentResourceKey HeightKey { get; } = new ComponentResourceKey(typeof(TitleBar), nameof(HeightKey));

        #region Background

        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached(
                "Background",
                typeof(Brush),
                typeof(TitleBar));

        public static Brush GetBackground(Window window)
        {
            return (Brush)window.GetValue(BackgroundProperty);
        }

        public static void SetBackground(Window window, Brush value)
        {
            window.SetValue(BackgroundProperty, value);
        }

        #endregion

        #region Foreground

        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached(
                "Foreground",
                typeof(Brush),
                typeof(TitleBar));

        public static Brush GetForeground(Window window)
        {
            return (Brush)window.GetValue(ForegroundProperty);
        }

        public static void SetForeground(Window window, Brush value)
        {
            window.SetValue(ForegroundProperty, value);
        }

        #endregion

        #region InactiveBackground

        public static readonly DependencyProperty InactiveBackgroundProperty =
            DependencyProperty.RegisterAttached(
                "InactiveBackground",
                typeof(Brush),
                typeof(TitleBar));

        public static Brush GetInactiveBackground(Window window)
        {
            return (Brush)window.GetValue(InactiveBackgroundProperty);
        }

        public static void SetInactiveBackground(Window window, Brush value)
        {
            window.SetValue(InactiveBackgroundProperty, value);
        }

        #endregion

        #region InactiveForeground

        public static readonly DependencyProperty InactiveForegroundProperty =
            DependencyProperty.RegisterAttached(
                "InactiveForeground",
                typeof(Brush),
                typeof(TitleBar));

        public static Brush GetInactiveForeground(Window window)
        {
            return (Brush)window.GetValue(InactiveForegroundProperty);
        }

        public static void SetInactiveForeground(Window window, Brush value)
        {
            window.SetValue(InactiveForegroundProperty, value);
        }

        #endregion

        #region Style

        public static readonly DependencyProperty StyleProperty =
            DependencyProperty.RegisterAttached(
                StylePropertyName,
                typeof(Style),
                typeof(TitleBar));

        public static Style GetStyle(Window window)
        {
            return (Style)window.GetValue(StyleProperty);
        }

        public static void SetStyle(Window window, Style value)
        {
            window.SetValue(StyleProperty, value);
        }

        #endregion

        #region ButtonStyle

        public static readonly DependencyProperty ButtonStyleProperty =
            DependencyProperty.RegisterAttached(
                ButtonStylePropertyName,
                typeof(Style),
                typeof(TitleBar));

        public static Style GetButtonStyle(Window window)
        {
            return (Style)window.GetValue(ButtonStyleProperty);
        }

        public static void SetButtonStyle(Window window, Style value)
        {
            window.SetValue(ButtonStyleProperty, value);
        }

        #endregion

        #region IsIconVisible

        public static readonly DependencyProperty IsIconVisibleProperty =
            DependencyProperty.RegisterAttached(
                "IsIconVisible",
                typeof(bool),
                typeof(TitleBar),
                new PropertyMetadata(false));

        public static bool GetIsIconVisible(Window window)
        {
            return (bool)window.GetValue(IsIconVisibleProperty);
        }

        public static void SetIsIconVisible(Window window, bool value)
        {
            window.SetValue(IsIconVisibleProperty, value);
        }

        #endregion

        #region IsBackButtonVisible

        public static readonly DependencyProperty IsBackButtonVisibleProperty =
            DependencyProperty.RegisterAttached(
                "IsBackButtonVisible",
                typeof(bool),
                typeof(TitleBar));

        public static bool GetIsBackButtonVisible(Window window)
        {
            return (bool)window.GetValue(IsBackButtonVisibleProperty);
        }

        public static void SetIsBackButtonVisible(Window window, bool value)
        {
            window.SetValue(IsBackButtonVisibleProperty, value);
        }

        #endregion

        #region IsBackEnabled

        /// <summary>
        /// Identifies the IsBackEnabled attached property.
        /// </summary>
        public static readonly DependencyProperty IsBackEnabledProperty =
            DependencyProperty.RegisterAttached(
                "IsBackEnabled",
                typeof(bool),
                typeof(TitleBar),
                new PropertyMetadata(true));

        /// <summary>
        /// Gets a value that indicates whether the back button is enabled or disabled.
        /// </summary>
        /// <param name="window">The element from which to read the property value.</param>
        /// <returns>true if the back button is enabled; otherwise, false. The default is true.</returns>
        public static bool GetIsBackEnabled(Window window)
        {
            return (bool)window.GetValue(IsBackEnabledProperty);
        }

        /// <summary>
        /// Sets a value that indicates whether the back button is enabled or disabled.
        /// </summary>
        /// <param name="window">The element on which to set the attached property.</param>
        /// <param name="value">The property value to set.</param>
        public static void SetIsBackEnabled(Window window, bool value)
        {
            window.SetValue(IsBackEnabledProperty, value);
        }

        #endregion

        #region BackButtonCommand

        public static readonly DependencyProperty BackButtonCommandProperty =
            DependencyProperty.RegisterAttached(
                "BackButtonCommand",
                typeof(ICommand),
                typeof(TitleBar));

        public static ICommand GetBackButtonCommand(Window window)
        {
            return (ICommand)window.GetValue(BackButtonCommandProperty);
        }

        public static void SetBackButtonCommand(Window window, ICommand value)
        {
            window.SetValue(BackButtonCommandProperty, value);
        }

        #endregion

        #region BackButtonCommandParameter

        public static readonly DependencyProperty BackButtonCommandParameterProperty =
            DependencyProperty.RegisterAttached(
                "BackButtonCommandParameter",
                typeof(object),
                typeof(TitleBar));

        public static object GetBackButtonCommandParameter(Window window)
        {
            return window.GetValue(BackButtonCommandParameterProperty);
        }

        public static void SetBackButtonCommandParameter(Window window, object value)
        {
            window.SetValue(BackButtonCommandParameterProperty, value);
        }

        #endregion

        #region BackButtonCommandTarget

        public static readonly DependencyProperty BackButtonCommandTargetProperty =
            DependencyProperty.RegisterAttached(
                "BackButtonCommandTarget",
                typeof(IInputElement),
                typeof(TitleBar));

        public static IInputElement GetBackButtonCommandTarget(Window window)
        {
            return (IInputElement)window.GetValue(BackButtonCommandTargetProperty);
        }

        public static void SetBackButtonCommandTarget(Window window, IInputElement value)
        {
            window.SetValue(BackButtonCommandTargetProperty, value);
        }

        #endregion

        #region BackButtonStyle

        public static readonly DependencyProperty BackButtonStyleProperty =
            DependencyProperty.RegisterAttached(
                BackButtonStylePropertyName,
                typeof(Style),
                typeof(TitleBar));

        public static Style GetBackButtonStyle(Window window)
        {
            return (Style)window.GetValue(BackButtonStyleProperty);
        }

        public static void SetBackButtonStyle(Window window, Style value)
        {
            window.SetValue(BackButtonStyleProperty, value);
        }

        #endregion

        #region ExtendViewIntoTitleBar

        public static readonly DependencyProperty ExtendViewIntoTitleBarProperty =
            DependencyProperty.RegisterAttached(
                "ExtendViewIntoTitleBar",
                typeof(bool),
                typeof(TitleBar),
                new PropertyMetadata(false));

        public static bool GetExtendViewIntoTitleBar(Window window)
        {
            return (bool)window.GetValue(ExtendViewIntoTitleBarProperty);
        }

        public static void SetExtendViewIntoTitleBar(Window window, bool value)
        {
            window.SetValue(ExtendViewIntoTitleBarProperty, value);
        }

        #endregion

        #region SystemOverlayLeftInset

        internal static readonly DependencyPropertyKey SystemOverlayLeftInsetPropertyKey =
            DependencyProperty.RegisterAttachedReadOnly(
                "SystemOverlayLeftInset",
                typeof(double),
                typeof(TitleBar),
                new PropertyMetadata(0d));

        public static readonly DependencyProperty SystemOverlayLeftInsetProperty =
            SystemOverlayLeftInsetPropertyKey.DependencyProperty;

        public static double GetSystemOverlayLeftInset(Window window)
        {
            return (double)window.GetValue(SystemOverlayLeftInsetProperty);
        }

        internal static void SetSystemOverlayLeftInset(Window window, double value)
        {
            window.SetValue(SystemOverlayLeftInsetPropertyKey, value);
        }

        #endregion

        #region SystemOverlayRightInset

        internal static readonly DependencyPropertyKey SystemOverlayRightInsetPropertyKey =
            DependencyProperty.RegisterAttachedReadOnly(
                "SystemOverlayRightInset",
                typeof(double),
                typeof(TitleBar),
                new PropertyMetadata(0d));

        public static readonly DependencyProperty SystemOverlayRightInsetProperty =
            SystemOverlayRightInsetPropertyKey.DependencyProperty;

        public static double GetSystemOverlayRightInset(Window window)
        {
            return (double)window.GetValue(SystemOverlayRightInsetProperty);
        }

        internal static void SetSystemOverlayRightInset(Window window, double value)
        {
            window.SetValue(SystemOverlayRightInsetPropertyKey, value);
        }

        #endregion

        #region Height

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.RegisterAttached(
                "Height",
                typeof(double),
                typeof(TitleBar),
                new PropertyMetadata(36d, HeightProperty_ValueChanged));

        private static void HeightProperty_ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window win)
            {
                WindowHelper.UpdateWindowChrome(win);
            }
        }

        public static double GetHeight(Window window)
        {
            return (double)window.GetValue(HeightProperty);
        }

        public static void SetHeight(Window window, double value)
        {
            window.SetValue(HeightProperty, value);
        }

        #endregion

        #region CloseButtonAvailability

        public static readonly DependencyProperty CloseButtonAvailabilityProperty =
            DependencyProperty.RegisterAttached(
                "CloseButtonAvailability",
                typeof(TitleBarButtonAvailability),
                typeof(TitleBar),
                new PropertyMetadata(TitleBarButtonAvailability.Auto));


        public static TitleBarButtonAvailability GetCloseButtonAvailability(Window window)
        {
            return (TitleBarButtonAvailability)window.GetValue(CloseButtonAvailabilityProperty);
        }

        public static void SetCloseButtonAvailability(Window window, TitleBarButtonAvailability value)
        {
            window.SetValue(CloseButtonAvailabilityProperty, value);
        }

        public static readonly DependencyProperty MaximizeButtonAvailabilityProperty =
            DependencyProperty.RegisterAttached(
                "MaximizeButtonAvailability",
                typeof(TitleBarButtonAvailability),
                typeof(TitleBar),
                new PropertyMetadata(TitleBarButtonAvailability.Auto));


        public static TitleBarButtonAvailability GetMaximizeButtonAvailability(Window window)
        {
            return (TitleBarButtonAvailability)window.GetValue(MaximizeButtonAvailabilityProperty);
        }

        public static void SetMaximizeButtonAvailability(Window window, TitleBarButtonAvailability value)
        {
            window.SetValue(MaximizeButtonAvailabilityProperty, value);
        }

        public static readonly DependencyProperty MinimizeButtonAvailabilityProperty =
            DependencyProperty.RegisterAttached(
                "MinimizeButtonAvailability",
                typeof(TitleBarButtonAvailability),
                typeof(TitleBar),
                new PropertyMetadata(TitleBarButtonAvailability.Auto));


        public static TitleBarButtonAvailability GetMinimizeButtonAvailability(Window window)
        {
            return (TitleBarButtonAvailability)window.GetValue(MinimizeButtonAvailabilityProperty);
        }

        public static void SetMinimizeButtonAvailability(Window window, TitleBarButtonAvailability value)
        {
            window.SetValue(MinimizeButtonAvailabilityProperty, value);
        }

        #endregion

        #region ButtonGlyphStyle

        public static readonly DependencyProperty ButtonGlyphStyleProperty =
            DependencyProperty.RegisterAttached(
                "ButtonGlyphStyle",
                typeof(TitleBarButtonGlyphStyle?),
                typeof(TitleBar),
                new PropertyMetadata(null));

        public static TitleBarButtonGlyphStyle? GetButtonGlyphStyle(Window window)
        {
            return (TitleBarButtonGlyphStyle?)window.GetValue(ButtonGlyphStyleProperty);
        }

        public static void SetButtonGlyphStyle(Window window, TitleBarButtonGlyphStyle? value)
        {
            window.SetValue(ButtonGlyphStyleProperty, value);
        }

        #endregion

        #region BackRequested

        /// <summary>
        /// Identifies the BackRequested routed event.
        /// </summary>
        public static readonly RoutedEvent BackRequestedEvent =
            EventManager.RegisterRoutedEvent(
                "BackRequested",
                RoutingStrategy.Bubble,
                typeof(EventHandler<BackRequestedEventArgs>),
                typeof(TitleBar));

        public static void AddBackRequestedHandler(Window window, EventHandler<BackRequestedEventArgs> handler)
        {
            window.AddHandler(BackRequestedEvent, handler);
        }

        public static void RemoveBackRequestedHandler(Window window, EventHandler<BackRequestedEventArgs> handler)
        {
            window.RemoveHandler(BackRequestedEvent, handler);
        }

        internal static void RaiseBackRequested(Window window)
        {
            window.RaiseEvent(new BackRequestedEventArgs(window));
        }

        #endregion

        #region ResizeBorderThickness

        /// <summary>
        /// Identifies the ResizeBorderThickness attached property.
        /// This is internal, because the user value will be overridden by the WindowHelper.
        /// So you should better NOT use this property directly, but you can if you want to.
        /// </summary>
        public static readonly DependencyProperty ResizeBorderThicknessProperty =
            DependencyProperty.RegisterAttached(
                "ResizeBorderThickness",
                typeof(Thickness),
                typeof(TitleBar),
                new PropertyMetadata(new Thickness(0)));

        // See: https://github.com/iNKORE-NET/UI.WPF.Modern/issues/153
        public static Thickness GetResizeBorderThickness(Window window)
        {
            return (Thickness)window.GetValue(ResizeBorderThicknessProperty);
        }

        internal static void SetResizeBorderThickness(Window window, Thickness value)
        {
            window.SetValue(ResizeBorderThicknessProperty, value);
        }

        #endregion
    }


    public enum TitleBarButtonAvailability
    {
        Auto,
        Collapsed,
        Disabled,
        Enabled
    }

    public enum TitleBarButtonGlyphStyle
    {
        MDL2,
        Fluent,
    }
}
