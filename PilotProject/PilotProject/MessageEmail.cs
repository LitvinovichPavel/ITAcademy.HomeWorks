using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace PilotProject
{
    class MessageEmail
    {
        public string UserEmail { get; set; }
        public void EmailImput()
        {
            //Пользователь вводит свою электронную почту.
            //В случае ввода пустого поля появится соответствующее сообщение.
            Console.Write($"Введите Ваш email: ");
            string userCheckMail = Console.ReadLine();
            userCheckMail = userCheckMail.Replace(" ", "");
            if (userCheckMail.Equals(""))
            {
                Console.WriteLine("!!!\a Поле не может быть пустым !!!");
                EmailImput();
            }
            else
            {
                UserEmail = userCheckMail;
            }
        }
        public void Message()
        {
            //Отправка сообщений на электронную почту.
            PriceAll priceAll = new PriceAll();
            int randonOrderNumber = NewUser.OrderNumberMethod();
            int port = 587;
            bool enableSSL = true;
            object realTime = DateTime.Now;
            string emailFrom = "test_sushi@mail.ru";                // адрес почты отправителя письма
            string password = "testpassword21";                     // пароль почты отправителя письма
            string emailTo = UserEmail;                             // адрес почты получателя письма
            string subject = "Доставка суши";                       // тема письма
            //Письмо сообщающее о том, что пользователь совершил заказ.
            string messageOrderCompleted = $"Время заказа: {realTime}.\nВаш заказ: №{randonOrderNumber} скомплектован. " +
                $"Сумма к оплате: {priceAll.Total()} руб.";    // текст письма
            string smtpAddress = "smtp.mail.ru";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(emailFrom);
            mail.To.Add(emailTo);
            mail.Subject = subject;
            mail.Body = messageOrderCompleted;

            using (SmtpClient smtp = new SmtpClient(smtpAddress, port))
            {
                smtp.Credentials = new NetworkCredential(emailFrom, password);
                smtp.EnableSsl = enableSSL;
                try
                {
                    smtp.Send(mail);                                // отправка сообщения
                }
                catch (Exception ex)
                {                                                   
                    Console.WriteLine($"\a!!! Ошибка !!!\nПисьмо на электронную почту не отправлено !!!: \n\a{ex.Message.ToString()}");
                }
            }
            //Письмо сообщающее о том, что заказ доставлен курьером.
            string messageOrderDelivered = $"\nВаш заказ: №{randonOrderNumber} доставлен курьером.";
            mail.Body = messageOrderDelivered;
            using (SmtpClient smtp = new SmtpClient(smtpAddress, port))
            {
                smtp.Credentials = new NetworkCredential(emailFrom, password);
                smtp.EnableSsl = enableSSL;
                try
                {
                    smtp.Send(mail);                                // отправка сообщения
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\a!!! Ошибка !!!\nПисьмо на электронную почту не отправлено !!!: \n\a{ex.Message.ToString()}");
                }
            }
            //Письмо сообщающее о том, что заказ оплачен.
            string messagePriceOk = $"\nВаш заказ: №{randonOrderNumber} оплачен. Спасибо!";
            mail.Body = messagePriceOk;
            using (SmtpClient smtp = new SmtpClient(smtpAddress, port))
            {
                smtp.Credentials = new NetworkCredential(emailFrom, password);
                smtp.EnableSsl = enableSSL;
                try
                {
                    smtp.Send(mail);                                // отправка сообщения
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\a!!! Ошибка !!!\nПисьмо на электронную почту не отправлено !!!: \n\a{ex.Message.ToString()}");
                }
            }
        }
    }
}
