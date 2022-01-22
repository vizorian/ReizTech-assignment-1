// Reading inputs
Console.WriteLine("Please enter the hours (0-24)");
string inputHours = Console.ReadLine();
Console.WriteLine("\nPlease enter the minutes (0-60)");
string inputMinutes = Console.ReadLine();

double hours, minutes;

// Parsing inputs
try
{
    hours = double.Parse(inputHours);
    minutes = double.Parse(inputMinutes);
}
catch (Exception ex) { Console.WriteLine("\n" + ex.Message); return; }

// Checking if inputs are withing boundaries
if (hours < 0 || hours > 24 || minutes < 0 || minutes > 60) { Console.WriteLine("\nEntered incorrect time values, please try again."); return; }

// Calculating the lesser angle of an analog clock
// Trimming hours, because an analog clock is within 0-12
if (hours >= 12) hours -= 12;
// Checking if minutes are 60, if so, make them 0 for convenience
if (minutes == 60) minutes = 0;

// Calculating the degrees of the hour arrow, including the extra movement from the minute arrow
var degreesHours = (hours * 30) + (0.5 * minutes);
// Calculating the degrees of the minute arrow
var degreesMinutes = minutes * 6;
// Calculating the answer
var answer = Math.Abs((degreesHours - degreesMinutes + 180) % 360 - 180);

Console.WriteLine($"\nCalculated angle of the hour arrow: {degreesHours}");
Console.WriteLine($"\nCalculated angle of the minute arrow: {degreesMinutes}");
Console.WriteLine($"\nLesser angle between the hour and minute arrows of an analog clock: {answer}");