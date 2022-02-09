namespace Issue1292Repro
{
    public class Class1
    {
        public static bool DoSomething(string foo)
        {
            return ExpectOneOf(foo ?? "hello2") switch
            {
                "hello" => true,
                "hello2" => true
            };
        }

        private static string ExpectOneOf(string foo)
        {
            return foo;
        }
    }
}