using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace BillingApp.Views;

public partial class BillListView : UserControl
{
    public BillListView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    // Summation Button
    public void ButtonSumCharge(object source, RoutedEventArgs args)
    {
        string baseCharge = BaseCharge.Text.Replace("$", "");
        string ancFees = AncFees.Text.Replace("$", "");
        string taxes = Taxes.Text.Replace("$", "");
        string credit = Credit.Text.Replace("$", "");
        
        if (Double.TryParse(baseCharge, out var b) &
            Double.TryParse(ancFees, out var a) &
            Double.TryParse(taxes, out var t) &
            Double.TryParse(credit, out var c))
        {
            Total.Text = $"${b + a + t - c}";
        }
    }
    
    // Update paid text box if paid
    public void ButtonUpdatePaidStatus(object source, RoutedEventArgs args)
    {
        try
        {
            if (PaidDate.SelectedDate.HasValue &
                (PaidDate.SelectedDate.GetValueOrDefault() - BilledDate.SelectedDate.GetValueOrDefault()).TotalDays >= 0)
            {
                PaidBool.Text = "TRUE";
            }
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
        }
        finally
        {
            Console.WriteLine($"Entered Date: {PaidDate.SelectedDate.GetValueOrDefault()}");
            Console.WriteLine($"Entered Total: {Total.Text}");
        }
    }
}