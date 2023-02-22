#Airport ✈️

We are going to develop a system that simulates the operation of an airport!

Requirements:

- The airport is open 24/7
- The airport has two landing/takeoff runways
- Currently 5 airlines work at this airport
- On each runway, we can only have 1 plane taking off or landing at a time
- Airlines can only use one of the runways, for example:
  - GOL can only use runway 1 and AZUl can only use runway 2
- Never leave two flights at the same time on a runway
- The landing and takeoff time must be parameterized. Example: GOL takes 5 minutes to land and disembark, while AZUL takes 15 minutes.
- The planes of each airline before boarding and after landing must be taxied to the parking lot until the next flight takes place.
- Each plane must control its fuel level, for that it must have a route control and how much fuel is consumed.
- A plane that left the airport must have a return time, for example:
  - GOL plane leaves at 2pm and returns at 6pm
- Each airline works with a different plane model
- Each plane holds a number of passengers
- Always 10 minutes before boarding or disembarking, the airport system must launch an alert informing
- Planes that fly on low fuel must be reported as lost.

Rules:

1- All airport events must happen asynchronously;
2- All data must be stored in a bank so that we can have greater control;
3- The loading and unloading action must be chained, following real life and its stages.

To be continued...
