namespace TabletopArmyCreator.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for DialogViewShell.xaml
    /// </summary>
    public partial class DialogViewShell : MahApps.Metro.SimpleChildWindow.ChildWindow
    {
        public DialogViewShell()
        {
            InitializeComponent();
        }

        public override void EndInit()
        {
            base.EndInit();
            this.ConfirmButton.Click += (sender, e) => { this.IsOpen = false; };
            this.CancelButton.Click += (sender, e) => { this.IsOpen = false; };
        }
    }
}
