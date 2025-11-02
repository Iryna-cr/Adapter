using System;

// Сторонній клас, який не підходить до нашої системи
class ForeignPaymentSystem
{
    public void MakeForeignPay() => Console.WriteLine("Оплата через зовнішній сервіс");
}

// Наш адаптер
class PaymentAdapter
{
    private ForeignPaymentSystem foreign = new ForeignPaymentSystem();

    public void Pay()
    {
        foreign.MakeForeignPay();
    }
}

class Program
{
    static void Main()
    {
        var adapter = new PaymentAdapter();
        adapter.Pay();
    }
}







