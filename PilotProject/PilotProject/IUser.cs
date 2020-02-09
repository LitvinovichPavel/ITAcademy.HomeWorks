using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    interface IUser
    {
        public void OrderNumber();   //номер заказа
        public void UserName();      //имя покупателя
        public void Price();         //общая стоимость
        public void PhoneNumber();   //номер телефона
        public void Location();      //адрес доставки
        public void AllOrder();      //список заказа
    }
}
