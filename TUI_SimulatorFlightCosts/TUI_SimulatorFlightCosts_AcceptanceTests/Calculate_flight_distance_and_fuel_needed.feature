Feature: Calculate_flight_distance_and_fuel_needed	
# vitesse avion
Scenario: Determine distance between airport London and airport Roissy Charles De Gaulles
	Given A flight which has a departure airport with GPS Position (London - 51.5048, 0.052745500000014545)
	And has a destination airport with GPS Position (Roissy Charles De Gaulle - 49.007, 2.559790000000021)
	And the aircraft fuel consumption per distance/flight time (10000 L/km/h) + takeoff effort (10000 L)
	And the aircraft has an average speed 900 km/h
	And is registered in control tower like 'Roissy Charles De Gaulle - London'
	When the simulator calculate travel distance for the flight 'Roissy Charles De Gaulle - London'
	Then the travel distance was 340 km

Scenario: Determine fuel consumption between airport London and airport Roissy Charles De Gaulles
	Given A flight which has a departure airport with GPS Position (London - 51.5048, 0.052745500000014545)
	And has a destination airport with GPS Position (Roissy Charles De Gaulle - 49.007, 2.559790000000021)
	And the aircraft fuel consumption per distance/flight time (10000 L/km/h) + takeoff effort (10000 L)
	And the aircraft has an average speed 900 km/h
	And is registered in control tower like 'Roissy Charles De Gaulle - London'
	When the simulator calculate the fuel consumption for the flight 'Roissy Charles De Gaulle - London'
	Then the total fuel consumption was 70000 L
