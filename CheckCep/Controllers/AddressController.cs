using Aspose.Email;
using CheckCep.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mail;

namespace CheckCep.Controllers
{
    public class AddressController : Controller
    {

        Uri baseAddress = new Uri("https://viacep.com.br/ws/");
        private readonly HttpClient _client;
        private IWebHostEnvironment _hostingEnvironment;

        public AddressController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View("HomeSite");

        }


        [HttpPost]
        public IActionResult Index(string cep)
        {
            var requisicaoWeb = WebRequest.CreateHttp(baseAddress + cep + "/json/");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWebDemo";

            Address take = new Address("", "", "", "", "");

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();

                take = JsonConvert.DeserializeObject<Address>(objResponse.ToString());

                /*Console.WriteLine(take.logradouro + " " + take.complemento + " " + take.localidade + " " + take.uf + " " + take.cep);*/
                /* streamDados.Close();
                 resposta.Close();*/

                User user = new User();


            }


            var outlook = new Email("smtp.office365.com", "", ENV.PASSWORD);

            outlook.SendEmail(
            emailsTo: new List<string>
            {
                ""
            },
            subject: "Teste", body: "Segue Anexo" );

            ViewBag.cep = take;

            return View("HomeSite");
        }
/*
        public static void SendEmail(User user)
        {
            Aspose.Email.MailMessage message = new Aspose.Email.MailMessage();

            message.Subject = "New message created by Aspose.Email for .NET";
            message.Body = "This is the body of the email.";
            
            message.From = new Aspose.Email.MailAddress(user.Email, "TESTnoME", false);

            message.To.Add(new Aspose.Email.MailAddress("robsonlmdsgoo@gmail.com", "Recipient 1", false));

            message.Save("EmailMessage.eml", SaveOptions.DefaultEml);
            message.Save("EmailMessage.emlx", SaveOptions.CreateSaveOptions(MailMessageSaveType.EmlxFormat));
            message.Save("EmailMessage.msg", SaveOptions.DefaultMsgUnicode);
            message.Save("EmailMessage.mhtml", SaveOptions.DefaultMhtml);
        }*/




        /*static async Task ExecuteEmail(User user, Address take)
        {
            var apiKey = Environment.GetEnvironmentVariable("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");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("robsonlmdsgoo@gmail.com", "Example User");
            var subject = "CheckCep - Seu ENDEREÇO";
            var to = new EmailAddress(user.Email, "Client");
            var plainTextContent = take.ToString();
            string html = plainTextContent;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, html);
            var response = await client.SendEmailAsync(msg);
        }*/




    }
}
