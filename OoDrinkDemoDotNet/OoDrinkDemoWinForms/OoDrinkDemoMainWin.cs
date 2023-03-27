namespace OoDrinkDemoWinForms
{
    public partial class OoDrinkDemoMainWin : Form
    {
        private OoDrinkDemoMainViewModel? _ViewModel = null;
        public OoDrinkDemoMainWin()
        {
            InitializeComponent();
            CreateViewModel();
            AddDefaultDrinksToList();
        }

        private void CreateViewModel()
        {
            _ViewModel = new();
            _ViewModel.DrinkListChanged += ViewModel_DrinkListChanged;
        }

        private void AddDefaultDrinksToList()
        {
            _ViewModel?.AddDefaultDrinksToList();
        }

        private void ViewModel_DrinkListChanged(object? sender, EventArgs e)
        {
            lstDrinks.Items.Clear();
            //lstDrinks.Items.AddRange(new List<Object>( _ViewModel.DrinkDescriptions()));
            //lstDrinks. .Items.AddRange(new string[] { _ViewModel.DrinkDescriptions() } );
            lstDrinks.Items.AddRange(_ViewModel?.DrinkDescriptions()?.ToArray());
        }

    }
}