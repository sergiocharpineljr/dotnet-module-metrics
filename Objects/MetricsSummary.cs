using Prometheus;

namespace Metrics.Objects
{
    public class MetricsSummary
    {
        internal Summary Summary { get; }

        public MetricsSummary(Summary summary)
        {
            Summary = summary;
        }

        public void Observe(double val)
        {
            Summary.Observe(val);
        }

        public void ObserveWithLabels(double val, params string[] labelValues)
        {
            Summary.WithLabels(labelValues).Observe(val);
        }

        public void Publish()
        {
            Summary.Publish();
        }

        public void Unpublish()
        {
            Summary.Unpublish();
        }
    }
}
