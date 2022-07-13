using Prometheus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics.Objects
{
    public class MetricsHistogram
    {
        internal Histogram Histogram { get; }

        public MetricsHistogram(Histogram histogram)
        {
            Histogram = histogram;
        }

        public static double[] ExponentialBuckets(double start, double factor, int count)
        {
            return Histogram.ExponentialBuckets(start, factor, count);
        }

        public static double[] LinearBuckets(double start, double width, int count)
        {
            return Histogram.LinearBuckets(start, width, count);
        }

        public void Observe(double val)
        {
            Histogram.Observe(val);
        }

        public void Observe(double val, long count)
        {
            Histogram.Observe(val, count);
        }

        public void Publish()
        {
            Histogram.Publish();
        }

        public void Unpublish()
        {
            Histogram.Unpublish();
        }
    }
}
