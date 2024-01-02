using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MCQ
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int totalMarksObtained = 0;

            Form1 q1 = new Form1();
            q1.label1.Text = "1. Question 1";
            q1.radioButton1.Text = "Answer 1-1";
            q1.radioButton2.Text = "Answer 1-2";
            q1.radioButton3.Text = "Answer 1-3";
            q1.radioButton4.Text = "Answer 1-4";
            q1.correctAnswer = 1;

            Form1 q2 = new Form1();
            q2.label1.Text = "2. Question 2";
            q2.radioButton1.Text = "Answer 2-1";
            q2.radioButton2.Text = "Answer 2-2";
            q2.radioButton3.Text = "Answer 2-3";
            q2.radioButton4.Text = "Answer 2-4";
            q2.correctAnswer = 1;

            Form1 q3 = new Form1();
            q3.label1.Text = "3. Question 3";
            q3.radioButton1.Text = "True";
            q3.radioButton2.Text = "False";
            q3.radioButton3.Visible = false;
            q3.radioButton4.Visible = false;
            q3.correctAnswer = 1;

            Form1 q4 = new Form1();
            q4.label1.Text = "4. Question 4";
            q4.radioButton1.Text = "Answer 4-1";
            q4.radioButton2.Text = "Answer 4-2";
            q4.radioButton3.Text = "Answer 4-3";
            q4.radioButton4.Text = "Answer 4-4";
            q4.correctAnswer = 1;

            Form1 q5 = new Form1();
            q5.label1.Text = "5. Question 5";
            q5.radioButton1.Text = "True";
            q5.radioButton2.Text = "False";
            q5.radioButton3.Visible = false;
            q5.radioButton4.Visible = false;
            q5.correctAnswer = 1;

            Form1 q6 = null;

            listenSubmit(q1);
            goToNext(q1, q2);

            listenSubmit(q2);
            goToNext(q2, q3);

            listenSubmit(q3);
            goToNext(q3, q4);

            listenSubmit(q4);
            goToNext(q4, q5);

            listenSubmit(q5);
            goToNext(q5, q6);

            // Run the first object q1
            Application.Run(q1);

            void listenSubmit(Form1 currentQ)
            {
                // Subscribe to the button click event
                currentQ.submitButton.Click += (sender, e) =>
                {
                    currentQ.message.Text = currentQ.ansMessage;
                    currentQ.message.Visible = true;
                    currentQ.submitButton.Visible = false;
                    currentQ.nextButton.Visible = true;
                };
            }

            void goToNext(Form1 currentQ, Form1 nextQ)
            {
                // Subscribe to the button click event
                currentQ.nextButton.Click += (sender, e) =>
                {
                    totalMarksObtained += currentQ.markObtained;
                    currentQ.Hide();  // Hide the current form
                    // Show the next question
                    ShowNextQuestion(currentQ, nextQ);
                };
            }

            // Function to show the next question
            void ShowNextQuestion(Form currentForm, Form nextForm)
            {
                if (nextForm != null)
                {
                    nextForm.StartPosition = FormStartPosition.Manual;
                    nextForm.Location = currentForm.Location;
                    nextForm.Show();
                }
                else
                {
                    // No more questions, you can handle the end of the quiz here
                    string resultMessage = string.Format("End of the quiz!\n You obtained {0:P2}",
                                   ((double)totalMarksObtained / 5));
                    MessageBox.Show(resultMessage);

                    Application.Exit();
                }
            }
        }
    }
}
