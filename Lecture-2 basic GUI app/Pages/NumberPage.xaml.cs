namespace Lecture_2_basic_GUI_app.Pages;

public partial class NumberPage : ContentPage
{
	public NumberPage()
	{
		InitializeComponent();
	}

	private void NumberEnrtyBtn_click(object sender, EventArgs e)
	{
		if (!int.TryParse(NumberEntry.Text, out int num))
		{
			DisplayAlert("Error", "Invalid input", "Okay");
			return;
		}
		string msg = IsPerfectSquare(num) ? "is a" : "is not a";
	/*	string msg;          //is the same thing just longer
		if (IsPerfectSquare(num) == false)
		{
			msg = "is not";
		}
		else
		{
			msg = "is";
		}*/
        ResultLabel.Text = $"Results: {num} {msg} perfect square";
    }
	public static bool IsPerfectSquare(int number)
	{
		int sqrt = (int) Math.Sqrt(number);
		return sqrt * sqrt == number;
	}
}