int a = 2;
Console.WriteLine($"Hello, World! {a}");
Console.WriteLine("This is a demonstration program!");

// Array of console colors to cycle through
ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

for (int x = 1; x <= 15; x++)
{
    // Set the console foreground color to a color from the array
    // Use the modulus operator to cycle through the array
    Console.ForegroundColor = colors[x % colors.Length];

    // Ensure that the color is not the background color to maintain readability
    if (Console.ForegroundColor != Console.BackgroundColor)
    {
        Console.WriteLine($"Hello {x}");
    }
    else
    {
        // If the selected foreground color is the same as the background, skip this color
        Console.ForegroundColor = (ConsoleColor)(((int)Console.ForegroundColor + 1) % colors.Length);
        Console.WriteLine($"Hello {x}");
    }
}
// Reset the console color after the loop
Console.ResetColor();

