using System;

namespace BlazorServerRealtime.Services.Interfaces
{
    public interface ICounterService
    {
        /// <summary>
        /// Gets the current value of the counter.
        /// </summary>
        /// <returns>The current value of the counter.</returns>
        int Get();

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
