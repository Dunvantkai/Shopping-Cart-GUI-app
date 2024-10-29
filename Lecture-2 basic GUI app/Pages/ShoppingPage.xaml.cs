namespace Lecture_2_basic_GUI_app.Pages;

public partial class ShoppingPage : ContentPage
{
	public ObservableCollection<Shopping> Shoppings { get; set; } = new();
	public ShoppingPage()
	{
		InitializeComponent();
		Shoppings.Add(new Shopping { Name = "Item 1", Count = 1, });
        Shoppings.Add(new Shopping { Name = "Item 2", Count = 2, });
        ShoppingsCollView.ItemsSource = Shoppings;
    }

    private void AddBtn_click(object sender, EventArgs e)
    {
        string item = ItemNameEntry.Text;
        if (string.IsNullOrWhiteSpace(item))
        {
            DisplayAlert("Error", "Invaiid name", "Okay");
            return;
        }
        if(int.TryParse(ItemCountEntry.Text, out int count) == false)
        {
            DisplayAlert("Error", "Invaiid quantity", "Okay");
            return;
        }
        Shoppings.Add(new Shopping { Name = item.Trim(), Count = count  });
        ItemNameEntry.Text = string.Empty;
        ItemCountEntry.Text = string.Empty;
    }

    private void DelBtn_click(object sender, EventArgs e)
    {
        string item = ItemNameEntry.Text;
        if (string.IsNullOrWhiteSpace(item))
        {
            DisplayAlert("Error", "Invaiid name", "Okay");
            return;
        }
        var itemToRemove = Shoppings.FirstOrDefault(each => string.Equals(each.Name, item.Trim()));
        if (itemToRemove != null)
        {
            Shoppings.Remove(itemToRemove);
        }
    } 

    private void DelLasBtn_click(object sender, EventArgs e)
    {
        var item = Shoppings.FirstOrDefault();
        if (item != null) Shoppings.Remove(item);
        /*Shoppings.Remove(Shoppings.FirstOrDefault());*/
    }
}