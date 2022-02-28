using ClassicCalcPrismWpf.Model;
using ClassicCalcPrismWpf.Model.Event;
using Prism.Commands;
using Prism.Mvvm;
using System;

namespace ClassicCalcPrismWpf.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ClassicCalcPrismWpf";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        // model
        CalcManager calcManager;
        InputManager inputManager;

        // viewModel
        DispManager dispManager;


        public MainWindowViewModel()
        {
            ClearManager();

            Button1 = new DelegateCommand(Button1Execute);
            Button2 = new DelegateCommand(Button2Execute);
            Button3 = new DelegateCommand(Button3Execute);
            Button4 = new DelegateCommand(Button4Execute);
            Button5 = new DelegateCommand(Button5Execute);
            Button6 = new DelegateCommand(Button6Execute);
            Button7 = new DelegateCommand(Button7Execute);
            Button8 = new DelegateCommand(Button8Execute);
            Button9 = new DelegateCommand(Button9Execute);
            ButtonAdd = new DelegateCommand(ButtonAddExecute);
            ButtonSub = new DelegateCommand(ButtonSubExecute);
            ButtonMult = new DelegateCommand(ButtonMultExecute);
            ButtonDiv = new DelegateCommand(ButtonDivExecute);
            ButtonEqual = new DelegateCommand(ButtonEqualExecute);
            ButtonClear = new DelegateCommand(ButtonClearExecute);
        }

        void ClearManager()
        {
            // model
            calcManager = new CalcManager();
            inputManager = new InputManager();

            // view model
            dispManager = new DispManager((x) => CalcResult = x);

            // 参照
            inputManager.Subscribe(calcManager);
            inputManager.Subscribe(dispManager);
            calcManager.Subscribe(dispManager);

        }

        // Label
        private string _calcResult = string.Empty;
        public string CalcResult
        {
            get { return _calcResult; }
            set { SetProperty(ref _calcResult, value); }
        }

        // Command
        public DelegateCommand Button1 { get; }
        private void Button1Execute() => inputManager.InputNum("1");
        public DelegateCommand Button2 { get; }
        private void Button2Execute() => inputManager.InputNum("2");
        public DelegateCommand Button3 { get; }
        private void Button3Execute() => inputManager.InputNum("3");
        public DelegateCommand Button4 { get; }
        private void Button4Execute() => inputManager.InputNum("4");
        public DelegateCommand Button5 { get; }
        private void Button5Execute() => inputManager.InputNum("5");
        public DelegateCommand Button6 { get; }
        private void Button6Execute() => inputManager.InputNum("6");
        public DelegateCommand Button7 { get; }
        private void Button7Execute() => inputManager.InputNum("7");
        public DelegateCommand Button8 { get; }
        private void Button8Execute() => inputManager.InputNum("8");
        public DelegateCommand Button9 { get; }
        private void Button9Execute() => inputManager.InputNum("9");

        public DelegateCommand ButtonAdd { get; }
        private void ButtonAddExecute() => inputManager.InputOpp(Model.Event.InputOperation.Add);
        public DelegateCommand ButtonSub { get; }
        private void ButtonSubExecute() => inputManager.InputOpp(Model.Event.InputOperation.Sub);
        public DelegateCommand ButtonMult { get; }
        private void ButtonMultExecute() => inputManager.InputOpp(Model.Event.InputOperation.Mult);
        public DelegateCommand ButtonDiv { get; }
        private void ButtonDivExecute() => inputManager.InputOpp(Model.Event.InputOperation.Div);
        public DelegateCommand ButtonEqual { get; }
        private void ButtonEqualExecute() => inputManager.InputOpp(Model.Event.InputOperation.Equal);
        public DelegateCommand ButtonClear { get; }
        private void ButtonClearExecute() => ClearManager();

    }
}
