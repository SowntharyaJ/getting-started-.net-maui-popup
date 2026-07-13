namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClickToShowPopup_Clicked(object sender, EventArgs e)
        {
            popup.Show();

            // Shows SfPopup at the center.
            //popup.Show();

            // Shows SfPopup at the specified X and y position.
            //popup.Show(100, 100);

            // Shows SfPopup at the position relative to the specified view.
            //popup.ShowRelativeToView(label, RelativePosition.AlignBottom);
        }
    }
}
