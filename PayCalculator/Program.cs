// See https://aka.ms/new-console-template for more information

List<string> days = new List<string> {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
int overtime = 0;
int weeklyHours = 0;
int totalTimeWorked;
const int regWeeklyHours = 40;
const int regDayHours = 8;

foreach (var day in days)
{
    float dayHoursWorked;
    Console.WriteLine("How many hours worked on " + day + "?");
    var dayHoursWorkedEntered = Console.ReadLine();

    while (!float.TryParse(dayHoursWorkedEntered, out dayHoursWorked) || string.IsNullOrEmpty(dayHoursWorkedEntered) || dayHoursWorked < 0)
    {
        Console.WriteLine("Please enter an valid number of 0 or greater.");
        dayHoursWorkedEntered = Console.ReadLine();
    }
    
    int dayHoursWorkedRounded = (int)Math.Round(dayHoursWorked);
    if (dayHoursWorked > regDayHours)
    {
        overtime += dayHoursWorkedRounded - regDayHours;
        weeklyHours += regDayHours;  
    }
    else
    {
        weeklyHours += dayHoursWorkedRounded;
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