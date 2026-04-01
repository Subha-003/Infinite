using System;

class SaleDetails
{
    int salesNo, productNo, qty;
    double price, totalAmount;
    string dateOfSale;

    public SaleDetails(int salesNo, int productNo, double price, int qty, string dateOfSale)
    {
        this.salesNo = salesNo;
        this.productNo = productNo;
        this.price = price;
        this.qty = qty;
        this.dateOfSale = dateOfSale;
    }

    public void Sales()
    {
        totalAmount = qty * price;
    }

    public static void ShowData(SaleDetails s)
    {
        Console.WriteLine($"SalesNo: {s.salesNo}, ProductNo: {s.productNo}, Price: {s.price}, Qty: {s.qty}, Date: {s.dateOfSale}, Total: {s.totalAmount}");
    }

    static void Main()
    {
        SaleDetails s = new SaleDetails(1, 101, 50, 3, "30-03-2026");

        s.Sales();
        SaleDetails.ShowData(s);
    }
}