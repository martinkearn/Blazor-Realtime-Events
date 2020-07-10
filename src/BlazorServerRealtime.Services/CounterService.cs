using BlazorServerRealtime.Services.Interfaces;
using System;

namespace BlazorServerRealtime.Services
{
    /// <summary>
    /// Concrete implementation of ICounterService.
    /// </summary>
    public class CounterService : ICounterService
    {
        private int counter;

        public CounterService()
        {
            counter = 0;
        }

        /// <inheritdoc />
        public int Add(int numberToAdd) 
        {
            counter += numberToAdd;
            CounterChanged?.Invoke(this, counter);
            return counter;
        }

        /// <inheritdoc />
        public event EventHandler<int> CounterChanged;
    }
}
