using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyresDegradationSimulator.Core
{
    public class TyreDegradationSimulationFactory
    {
        public static TyreDegradationSimulation GetSimulation(TyreDegradationParameters parameters)
        {
            return new TyreDegradationSimulation(parameters);
        }
    }
}
