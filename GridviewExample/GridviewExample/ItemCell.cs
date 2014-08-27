using System;
using Xamarin.Forms;

namespace GridviewExample
{
	public class ItemCell : ViewCell
	{
		public ItemCell ()
		{


			Label itemLabel = new Label()
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			itemLabel.SetBinding (Label.TextProperty, "ItemName");


			var layout = new StackLayout {

				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Gray,

				Children = {
					itemLabel
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

