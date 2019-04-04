Feature: Calculate_flight_distance_and_fuel_needed	

Scenario: Determine distance and fuel consumption between airport London and airport Roissy Charles De Gaulles
	Given A flight which has a departure airport with GPS Position (London - 51.5048, 0.052745500000014545)
	And has a destination airport with GPS Position (Roissy Charlles De Gaulle - 49.007, 2.559790000000021)
	And the aircraft fuel consumption per distance/flight time (10000 L/km/h) + takeoff effort (10000 L/km/h)
	When the flight takes place
	Then the travel distance was 340 km
	And the total fuel consumption was 70000 L
