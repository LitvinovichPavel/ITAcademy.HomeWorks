using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    public interface IUser
    {
        public int OrderNumber();                                                           //номер заказа
        public void EnterUserName(out string userName);                                     //имя покупателя
        public int PhoneNumber();                                                           //номер телефона
        public void Location(out string userCity, out string userStreet,                    //адрес доставки
                             out string userHouseNumber, out string userNumberApartament);
    }
}