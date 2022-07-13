using Metrics.Objects;
using Prometheus;
using System;
using System.Web.Hosting;
using System.Web.Http;

namespace Metrics
{
    public class MetricsManager : IRegisteredObject
    {
        private volatile static MetricsManager _Instance;
        private static object _SyncRoot = new Object(); //for multithreading atomic operations
        public static MetricsManager Instance { get { return _Instance; } }

        public static void Create()
        {
            lock (_SyncRoot)
            {
                if (_Instance == null)
                {
                    _Instance = new MetricsManager();
                }
            }
        }

        private void Stop()
        {
            lock (_SyncRoot)
            {
            }
        }

        void IRegisteredObject.Stop(bool immediate)
        {
            Stop();
        }

        public static void RegisterRoutes()
        {
            AspNetMetricServer.RegisterRoutes(GlobalConfiguration.Configuration);
        }

        public static MetricsCounter CreateCounter(string name, string help, params string[] labelNames)
        {
            return new MetricsCounter(Prometheus.Metrics.CreateCounter(name, help, labelNames));
        }

        public static MetricsGauge CreateGauge(string name, string help, params string[] labelNames)
        {
            return new MetricsGauge(Prometheus.Metrics.CreateGauge(name, help, labelNames));
        }

        public static MetricsSummary CreateSummary(string name, string help, params string[] labelNames)
        {
            return new MetricsSummary(Prometheus.Metrics.CreateSummary(name, help, labelNames));
        }

        public static MetricsHistogram CreateHistogram(string name, string help, params string[] labelNames)
        {
            return new MetricsHistogram(Prometheus.Metrics.CreateHistogram(name, help, labelNames));
        }
    }
}
