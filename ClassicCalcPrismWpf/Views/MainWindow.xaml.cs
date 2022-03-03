using System.Windows;

namespace ClassicCalcPrismWpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private dynamic VM
        {
            get { return this.DataContext; }
        }

        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

            switch (e.Key)
            {
                case System.Windows.Input.Key.D1:
                    this.VM.Button1.Execute();
                    break;
                case System.Windows.Input.Key.D2:
                    this.VM.Button2.Execute();
                    break;
                case System.Windows.Input.Key.D3:
                    this.VM.Button3.Execute();
                    break;
                case System.Windows.Input.Key.D4:
                    this.VM.Button4.Execute();
                    break;
                case System.Windows.Input.Key.D5:
                    this.VM.Button5.Execute();
                    break;
                case System.Windows.Input.Key.D6:
                    this.VM.Button6.Execute();
                    break;
                case System.Windows.Input.Key.D7:
                    this.VM.Button7.Execute();
                    break;
                case System.Windows.Input.Key.D8:
                    this.VM.Button8.Execute();
                    break;
                case System.Windows.Input.Key.D9:
                    this.VM.Button9.Execute();
                    break;
                case System.Windows.Input.Key.OemPlus:
                    if (e.KeyboardDevice.Modifiers.HasFlag(System.Windows.Input.ModifierKeys.Shift))
                    {
                        this.VM.ButtonAdd.Execute();
                    }
                    break;
                case System.Windows.Input.Key.OemMinus:
                    this.VM.ButtonMinus.Execute();
                    break;
                case System.Windows.Input.Key.Oem1:
                    if (e.KeyboardDevice.Modifiers.HasFlag(System.Windows.Input.ModifierKeys.Shift))
                    { 
                        this.VM.ButtonMult.Execute();
                    }
                    break;
                case System.Windows.Input.Key.OemQuestion:
                    this.VM.ButtonDiv.Execute();
                    break;
            }

        }
    }
}
