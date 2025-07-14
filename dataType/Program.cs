namespace dataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            
            string name = "의쟈쓰"; //문자열

            var x = 10; //타입 자동 추론
            var msg = "Hi";

            Console.WriteLine(x);
            Console.WriteLine(msg);
            Console.WriteLine($"안녕하세요 {name}");
            Console.WriteLine($"덧셈: {a + b}");
            Console.WriteLine($"뺄셈: {a - b}");
            Console.WriteLine($"곱셈: {a * b}");
            Console.WriteLine($"나눗셈: {a / b}");
            Console.WriteLine($"나머지: {a % b}");

        }
    }
}
