/*
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.ParenthesisMatcher
{
    public partial class uxWindow : Form
    {
        public uxWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exectues code to check for matching parenthesis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton_Click(object sender, EventArgs e)
        {
            Stack<char> parenthesis = new Stack<char>();
            string original = uxTextBox.Text;
            foreach (char c in original)
            {
                if (IsOpeningParenthesis(c))
                {
                    parenthesis.Push(c);
                }
                else if (IsClosingParenthesis(c))
                {
                    if (parenthesis.Count > 0 && Matches(parenthesis.Peek(), c))
                    {
                        parenthesis.Pop();
                    }
                    else if (parenthesis.Count > 0 && !Matches(parenthesis.Peek(), c))
                    {
                        ShowError();
                        uxTextBox.Clear();
                        return;
                    }
                    else
                    {
                        ShowError();
                        uxTextBox.Clear();
                        return;
                    }
                }
            }

            if (parenthesis.Count == 0)
            {
                ShowSuccess();
            }
            else if (parenthesis.Count > 0)
            {
                ShowError();
            }
            uxTextBox.Clear();

        }

        /// <summary>
        /// Determines whether the given character is an opening parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is an opening parenthesis.</returns>
        private bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        /// <summary>
        /// Determines whether the given character is a closing parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is a closing parenthesis.</returns>
        private bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        /// <summary>
        /// Determines whether the given characters for a matched pair
        /// of parentheses.
        /// </summary>
        /// <param name="a">The opening character.</param>
        /// <param name="b">The closing character.</param>
        /// <returns>Whether a and b form a matched pair of parentheses.</returns>
        private bool Matches(char a, char b)
        {
            return (a == '(' && b == ')') || (a == '[' && b == ']') ||
                (a == '{' && b == '}');
        }

        /// <summary>
        /// Displays a success message.
        /// </summary>
        private void ShowSuccess()
        {
            MessageBox.Show("The string is matched.");
        }

        /// <summary>
        /// Displays an error message.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("The string is not matched.");
        }
    }
}
