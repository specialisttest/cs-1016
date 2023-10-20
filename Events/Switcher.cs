using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    //public delegate void Electricity(object sender);
    
    public class Switcher
    {

        //public event Electricity ElectricityOn;
        public event Action<object> ElectricityOn;

        public void SwitchOn()
        {
            Console.WriteLine("Выключатель включен");
            //if (ElectricityOn != null)
            //    ElectricityOn(this);
            //    ElectricityOn.Invoke(this);
            ElectricityOn?.Invoke(this);

            //Delegate[] dlg = ElectricityOn.GetInvocationList()

            // async call
            // only single method
            //ElectricityOn?.BeginInvoke(this, callback)

        }
    }
}
