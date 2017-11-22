using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_4B
{
    public partial class romanToDecimalConverterForm : Form
    {
        public romanToDecimalConverterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //declare an array of strings of the Roman Numeral letters between [I..X]
            string[] romanNumeralLetters = {
    "I",
    "II",
    "III",
    "IV",
    "V",
    "VI",
    "VII",
    "VIII",
    "IX",
    "X"
   };
            // declare a boolean variable to verify it later is the entry is roman number! 
            Boolean isRomanNumber;
            // transfer the string entered to upper case and store it in a variable
            string upStrRomanNumeral = txtBoxRomanNumeralInput.Text.ToUpper();
            //Test if the textbox field empty
            if (txtBoxRomanNumeralInput.Text == "")
            {
                MessageBox.Show("Please enter a Roman number! This value cannot be empty.");
                lblAnswer.Text = "";
                txtBoxRomanNumeralInput.Focus();

            }
            else
            {
                //verify if the array contains the value entered!
                if (romanNumeralLetters.Contains(upStrRomanNumeral))
                {
                    //if the value entered is a roman number then the variable isRomanNumber is set to true
                    isRomanNumber = true;
                }
                else
                {
                    //if the value entered is not in the roman number array, then the variable isRomanNumber is set to false
                    isRomanNumber = false;
                }

                //if the entry is not roman number 
                if (!isRomanNumber)
                {
                    //alert the user to enter a valid Roman number in the range [I..X]
                    MessageBox.Show("Please enter a valid Roman number! included between [I..X]");
                    txtBoxRomanNumeralInput.Text = ""; //empty the "txtBoxRomanNumeralInput" in case it has something
                    lblAnswer.Text = ""; //empty the "lblAnswer" in case it has something
                    txtBoxRomanNumeralInput.Focus(); //focus on the "txtBoxRomanNumeralInput" 

                }
                //if the entry is a Roman Number
                else if (isRomanNumber)
                {
                    switch (upStrRomanNumeral) //switch by case of the letter entered
                    {
                        case "I": //if the value entered "upStrRomanNumeral" is I then 
                            lblAnswer.Text = "1"; //show in the answer label the decimal value of I
                            break;
                        case "II":
                            lblAnswer.Text = "2";
                            break;
                        case "III":
                            lblAnswer.Text = "3";
                            break;
                        case "IV":
                            lblAnswer.Text = "4";
                            break;
                        case "V":
                            lblAnswer.Text = "5";
                            break;
                        case "VI":
                            lblAnswer.Text = "6";
                            break;
                        case "VII":
                            lblAnswer.Text = "7";
                            break;
                        case "VIII":
                            lblAnswer.Text = "8";
                            break;
                        case "IX":
                            lblAnswer.Text = "9";
                            break;
                        case "X":
                            lblAnswer.Text = "10";
                            break;
                        default:
                            lblAnswer.Text = "Not valid value entered!"; //entry not valid! Something went wrong
                            break;
                    }

                }

            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //on click of the Reset button
            txtBoxRomanNumeralInput.Text = ""; //empty the entered field
            txtBoxRomanNumeralInput.Focus(); //focus on the "txtBoxRomanNumeralInput" field
            lblAnswer.Text = ""; //empty the answer in case there is old value in it

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();

        }
    }
}
