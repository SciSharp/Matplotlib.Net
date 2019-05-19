using System;
using Python.Runtime;

namespace Matplotlib.Net
{
    public class PyPlot
    {
        public float[] YValues { get; private set; }

        public float[] XValues { get; private set; }

        public PyPlot()
        {

        }

        public PyPlot X(float[] values)
        {
            XValues = values;
            return this;
        }

        public PyPlot Y(float[] values)
        {
            YValues = values;
            return this;
        }

        public object Show()
        {
            using (Py.GIL())
            {
                dynamic mpl = Py.Import("matplotlib");
                dynamic plt = Py.Import("matplotlib.pyplot");

                plt.plot(XValues, YValues);
                plt.show();
            }

            return null;
        }
    }
}
