using Firm;
using System;

public class Commision : Hourly
{
    private double _commisionSales;
    private double _totalSales;

    public Commision(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commisionSales)
        : base(eName, eAddress, ePhone, socSecNumber, rate)
    {
        _commisionSales = commisionSales;
        _totalSales = 0;
    }

    public void AddSales(double totalSales)
    {
        _totalSales += totalSales;
    }

    public override double Pay()
    {
        var basePay = base.Pay();
        var salary = basePay + _totalSales * _commisionSales;
        _totalSales = 0;
        return salary;
    }
    
    public override string ToString()
    {
        var baseResult = base.ToString();
        baseResult += $"{Environment.NewLine} TotalsSales: {_totalSales}";
        return baseResult;
    }


}