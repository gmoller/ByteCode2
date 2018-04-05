namespace ByteCode
{
    public class NumberExpression : IExpression
    {
        private readonly double _value;

        public NumberExpression(double value)
        {
            _value = value;
        }

        public double Evaluate()
        {
            return _value;
        }
    }
}