// See https://aka.ms/new-console-template for more information

List<string> days = new List<string> {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
int overtime = 0;
int weeklyHours = 0;
int totalTimeWorked;
const int regWeeklyHours = 40;
const int regDayHours = 8;

foreach (var day in days)
{
    int dayHoursWorked;
    Console.WriteLine("How many hours worked on " + day + "?");
    var dayHoursWorkedEntered = Console.ReadLine();
    int.TryParse(dayHoursWorkedEntered, out dayHoursWorked);
    if (dayHoursWorked > regDayHours)
    {
        overtime += dayHoursWorked - regDayHours;
        weeklyHours += regDayHours;  
    }
    else
    {
        weeklyHours += dayHoursWorked;
    }
}
if (weeklyHours > regWeeklyHours)
{
    overtime += weeklyHours - regWeeklyHours;
    totalTimeWorked = overtime + regWeeklyHours;
}
else
{
    totalTimeWorked = overtime + weeklyHours;
}

var endRegHoursWorked = weeklyHours > regWeeklyHours ? regWeeklyHours : weeklyHours;
Console.WriteLine("You've worked " + totalTimeWorked + " hours.");
Console.WriteLine("You have " + overtime + " hours of overtime and " + endRegHoursWorked + " hours of regular pay");