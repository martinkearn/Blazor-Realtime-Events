using System;

namespace BlazorServerRealtime.Services.Interfaces
{
    public interface ICounterService
    {
        /// <summary>
        /// Adds a number to the counter.
        /// </summary>
        /// <param name="numberToAdd">The number to add to the counter.</param>
        /// <returns>The new counter total.</returns>
        int Add(int numberToAdd);

        /// <summary>
        /// An event handler that fires whenever the counter changes.
        /// </summary>
        event EventHandler<int> CounterChanged;
    }
}
