using Variance;

var invariantPuzzleProducer = new InvariantProducer<Puzzle>();
Console.WriteLine(invariantPuzzleProducer.Produce().GetType().Name);

var invariantCombinationPuzzleProducer = new InvariantProducer<CombinationPuzzle>();
Console.WriteLine(invariantCombinationPuzzleProducer.Produce().GetType().Name);

// Can't do this:
// invariantPuzzleProducer = invariantCombinationPuzzleProducer;

// Can't do this as well:
// IInvariantProducer<Puzzle> explicitInvariantProducer = new InvariantProducer<CombinationPuzzle>();

var covariantPuzzleProducer = new CovariantProducer<Puzzle>();
Console.WriteLine(covariantPuzzleProducer.Produce().GetType().Name);

var covariantCombinationPuzzleProducer = new CovariantProducer<CombinationPuzzle>();
Console.WriteLine(covariantCombinationPuzzleProducer.Produce().GetType().Name);

// Can't do this either:
// covariantPuzzleProducer = covariantCombinationPuzzleProducer;

// But you can do this:
ICovariantProducer<Puzzle> explicitCovariantProducer = new CovariantProducer<CombinationPuzzle>();

// Or this:
IReadOnlyList<Puzzle> puzzles = new List<CombinationPuzzle>();