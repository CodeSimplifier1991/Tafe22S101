using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		// START --- Loan Calculation function
		private void calculateTheLoan() {

			//double principaleAmount = 0, yearsOfTheLoan = 0, yearlyInterestRate = 0;

			// Vars
			double principalLoanAmount = Convert.ToDouble(principalBarrowBox.Text);
			double loanDurationInYears = Convert.ToDouble(yearOfLoanBox.Text);
			double andMonthInLoanDuration = Convert.ToDouble(andMonthOfTheLoanBox.Text);
			double yearlyInterestRate = Convert.ToDouble(yearlyInterestRateBox.Text);

			double monthlyInterstRate = (yearlyInterestRate + andMonthInLoanDuration) / 1200;
			double loanPeriodInMonth = (loanDurationInYears + andMonthInLoanDuration) * 12;

			double monthlyRepayment = 0;

			//monthlyRepayment = principaleAmount * ((r * (Math.Pow(1 + r, n))) / (Math.Pow(1 + r, n) - 1));
			try
			{
				if (principalLoanAmount > 0 && yearlyInterestRate > 0)
				{
					monthlyRepayment =
						principalLoanAmount * ((monthlyInterstRate * Math.Pow((1 + monthlyInterstRate), loanPeriodInMonth)) / (Math.Pow(1 + monthlyInterstRate, loanPeriodInMonth) - 1));
				}
				else
				{
					monthlyRepayment = 0;
				}
			}
			catch (Exception ex) { throw ex; }

			// (yearlyInterestRate / 1200)
			monthlyInterestRateBox.Text = monthlyInterstRate.ToString("#.0000");
			monthlyRepaymentBox.Text = monthlyRepayment.ToString("#.00");
		}
		// END --- Loan Calculation function


		// START -------------- Calculate Button Click -------------
		private void calculateBtn_Click(object sender, RoutedEventArgs e)
		{
			calculateTheLoan();
		}
		// END -------------- Calculate Button Click -------------


		// START -------------- Exit Button Click -------------
		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{

		}
		// END -------------- Exit Button Click -------------

	}
	// MortgageCalculator
}
