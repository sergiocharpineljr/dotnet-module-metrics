using Prometheus;

namespace Metrics.Objects
{
    public class MetricsGauge
    {
        internal Gauge Gauge { get; }

        public MetricsGauge(Gauge gauge)
        {
            Gauge = gauge;
        }

        public void Inc(double increment = 1)
        {
            Gauge.Inc(increment);
        }

        public void IncWithLabels(double increment = 1, params string[] labelValues)
        {
            Gauge.WithLabels(labelValues).Inc(increment);
        }

        public void IncTo(double targetValue)
        {
            Gauge.IncTo(targetValue);
        }

        public void IncToWithLabels(double targetValue, params string[] labelValues)
        {
            Gauge.WithLabels(labelValues).IncTo(targetValue);
        }

        public void Publish()
        {
            Gauge.Publish();
        }
        public void Unpublish()
        {
            Gauge.Unpublish();
        }

        public void Dec(double decrement = 1)
        {
            Gauge.Dec(decrement);
        }

        public void DecWithLabels(double decrement = 1, params string[] labelValues)
        {
            Gauge.WithLabels(labelValues).Dec(decrement);
        }

        public void DecTo(double targetValue)
        {
            Gauge.DecTo(targetValue);
        }

        public void DecToWithLabels(double targetValue, params string[] labelValues)
        {
            Gauge.WithLabels(labelValues).DecTo(targetValue);
        }

        public void Set(double val)
        {
            Gauge.Set(val);
        }

        public void SetWithLabels(double val, params string[] labelValues)
        {
            Gauge.WithLabels(labelValues).Set(val);
        }
    }
}
