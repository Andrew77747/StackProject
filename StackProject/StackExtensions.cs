namespace StackProject
{
    public static class StackExtensions
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            var reversedElements = new List<string>();
            
            while (s2.Size > 0)
            {
                reversedElements.Add(s2.Pop());
            }
            
            foreach (var element in reversedElements)
            {
                s1.Add(element);
            }
        }
    }
}