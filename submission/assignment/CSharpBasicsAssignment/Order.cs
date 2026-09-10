using System;
using System.Runtime.CompilerServices;

namespace CSharpBasicsAssignment;

public class Order
{
  public int OrderId;
  public string CustomerName = string.Empty;
  public int Quantity;
  public decimal UnitPrice;
  public decimal TotalPrice;
  public bool IsPaid;
  public double DiscountPercent;
  public string ShippingCity = string.Empty;
  public char Priority;
  public long ItemCode;

  public void CalculateTotal() =>
    TotalPrice = (Quantity * UnitPrice * (1 - (decimal)DiscountPercent/100));
  
  public void PrintSummary() =>
    Console.WriteLine($"OrderId: {OrderId} || Name: {CustomerName} || Total: {TotalPrice} || Payed: {IsPaid}");
}
