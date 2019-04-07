﻿using System.Collections.Generic;
using TUI.Domain.SimulatorFlights;

namespace TUI.SimulatorFlights.Domain
{
    public interface IPersistenceService
    {
        void SaveFlight(IFlight flight);
        IFlight GetFlight(string flightName);

        ICollection<IFlight> GetFlights();
    }
}
