using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TipCalculatorDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double bill=0, tipPercentage = 0, numberOfPeople = 1, tipPerPerson = 0, totalPerPerSon = 0;


        //Initializing component of Main Window.
        public MainWindow()
        {
            InitializeComponent();
        }

        //event handling on clicking icr1 button, i.e. + button of tip percentage.
        //here we are assuming that tip percentage are can,t be greater than original bill.
        //and can.t be a negative number.
        //so we are setting a boundary of 0-100 for tip percentage.
        private void icr1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tipPercentage < 100)
                {
                    tipPercentage += 1;   
                }
                else
                {
                    System.Windows.MessageBox.Show("Tip can't be greater than 100 %");
                }
                tipInput.Text = Convert.ToString(tipPercentage);
            }
            catch(Exception)
            {
                System.Windows.MessageBox.Show("Enter a valid number");
            }

        }


        //event handling on clicking dcr1 button, i.e. - button of tip percentage.
        //here we are assuming that tip percentage are can,t be greater than original bill.
        //and can.t be a negative number.
        //so we are setting a boundary of 0-100 for tip percentage.
        private void dcr1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tipPercentage < 1)
                {
                    System.Windows.MessageBox.Show("Tip percentahe can't be negative");
                }
                else
                {
                    tipPercentage -= 1;
                   
                }
                tipInput.Text = Convert.ToString(tipPercentage);
            }
            catch (Exception )
            {
                System.Windows.MessageBox.Show("Enter a valid number");
            }
        }


        //event handling on clicking icr2 button, i.e. + button of number of person.
        //here i am taking 10 as maximum number of people and 1 as minimum number of people.
        //number of person can be changed easily with changing max and min conditions.
        private void icr2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (numberOfPeople < 10)
                {
                    numberOfPeople += 1;
                   
                }
                else
                {
                    System.Windows.MessageBox.Show("number of people can't be greater than 10.");
                }
                numberOfPeopleInput.Text = Convert.ToString(numberOfPeople);

            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Enter a valid number");
            }
        }


        //event handling on clicking icr2 button, i.e. + button of number of person.
        //here i am taking 10 as maximum number of people and 1 as minimum number of people.
        //number of person can be changed easily with changing max and min conditions.
        private void dcr2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (numberOfPeople < 2)
                {
                    System.Windows.MessageBox.Show("Number of Persom should be greater than or equal to 1.");
                }
                else
                {
                    numberOfPeople -= 1;
                    
                }
                numberOfPeopleInput.Text = Convert.ToString(numberOfPeople);
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Enter a valid number");
            }
        }


        //event handling manually entering value of tip percentage.
        //here we are assuming that tip percentage are can,t be greater than original bill.
        //and can.t be a negative number.
        //so we are setting a boundary of 0-100 for tip percentage.
        private void tipInput_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                tipPercentage = Convert.ToDouble(tipInput.Text);
                if (tipPercentage > 100)
                {
                    System.Windows.MessageBox.Show("Tip Percentage can't be greater than 100.");
                    tipPercentage = 100;
                    tipInput.Text = Convert.ToString(tipPercentage);
                }
                else if (tipPercentage < 0)
                {
                    tipPercentage = 00;
                    tipInput.Text = Convert.ToString(tipPercentage);
                }
                else
                {
                    tipPercentage = Convert.ToDouble(tipInput.Text);
                }

                
                
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Enter a valid tip percentage.");
                tipInput.Text = Convert.ToString(0);
            }
        }


        //event handling manually entering value of number of person..
        //here i am taking 10 as maximum number of people and 1 as minimum number of people.
        //number of person can be changed easily with changing max and min conditions.
        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            try
            {
                numberOfPeople = Convert.ToDouble(numberOfPeopleInput.Text);
                if (numberOfPeople > 10)
                {
                    System.Windows.MessageBox.Show("Number of People should be greater than or equal to 10.");
                    numberOfPeople = 10;
                    numberOfPeopleInput.Text = Convert.ToString(numberOfPeople);
                }
                else if (numberOfPeople <= 0)
                {
                    System.Windows.MessageBox.Show("Number of People should be less than 1.");
                    numberOfPeople = 1;
                    numberOfPeopleInput.Text = Convert.ToString(numberOfPeople);
                }
            
                else
                {
                    numberOfPeople = Convert.ToDouble(numberOfPeopleInput.Text);
                }

               
                
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Enter a valid number of Peoples.");
                numberOfPeopleInput.Text = Convert.ToString(1);
            }
        }

        //event handling on clicking "solution" button
        //all the calculation for final result are done here.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bill = Convert.ToDouble(bill);
                tipPerPerson = ((bill / numberOfPeople) * tipPercentage) / 100;
                totalPerPerSon = ((bill / numberOfPeople) + tipPerPerson);
                output1.Text =  "$"+(Convert.ToString(tipPerPerson));
                output2.Text = "$" + (Convert.ToString(totalPerPerSon));
            }
            catch(Exception)
            {
                System.Windows.MessageBox.Show("Enter a valid Bill");
            }

        }

        //event handling for taking bill amount
        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            try
            {
                bill = Convert.ToDouble(billInput.Text);
                if (bill<0)
                {
                    bill = 00;
                    billInput.Text = Convert.ToString(bill);

                }
               
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Enter a valid bill");
                billInput.Text = Convert.ToString(0);
            }
        }
    }
}
