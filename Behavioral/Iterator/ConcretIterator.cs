namespace Iterator
{
    public class ConcretIterator : Iterator
    {
        private ConcretAggregate _aggregate;
        private int _current = 0;

        public ConcretIterator(ConcretAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        
        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
                ret = _aggregate[++_current];

            return ret;
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }
    }
}