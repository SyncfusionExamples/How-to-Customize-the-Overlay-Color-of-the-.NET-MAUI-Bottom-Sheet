namespace BottomSheetSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object? sender, ItemTappedEventArgs e)
        {
            bottomSheet.BottomSheetContent.BindingContext = e.Item;
            bottomSheet.Show();
        }

    }

}
