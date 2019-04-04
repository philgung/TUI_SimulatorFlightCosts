Feature: Calculate_flight_distance_and_fuel_needed
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given A flight which has a departure airport with GPS Position (,)
	And has a destination airport with GPS Position (,)
	And the aircraft fuel consumption per distance/flight time (10000 L/km/h) + takeoff effort (10000 L/km/h)
	When the flight takes place
	Then the travel distance was 340 km
	And the total fuel consumption was 70000 L
