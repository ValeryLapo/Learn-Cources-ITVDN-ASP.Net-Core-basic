namespace _001.Context.Controller
{
    public class HomeController: Microsoft.AspNetCore.Mvc.Controller
    {
        public string Index()
        {
            //var elements = Request.Method;
            //string result = "";
            //foreach (var element in elements)
            //{
            //    result += $"{element.Key} = {element.Value} \n";
            //}

            return Request.Method;
        }
    }
}
