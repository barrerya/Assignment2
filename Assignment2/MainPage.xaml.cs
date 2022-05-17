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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void tbReverse_TextChanged(object sender, TextChangedEventArgs e)
        {
            String input = tbReverse.Text;
            String output = reverseString(input);
            textOutput.Text = output;
        }

        //method that reverses input string
        private String reverseString (String input)
        {
            char[] inChars = input.ToCharArray();

            //if the input string is more than one character reverse and return the new string
            if (inChars.Length > 1)
            {
                char[] outChars = new char[inChars.Length];
                int x = 0;
                int y = inChars.Length -1;

                while(y >= 0)
                {
                    outChars[x] = inChars[y];
                    x++;
                    y--;
                }
                return new String(outChars);

            }
            //if the string is one or zero characters just return the input
            else
            {
                return new String(inChars);
            }
            

        }
    }
}
