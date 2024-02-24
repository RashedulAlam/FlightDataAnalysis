﻿namespace FlightDataAnalysis.Business.Services.Implementations
{
    using AutoMapper;
    using FlightDataAnalysis.Business.Models;
    using FlightDataAnalysis.Data.Provider;

    /// <inheritdoc />
    public class FlightService : IFlightService
    {
        private readonly IDataProvider provider;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlightService"/> class.
        /// </summary>
        /// <param name="provider">The data provider.</param>
        /// <param name="mapper">The mapper.</param>
        public FlightService(IDataProvider provider, IMapper mapper)
        {
            this.provider = provider;
            this.mapper = mapper;
        }

        /// <inheritdoc/>
        public IReadOnlyCollection<Flight> GetFlights()
        {
            var flights = this.provider.GetFlights();

            return this.mapper.Map<IReadOnlyCollection<Flight>>(flights);
        }

        /// <inheritdoc/>
        public Flight GetFlightById(int id)
        {
            var flight = this.provider.GetFlightById(id);

            return this.mapper.Map<Flight>(flight);
        }

        /// <inheritdoc/>
        public IReadOnlyCollection<FlightOption> GetFlightOptions()
        {
            var flights = this.provider.GetFlights();

            return this.mapper.Map<IReadOnlyCollection<FlightOption>>(flights);
        }
    }
}
