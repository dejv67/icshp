using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    class Stats
    {
        public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);

        public int Correct { get; private set; }
        public int Missed { get; private set; }
        public int Accurancy { get; private set; }

        public event UpdatedStatsEventHandler UpdatedStats;

        private void OnUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        private void Update(bool correctKey)
        {

        }




    }
}
