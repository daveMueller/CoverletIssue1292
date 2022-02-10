namespace Issue1292Repro
{
    public class Class1
    {
        public static bool DoSomething(string? foo)
        {
            var baa = foo ?? "hello2";
            return baa switch
            {
                "hello" => true,  
                string keyWord => true,
                //_ => true,   //this as default has 100% coverage
            };
        }
    }
}