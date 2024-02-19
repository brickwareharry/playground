
using static single_responsibility.Program;

namespace single_responsibility;

class Program
{
    static void Main(string[] args)
    {
        var orderValidation = new OrderValidation();
        var orderSave = new OrderSave();
        var orderNotification = new OrderNotification();

        var order = new OrderProcessor(orderValidation, orderSave, orderNotification);
        order.order();
    }

    public class OrderProcessor
    {
        private OrderValidation orderValidation;
        private OrderSave orderSave;
        private OrderNotification orderNotification;

        public OrderProcessor(OrderValidation orderValidation, OrderSave orderSave, OrderNotification orderNotification)
        {
            this.orderValidation = orderValidation;
            this.orderSave = orderSave;
            this.orderNotification = orderNotification;
        }
        public void order()
        {
            //validation
            orderValidation.validation();
            // save
            //notification

            Console.WriteLine("order complete");
        }
    }

    public class OrderValidation
    {
        public void validation()
        {
            Console.WriteLine("order validation is done");
        }
    }

    public class OrderSave
    {
        public void Save()
        {
            Console.WriteLine("order is save");
        }
    }
    public class OrderNotification
    {
        public void sendNotification()
        {
            Console.WriteLine("Notification is sent");
        }
    }




}
