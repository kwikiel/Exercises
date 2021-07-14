//
// This is only a SKELETON file for the 'Gigasecond' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

// PEDAC 
// Problem: Add 10^9 (1000 millions or giga) seconds to the datetime provided, return it
// Example: (2011, 3, 25) => '2043-01-01T01:46:40Z'
// Data structure:
// t - input which is "2011-04-25T00:00:00.000Z" 
// Algo
// Convert input to the datetime object 
// Perform substraction on datetime object 
// Return date time object ( or string depending of which one test would require)
// Also side note: Add the solution to the GitHub somehow
const GIGASECOND_IN_MS = (10 ** 9) * 1000


export const gigasecond = (t) => {
  const gtime = new Date((GIGASECOND_IN_MS+t.getTime())); // this way we get number of milliseconds 
  return gtime;
};

