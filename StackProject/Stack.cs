namespace StackProject
{
    public class Stack
    {
        private StackItem? _item;
        public string? Top => _item?.Value;
        public int Size
        {
            get
            {
                var count = 0;
                var current = _item;
                
                while (current != null)
                {
                    count++;
                    current = current.Previous;
                }
        
                return count;
            }
        }
        
        public Stack(params string[] stackElements)
        {
            foreach (var item in stackElements)
            {
                Add(item);
            }
        }
        
        public void Add(string item)
        {
            _item = new StackItem(item, _item);
        }
        
        public string Pop()
        {
            if (_item == null)
            {
                throw new InvalidOperationException("Стек пустой");
            }

            var topItem = _item.Value;
            _item = _item.Previous;
            return topItem;
        }
        
        public static Stack Concat(params Stack[] stackElements)
        {
            var result = new List<string>();

            foreach (var stack in stackElements)
            {
                while (stack.Size > 0)
                {
                    result.Add(stack.Pop());
                }
            }

            return new Stack(result.ToArray());
        }
        
        private class StackItem
        {
            public string Value { get; }
            public StackItem? Previous { get; }
            
            public StackItem(string value, StackItem? previous)
            {
                Value = value;
                Previous = previous;
            }
        }
    }
}