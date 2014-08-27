using System;
using Xamarin.Forms;

namespace GridviewExample
{
	public class GridViewExample : ContentPage
	{



		public GridViewExample ()
		{
			GridView gridView = new GridView {
				ColumnSpacing = 5,
				RowSpacing = 5,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};


			gridView.ItemSelected += (sender, e) => {
				ItemObject itemObject = (ItemObject)e.Value;
				DisplayAlert ("selected value", itemObject.ItemName, "ok");
			};

//			gridView.ItemSelected += (object sender, EventArgs<object> e) => {
//
//				//DisplayAlert ("", AppMessages.SIGNUP_MSG, AppMessages.CLOSE_ALERT);
//				DisplayAlert ("selected value", e.Value.ToString (), "ok", null);
//			};
//



			gridView.ItemTemplate = new DataTemplate (typeof (ItemCell));

			gridView.ItemsSource = new ItemObject [] { 
				new ItemObject {ItemName = "Item AAA"}, 
				new ItemObject {ItemName = "Item BBB"},
				new ItemObject {ItemName = "Item CCC"}, 
				new ItemObject {ItemName = "Item DDD"},
				new ItemObject {ItemName = "Item EEE"},
				new ItemObject {ItemName = "Item FFF"},
				new ItemObject {ItemName = "Item GGG"},
				new ItemObject {ItemName = "Item HHH"},
				new ItemObject {ItemName = "Item IIIIIIIII"},
				new ItemObject {ItemName = "Item AAA"}, 
				new ItemObject {ItemName = "Item BBB"},
				new ItemObject {ItemName = "Item CCC"}, 
				new ItemObject {ItemName = "Item DDD"},
				new ItemObject {ItemName = "Item EEE"},
				new ItemObject {ItemName = "Item FFF"},
				new ItemObject {ItemName = "Item GGG"},
				new ItemObject {ItemName = "Item HHH"},
			};


			StackLayout stack = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = 40,
				Spacing = 0,
				Children = {gridView}
			};

			var scrollview = new ScrollView {
				Content = stack
			};
//
			Content = scrollview;

		}
	}
}

