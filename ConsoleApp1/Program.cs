class Program
{
    static void Main(string[] args)
    {

        Stack<Crate> stack1 = new Stack<Crate>();
        Stack<Crate> stack2 = new Stack<Crate>();
        Stack<Crate> stack3 = new Stack<Crate>();


        stack1.Push(new Crate("Z"));
        stack1.Push(new Crate("N"));
        stack2.Push(new Crate("M"));
        stack2.Push(new Crate("C"));
        stack2.Push(new Crate("D"));
        stack3.Push(new Crate("P"));


        List<Move> moves = new List<Move>
{
new Move(1, stack2, stack1),
new Move(3, stack1, stack3),
new Move(2, stack2, stack1),
new Move(1, stack1, stack2)
};


        foreach (var move in moves)
        {
            for (int i = 0; i < move.Count; i++)
            {
                Crate crate = move.From.Pop();
                move.To.Push(crate);
            }
        }


        Console.WriteLine(stack1.Peek().Type + stack2.Peek().Type + stack3.Peek().Type);

    }
}

class Crate
{
    public string Type { get; set; }

    public Crate(string type)
    {
        Type = type;
    }
}

class Move
{
    public int Count { get; set; }
    public Stack<Crate> From { get; set; }
    public Stack<Crate> To { get; set; }

    public Move(int count, Stack<Crate> from, Stack<Crate> to)
    {
        Count = count;
        From = from;
        To = to;
    }
}