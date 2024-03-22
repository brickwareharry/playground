using System.Diagnostics;

namespace dependency_inversion;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var orderValidation = new OrderValidation();
        var orderRecordation = new OrderRecordation();
        var emailOrderNotification_Class = new EmailOrderNotification_Class();
        var emailOrderNotication = new EmailOrderNotication();
        var smsOrderNotication = new SmsOrderNotication();

        var orderProcessor = new OrderProcessor(orderValidation, orderRecordation, emailOrderNotification_Class, emailOrderNotication);
        orderProcessor.ExecuteOrder();
    }
}




public class OrderProcessor
{
    private readonly OrderValidation _orderValidation;
    private readonly OrderRecordation _orderRecordation;
    private readonly EmailOrderNotification_Class _emailOrderNotification_Class;
    private readonly IOrderNotification _OrderNotification;

    public OrderProcessor(OrderValidation orderValidation, OrderRecordation orderRecordation, EmailOrderNotification_Class emailOrderNotification_Class, IOrderNotification orderNotification)
    {
        this._orderValidation = orderValidation;
        this._orderRecordation = orderRecordation;
        this._emailOrderNotification_Class = emailOrderNotification_Class;
        this._OrderNotification = orderNotification;
    }

    public void ExecuteOrder()
    {
        //valide order
        _orderValidation.ValidOrder();
        //record order
        _orderRecordation.SaveOrderToFile();
        //notify order
        _emailOrderNotification_Class.SendEmailNotification();
        //notify order via interface
        _OrderNotification.SendNotification();

    }
}

public class OrderValidation
{
    public void ValidOrder()
    {
        Console.WriteLine("order validation is done");
    }

}

public class OrderRecordation
{
    public void SaveOrderToFile()
    {
        Console.WriteLine("order is save to a file");
    }

}

public class EmailOrderNotification_Class
{
    public void SendEmailNotification()
    {
        Console.WriteLine("Sent emails to stakeholder of the order");
    }
}

public interface IOrderNotification
{
    public void SendNotification();
}

public class EmailOrderNotication : IOrderNotification
{
    public void SendNotification()
    {
        Console.WriteLine("Sent email via interface to stakeholder of the order");
    }
}

public class SmsOrderNotication : IOrderNotification
{
    public void SendNotification()
    {
        Console.WriteLine("Sent Sms via interface to stakeholder of the order");
    }
}




