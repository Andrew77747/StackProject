namespace StackProject
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var stack = new Stack("a", "b", "c");

            // size = 3, Top = 'c'
            Console.WriteLine($"size = {stack.Size}, Top = '{stack.Top}'");

            var deleted = stack.Pop();

            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {stack.Size}");
            stack.Add("d");

            // size = 3, Top = 'd'
            Console.WriteLine($"size = {stack.Size}, Top = '{stack.Top}'");

            stack.Pop();
            stack.Pop();
            stack.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {stack.Size}, Top = {(stack.Top == null ? "null" : stack.Top)}");
            stack.Pop();

            stack = new Stack("a", "b", "c");
            stack.Merge(new Stack("1", "2", "3"));
            // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний
            
            stack = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            // в стеке s теперь элементы -  "c", "b", "a" "3", "2", "1", "В", "Б", "А" <- верхний
        }
    }
}