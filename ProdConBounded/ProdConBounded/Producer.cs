namespace ProdConBounded
{
    internal class Producer
    {
        private readonly BoundedBuffer _buffer;

        private readonly int _max;

        public Producer(BoundedBuffer buffer, int howManyToProduce)
        {
            _buffer = buffer;
            _max = howManyToProduce;
        }

        public void Run()
        {
            for (int i = 0; i < _max; i++)
            {
                _buffer.Put(i);
            }
        }
    }
}