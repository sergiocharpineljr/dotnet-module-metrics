using Prometheus;

namespace Metrics.Objects
{
    public class MetricsCounter
    {

        internal Counter Counter { get; }

        public MetricsCounter(Counter counter)
        {
            Counter = counter;
        }

        public void Inc(double increment = 1)
        {
            Counter.Inc(increment);
        }

        public void IncWithLabels(double increment = 1, params string[] labelValues)
        {
            Counter.WithLabels(labelValues).Inc(increment);
        }

        public void IncTo(double targetValue)
        {
            Counter.IncTo(targetValue);
        }

        public void IncToWithLabels(double targetValue, params string[] labelValues)
        {
            Counter.WithLabels(labelValues).IncTo(targetValue);
        }

        public void Publish()
        {
            Counter.Publish();
        }

        public void Unpublish()
        {
            Counter.Unpublish();
        }
    }
}
