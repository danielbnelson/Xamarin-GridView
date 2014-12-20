using System;
using Xamarin.Forms;
using System.Linq;

namespace GridviewExample
{
	public class GridExample : ContentPage
	{

		private Grid grid;
		private int timesGridCreated = 0;

		public GridExample ()
		{
		
			grid = new Grid ();
			Button updateAll = new Button () {Text = "Update All"};
			Button updateOne = new Button () {Text = "Update One via replace"};
			Button updateOneDirectly = new Button () {Text = "Update One directly"};
		
			updateAll.Clicked += (sender, args) => {UpdateAll();};
			updateOne.Clicked += (sender, args) => {UpdateOne();};
			updateOneDirectly.Clicked += (sender, args) => {UpdateOneDirectly();};
			//grid.ColumnSpacing = 10;


			CreateGrid ();
		
			ScrollView scrollView = new ScrollView
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = grid
			};
//

			StackLayout stack = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = 10,
				Spacing = 10,
				Children = {updateOne, updateAll, updateOneDirectly, scrollView}
			};

			Content = stack;

		}


		private void CreateGrid(){
			timesGridCreated++;
			grid.Children.Clear ();

			for (int i = 0; i < 20; i++)
			{
				grid.Children.Add (CreateStackInGrid (i), 0, i);
			}

		}


		private StackLayout CreateStackInGrid(int index){

			Label label = new Label (){ Text = "Stack inside grid. Index=" };
			Label label2 = new Label (){ Text = index.ToString() };
			Label label3 = new Label (){ Text = ".Times created=" };
			Label label4 = new Label (){ Text = timesGridCreated.ToString() };


			return new StackLayout () {
				WidthRequest = 400, 
				HeightRequest = 100,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { label, label2, label3, label4 }
			};

		}

		private void UpdateOne(){
			int index = 1; //example of just one we want to update
			StackLayout stack = CreateStackInGrid (index * 12);
			stack.BackgroundColor = Color.Purple;

			//StackLayout stack = grid.Children.Cast<StackLayout> ().ElementAt (1);
			grid.Children.RemoveAt (index);
			grid.Children.Add (stack, 0,index);
		}

		private void UpdateOneDirectly(){
			int index = 2; //example of just one we want to update
			StackLayout stack =  grid.Children.Cast<StackLayout> ().ElementAt (index);
			stack.BackgroundColor = Color.Green;

			Label label = new Label (){ Text = "Added Label" };

			stack.Children.Add (label);

//			//StackLayout stack = grid.Children.Cast<StackLayout> ().ElementAt (1);
//			grid.Children.RemoveAt (index);
//			grid.Children.Add (stack, 0,index);
		}

		private void UpdateAll(){
			CreateGrid ();
		}
	}
}

