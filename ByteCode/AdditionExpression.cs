namespace ByteCode
{
    public class AdditionExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public AdditionExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public double Evaluate()
        {
            double left = _left.Evaluate();
            double right = _right.Evaluate();

            return left + right;
        }
    }
}