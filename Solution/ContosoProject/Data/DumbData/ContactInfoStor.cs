using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;


namespace Data.DumbData
{
    public static partial class Storage
    {
        public static List<ContactInfo> contactInfoCollection = new List<ContactInfo>() 
        {
            new ContactInfo()
            {
                City = "Днепропетровск",
                Adress = "ул. Каруна, д.8, кв.14",
                Telephone = "066-309-55-89",
                Email = "ContactKar@gmail.com"
            },
            new ContactInfo()
            {
                City = "Киев",
                Adress = "ул. Институтская, д.15, кв.12",
                Telephone = "097-543-17-25",
                Email = "ContactIns@gmail.com"
            },
            new ContactInfo()
            {
                City = "Львов",
                Adress = "ул. Малиновского, д.23, кв.9",
                Telephone = "067-495-33-22",
                Email = "ContactMal@gmail.com"
            },
            new ContactInfo()
            {
                City = "Миргород",
                Adress = "ул. Баторжинского, д.55, кв.44",
                Telephone = "050-222-09-99",
                Email = "ContactBat@gmail.com"
            },
            new ContactInfo()
            {
                City = "Черновцы",
                Adress = "ул. Калугина, д.11, кв.22",
                Telephone = "097-543-17-25",
                Email = "ContactCalug@gmail.com"
            },
            new ContactInfo()
            {
                City = "Днепропетровск",
                Adress = "ул. Б.Хмельницкого, д.10, кв.2",
                Telephone = "067-111-77-17",
                Email = "ContactHmel@gmail.com"
            },
            new ContactInfo()
            {
                City = "Ужгород",
                Adress = "ул. Варшавская, д.233, кв.55",
                Telephone = "050-667-12-21",
                Email = "ContactVar@gmail.com"
            },
            new ContactInfo()
            {
                City = "Одесса",
                Adress = "ул. Курортная, д.44, кв.85",
                Telephone = "098-485-54-85",
                Email = "ContactKurort@gmail.com"
            },
            new ContactInfo()
            {
                City = "Днепропетровск",
                Adress = "ул. Кирова, д.2, кв.507",
                Telephone = "050-333-22-44",
                Email = "ContactKirova@gmail.com"
            },
            new ContactInfo()
            {
                City = "Софиевка",
                Adress = "ул. Казаческая, д.77, кв.27",
                Telephone = "097-662-55-99",
                Email = "ContactKozac@gmail.com"
            }
        };
    }
}
