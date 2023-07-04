// Synchronous - not working properly
Console.SetCursorPosition(0, 1);

while (!Console.KeyAvailable || Console.ReadKey().Key != ConsoleKey.Escape)
{
    var c = Console.GetCursorPosition();
    Console.SetCursorPosition(10, 0);
    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    Console.SetCursorPosition(c.Left, c.Top);

    Thread.Sleep(1000);
}

// Asynchronous
var clockTimer =  new System.Timers.Timer(1000);
clockTimer.Elapsed += ClockTimerTick;
clockTimer.Start();


void ClockTimerTick(object? sender, System.Timers.ElapsedEventArgs e)
{
    var c = Console.GetCursorPosition();
    Console.SetCursorPosition(10, 0);
    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    Console.SetCursorPosition(c.Left, c.Top);
}

while (!Console.KeyAvailable || Console.ReadKey().Key != ConsoleKey.Escape)
{
}

clockTimer.Stop();
