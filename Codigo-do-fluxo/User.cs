public class user{

string nome;
Int64 id;
public void SetNome(String n)
{
    nome= n;
 

}

public void setid(Int64 i){
    id=i;
}
public string GetNome()
{

return nome;

}
public Int64  Getid()
{

return id;

}
}

namespace YourNamespace
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Get the parent grid
                var parent = button.Parent as Grid;
                if (parent != null)
                {
                    // Get the Entry control from the same row
                    var entry = parent.Children.OfType<Entry>().FirstOrDefault(e => Grid.GetRow(e) == Grid.GetRow(button));
                    if (entry != null)
                    {
                        entry.Text = string.Empty;
                    }
                }
            }
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Handle save logic here
        }
    }
}
