using Xamarin.Forms;

namespace TextOnImage
{
	public partial class TextOnImage : AbsoluteLayout
	{
	    public static readonly BindableProperty TextProperty = BindableProperty.Create<TextOnImage, string>(p => p.Text,
	        string.Empty, 
            BindingMode.TwoWay, 
            null, 
            propertyChanged: OnTextDetailChanged);

	    private static void OnTextDetailChanged(BindableObject bindable, string oldvalue, string newvalue)
	    {
	        var control = bindable as TextOnImage;
            if(control == null) return;
	        control.LabelImage.Text = newvalue;
	    }

	    public static readonly BindableProperty ColorProperty = BindableProperty.Create<TextOnImage, Color>(p => p.Color,
	        Color.Black, BindingMode.Default, null, OnTextColorChanged);

	    private static void OnTextColorChanged(BindableObject bindable, Color oldvalue, Color newvalue)
	    {
            var control = bindable as TextOnImage;
            if (control == null) return;
            control.LabelImage.TextColor = newvalue;
        }

	    public static readonly BindableProperty SourceProperty =
	        BindableProperty.Create<TextOnImage, ImageSource>(p => p.Source, null, BindingMode.Default, null,
	            OnImageSourceChanged);

	    private static void OnImageSourceChanged(BindableObject bindable, ImageSource oldvalue, ImageSource newvalue)
	    {
            var control = bindable as TextOnImage;
            if (control == null) return;
	        control.ImageDisplay.Source = newvalue;
	    }

	    public string Text {
			get{ return (string)GetValue (TextProperty); }
			set{ SetValue (TextProperty, value); }
		}

		public Color Color {
			get{ return (Color)GetValue (ColorProperty); }
			set{ SetValue (ColorProperty, value); }
		}

		public ImageSource Source {
			get{ return (ImageSource)GetValue (SourceProperty); }
			set{ SetValue (SourceProperty, value); }
		}

		public TextOnImage ()
		{
			InitializeComponent ();
		}
	}
}