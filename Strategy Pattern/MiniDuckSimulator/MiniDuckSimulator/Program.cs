using MiniDuckSimulator;

Duck duck = new RubberDuck();

duck.Display();
duck.PerformQauck();
duck.PerformFLy();

duck.QuackBehavior = new Quacks();
duck.PerformQauck();