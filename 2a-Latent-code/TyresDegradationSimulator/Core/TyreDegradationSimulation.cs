
namespace TyresDegradationSimulator.Core
{
    public class TyreDegradationSimulation
    {
        protected readonly TyreDegradationParameters _parameters;

        public TyreDegradationSimulation(TyreDegradationParameters parameters)
        {
            _parameters = parameters;
        }

        public virtual decimal LapTime(int lapNumber)
        {
            return _parameters.IdealLapTime
                              + _parameters.DegradationPerLap * lapNumber;
        }
    }
}
