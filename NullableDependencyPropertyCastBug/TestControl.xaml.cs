using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
namespace NullableDependencyPropertyCastBug
{
    public sealed partial class TestControl : UserControl
    {
        public int? TestIntConversion
        {
            get { return TestDecimal.HasValue ? Decimal.ToInt32(TestDecimal.Value) : 0; }
            set { TestDecimal = (decimal)value; }
        }        

        public decimal? TestDecimal
        {
            get { return (decimal?)GetValue(TestDecimalProperty); }
            set { SetValue(TestDecimalProperty, value); }
        }

        public static readonly DependencyProperty TestDecimalProperty =
            DependencyProperty.Register("TestDecimal", typeof(object), typeof(TestControl), new PropertyMetadata(0));

        
        public TestControl()
        {
            this.InitializeComponent();
        }
    }
}
