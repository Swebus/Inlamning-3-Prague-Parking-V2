using Spectre.Console;
bool exit = false;
string[] places = new string[101];

while (!exit)
{
    AnsiConsole.Write(
    new FigletText("Prague Parking")
        .LeftJustified()
        .Color(Color.Red));
    Console.WriteLine("\n\n\n\n\n");

    // Main menu selections
    var selection = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .PageSize(4)
            .AddChoices(new[] {
            "Park Vehicle",
            "Get Vehicle",
            "Show Parking Spaces",
            "Close Program",
            }));

    // Selection switch
    switch (selection)
    {
        case "Park Vehicle":
            {
                ParkVehicle();
                break;
            }
        case "Get Vehicle":
            {
                GetVehicle();
                break;
            }
        case "Show Parking Spaces":
            {
                ShowParkingSpaces();
                break;
            }
        case "Close Program":
            {
                exit = true;
                break;
            }
    }
    if (!exit)
    {
        Console.Write("Press a key to continue:\t");
        Console.ReadKey();
        Console.Clear();
    }
}



void ParkVehicle()
{
    Console.WriteLine("Bil parkerad!");
}

void GetVehicle()
{
    Console.WriteLine("Bil hämtad!");
}

void ShowParkingSpaces()
{
    var table = new Table();
    table.Expand();

    //for (int i = 0; i < places.Length; i++)
    //{
    //    if (places[i] != null)
    //    {
    //        table.AddColumn(places[i]).Centered();
    //    }
    //    else
    //    {
    //        table.AddColumn("").Centered();
    //    }
    //        for (int j = i; j < i + 10; j++)
    //    {
    //        if (places[i] != null)
    //        {
    //            table.AddRow(places[j]).Centered();
    //        }
    //        else
    //        {
    //            table.AddRow("").Centered();
    //        }
    //    }
       
    //}
   

    // Add some columns
    //table.AddColumn("Foo").Centered();
    //table.AddColumn("Bar").Centered();
    //table.AddColumn("Bar").Centered();
    //table.AddColumn("Bar").Centered();
    //table.AddColumn("Bar").Centered();
    //table.AddColumn("Bar").Centered();
    //table.AddColumn("Bar").Centered();
    //table.AddColumn("Bar").Centered();
    //table.AddColumn("Bar").Centered();
    //table.AddColumn("Bar").Centered();

    //// Add some rows
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");
    //table.AddRow("Baz", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux", "Qux");

    // Render the table to the console
    AnsiConsole.Write(table);
}