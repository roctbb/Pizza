using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        [DisplayName("Название")]
        public String name { get; set; }
        [DisplayName("Цена")]
        public int price { get; set; }
        [DisplayName("Описание")]
        public String description { get; set; }
        [DisplayName("Внешний вид")]
        public String image { get; set; }
    }
    public enum Size
    {
        [Display(Name = "Маленькая")]
        small,
        [Display(Name = "Средняя")]
        medium,
        [Display(Name = "Большая")]
        big
    }
    public enum Bread
    {
        [Display(Name = "Стандартное")]
        standart,
        [Display(Name = "Вкусное")]
        custom
    }
    public class Order
    {
        public int ID { get; set; }
        [DisplayName("Пицца")]
        public Pizza choice { get; set; }
        [DisplayName("Время заказа")]
        public DateTime time { get; set; }
        [DisplayName("Адрес")]
        public String adress { get; set; }
        [DisplayName("Телефон")]
        public String phone { get; set; }
        [DisplayName("Размер")]
        public Size size { get; set; }
        [DisplayName("Тесто")]
        public Bread bread { get; set; }
    }

    public class PizzaDBContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}