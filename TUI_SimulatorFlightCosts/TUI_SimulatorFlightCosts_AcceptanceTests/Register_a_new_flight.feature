Feature: Register_a_new_flight	

Scenario: Register a new flight
	When A user enters a new flight called 'Roissy Paris Airport - London City Airport' on system
	Then The flight called 'Roissy Paris Airport - London City Airport' can be retrived on system
