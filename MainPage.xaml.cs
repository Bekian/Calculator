

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;
    int count2 = 0;
    int total = 0;

    public MainPage()
	{
		InitializeComponent();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
        TotalingText();
    }
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        count2++;

        if (count2 == 1)
            CounterBtn2.Text = $"Clicked {count2} time";
        else
            CounterBtn2.Text = $"Clicked {count2} times";

        SemanticScreenReader.Announce(CounterBtn2.Text);
        TotalingText();
    }

    private void TotalingText()
    {
        total = count + count2;

        if (total == 1)
            TotalText.Text = $"Clicked both buttons: {total} time";
        else
            TotalText.Text = $"Clicked both buttons: {total} times";

        SemanticScreenReader.Announce(TotalText.Text);
    }
}

