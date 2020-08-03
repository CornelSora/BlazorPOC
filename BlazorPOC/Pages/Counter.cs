using System;
using System.Collections.Generic;
using POC.ComponentsLibrary.Map;
using System.Linq;
using System.Threading.Tasks;
using POC.ComponentsLibrary.Vue;

namespace BlazorPOC.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        public VueMessage vueMessage { get; set; }

        private Marker BaseMarker = new Marker { Description = $"This is a PWA POC", ShowPopup = false, X = 26.096306, Y = 44.439663 };
        protected override Task OnInitializedAsync()
        {
            MapMarkers = new List<Marker>
            {
                BaseMarker
            };
            return base.OnInitializedAsync();
        }

        private void IncrementCount()
        {
            this.currentCount++;
            var newMarker = new Marker { Description = $"This is a PWA POC" + this.currentCount, ShowPopup = false, X = BaseMarker.X + 0.001 * this.currentCount, Y = BaseMarker.Y + 0.001 * this.currentCount };
            MapMarkers.Add(newMarker);
            vueMessage.IncrementText(currentCount);
        }
    }
}
