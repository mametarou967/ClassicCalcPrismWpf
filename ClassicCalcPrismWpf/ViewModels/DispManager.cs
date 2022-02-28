using ClassicCalcPrismWpf.Model.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicCalcPrismWpf.ViewModels
{
    // Disp class
    class DispManager : IObserver<InputNumberEvent>, IObserver<CalcResultEvent>
    {
        Action<string> action;
        public DispManager(Action<string> action)
        {
            this.action = action;
            action("0");
        }

        public void OnNext(InputNumberEvent value)
        {
            if (value.InputStatus == InputStatus.Inputting)
            {
                action(value.Number.ToString());
            }
        }

        public void OnNext(CalcResultEvent value)
        {
            action(value.Number.ToString());
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

    }
}
