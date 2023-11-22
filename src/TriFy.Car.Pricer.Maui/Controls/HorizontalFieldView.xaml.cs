using Microsoft.Maui.Converters;
using System.ComponentModel;

namespace TriFy.Car.Pricer.Maui.Controls;

public partial class HorizontalFieldView : ContentView
{
    public static readonly BindableProperty DisplayNameProperty = BindableProperty.Create(nameof(DisplayName), typeof(string), typeof(VerticalFieldView), "Prueba");

    public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(Entry), default(bool));

    public static readonly BindableProperty KeyboardProperty = BindableProperty.Create(nameof(Keyboard), typeof(Keyboard), typeof(VerticalFieldView), Keyboard.Default,
        coerceValue: (o, v) => (Keyboard)v ?? Keyboard.Default);

    public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(string), typeof(VerticalFieldView), defaultBindingMode: BindingMode.TwoWay);

    public string DisplayName
    {
        get => (string)GetValue(DisplayNameProperty);
        set => SetValue(DisplayNameProperty, value);
    }

    [TypeConverter(typeof(KeyboardTypeConverter))]
    public Keyboard Keyboard
    {
        get => (Keyboard)GetValue(KeyboardProperty);
        set => SetValue(KeyboardProperty, value);
    }

    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public bool IsPassword
    {
        get => (bool)GetValue(IsPasswordProperty);
        set => SetValue(IsPasswordProperty, value);
    }

    public HorizontalFieldView()
    {
        InitializeComponent();
    }
}