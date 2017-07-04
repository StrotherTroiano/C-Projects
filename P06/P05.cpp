//Strother Troiano P05
//This program will be used by employees to determine what their weekly net pay 
//would be based on their hourly rate and number of hours worked.

#include <iostream>
using namespace std;

//Declare Variables
double inputRate();
int    inputHours();

//method declaration for gross
double calcGross(double rate_r, int hourse_r);

//method declaration for tax
double calcTax(double gross_r, double tax_Rate);
const double rate_over_time = 1.5;

int main()
{
	const double due_for_union = 10.00, rate_for_fica = (0.06), rate_over_time = 1.5,
	rate_for_federal = (0.15), rate_for_state = (0.05);
	int hourse_r;
	double gross_r = 0, rate_r, federal_r, fica_r, state_r, net_pay, net_Hourly;

	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);

	cout << "P05 - Strother Troiano \n\n";

	rate_r = inputRate();
	hourse_r = inputHours();



	fica_r = calcTax(gross_r, rate_for_fica);
	federal_r = calcTax(gross_r, rate_for_federal);
	state_r = calcTax(gross_r, rate_for_state);
	float g = calcGross(rate_r, hourse_r);
	float fi = calcTax(g, rate_for_fica);
	float f = calcTax(g, rate_for_federal);
	float s = calcTax(g, rate_for_state);
	net_pay = (g - fi - f - s - due_for_union);
	net_Hourly = (net_pay / hourse_r);

	cout << endl
		 << "Hourly Rate: \t" << rate_r << endl
		 << "Hours Worked:\t" << hourse_r << endl
		 << "Gross Pay:   \t" << calcGross(rate_r, hourse_r) << endl
		 << "FICA Tax:    \t" << fi << " at " << rate_for_fica << endl
		 << "Federal Tax: \t" << f << " at " << rate_for_federal << endl
		 << "State Tax:   \t" << s << " at " << rate_for_state << endl
		 << "Union Dues: \t" << due_for_union << endl
		 << "Net Pay:     \t" << net_pay << endl
		 << "Net Hourly: \t" << net_Hourly << endl
		 << "\nThank you!\n\n";

	return 1;
}

double inputRate()
{
	double rate_r;

	do
	{
		cout << "Enter the hourly rate between $10.00 and $15.00:";
		cin  >> rate_r;
	} while (rate_r < 10.00 || rate_r > 15.00);
	cout << endl;
	
	return (rate_r);
}

int inputHours()
{
	int hourse_r;
	
	do
	{
		cout << "Enter the number of hours worked between 1 and 50: ";
		cin  >> hourse_r;
	} while (hourse_r < 1 || hourse_r > 50);
	cout << endl;
	
	return (hourse_r);
}

double calcGross(double rate_r, int hourse_r)
{
	double gross_r;

	if (hourse_r > 40)
		gross_r = (40 * rate_r) + ((hourse_r - 40) * rate_r * rate_over_time);
	else
		gross_r = rate_r * hourse_r;
	return (gross_r);
}

double calcTax(double gross_r, double tax_Rate)
{
	double amount_r;

	amount_r = gross_r * tax_Rate;
	return amount_r;
}