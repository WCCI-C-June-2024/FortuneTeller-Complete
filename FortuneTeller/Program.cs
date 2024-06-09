using FortuneTeller;

//Startup applcation

//Setup Console I/O
ConsoleDisplay display = new ConsoleDisplay($"Welcome to the Fortune Teller");

//Create new Processor
ProcessUsers process = new ProcessUsers(display);

// Run Processor
process.StartProcess();
