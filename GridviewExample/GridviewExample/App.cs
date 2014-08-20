using System;
using Xamarin.Forms;

namespace GridviewExample
{
	public class App
	{
		public static Page GetMainPage ()
		{	

			GridView ItemGridView = new GridView {
				ColumnSpacing = 5,
				RowSpacing = 5,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};


			ItemGridView.ItemTemplate = new DataTemplate (typeof (ItemCell));

			ItemGridView.ItemsSource = new ItemObject [] { 
				new ItemObject {ItemName = "Buy pears`"}, 
				new ItemObject {ItemName = "Buy oranges`"},
				new ItemObject {ItemName = "Buy mangos`"}, 
				new ItemObject {ItemName = "Buy apples`"},
				new ItemObject {ItemName = "Buy bananas`"}
						};


			return new ContentPage { 
				Content = ItemGridView

			};


		}
	}
}

