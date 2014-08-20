using System;
using Xamarin.Forms;

namespace GridviewExample
{
	public class ItemCell : ViewCell
	{
		public ItemCell ()
		{
			//base.C
			Label itemLabel = new Label ();
			Label hello = new Label ();
			hello.Text = "hello???";

			itemLabel.SetBinding (Label.TextProperty, "ItemName");

			var layout = new StackLayout {
				//				Padding = new Thickness(20, 0, 0, 0),
				//				Orientation = StackOrientation.Horizontal,
				//				HorizontalOptions = LayoutOptions.StartAndExpand,
				//				BackgroundColor = Color.Transparent,
				////				Children = {label, tick}
				///

				//BackgroundColor = Color.Transparent,
				//WidthRequest = 500,
				Children = {
					itemLabel,
					hello
				}
			};

			View = layout;
		}

		protected override void OnBindingContextChanged ()
		{
			// Fixme : this is happening because the View.Parent is getting 
			// set after the Cell gets the binding context set on it. Then it is inheriting
			// the parents binding context.
			//			View.BindingContext = BindingContext;
			base.OnBindingContextChanged ();
		}
	}
}

