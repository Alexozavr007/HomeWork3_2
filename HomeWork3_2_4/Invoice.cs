using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2_4 {
    internal class Invoice {
        readonly int account;
        readonly string customer;
        readonly string provider;

        private string article;
        private int quantity;

        public Invoice (int account, string customer, string provider) {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CalculatePrice(string art, int qty) {
            article = art;
            quantity = qty;

            // вартість за одиницю товару
            double price = 0;

            switch (art) {
                case "01924A":
                    price = 899;
                    break;
                case "11924A":
                    price = 1899;
                    break;
                case "21924A":
                    price = 699;
                    break;
                case "31924A":
                    price = 199;
                    break;
            }
            
            double totalPrice = price * quantity;
            double totalPriceWithPDV = totalPrice * 1.2;

            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Артикул товару: {article}");
            Console.ForegroundColor = color;
            Console.WriteLine($"Кількість: {qty}");
            Console.WriteLine($"Покупець: {customer}");
            Console.WriteLine($"Постачальник: {provider}");
            Console.WriteLine($"Account: {account}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Вартість (без ПДВ): {totalPrice}");
            Console.WriteLine($"Вартість (ПДВ 20%): {totalPriceWithPDV}");
            Console.ForegroundColor = color;
        }
    }
}
