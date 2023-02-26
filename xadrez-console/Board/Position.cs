
namespace Board
{
    internal class Position
    {
        public int line { get; set; }
        public int column { get; set; }

        public Position(int line, int column)
        {
            this.line = line;
            this.column = column;
        }

        public override string ToString()
        {
            return $"Line: [{line}], Column: [{column}].";
        }
    }
}
