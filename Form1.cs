using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_6x6_Solving_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] sudoku = new string[10, 10];
        bool test = false;
        //Filling sudoku
        public void Filling_Sudoku()
        {
            sudoku[1, 1] = txt11.Text;
            sudoku[1, 2] = txt12.Text;
            sudoku[1, 3] = txt13.Text;
            sudoku[1, 4] = txt14.Text;
            sudoku[1, 5] = txt15.Text;
            sudoku[1, 6] = txt16.Text;

            sudoku[2, 1] = txt21.Text;
            sudoku[2, 2] = txt22.Text;
            sudoku[2, 3] = txt23.Text;
            sudoku[2, 4] = txt24.Text;
            sudoku[2, 5] = txt25.Text;
            sudoku[2, 6] = txt26.Text;

            sudoku[3, 1] = txt31.Text;
            sudoku[3, 2] = txt32.Text;
            sudoku[3, 3] = txt33.Text;
            sudoku[3, 4] = txt34.Text;
            sudoku[3, 5] = txt35.Text;
            sudoku[3, 6] = txt36.Text;

            sudoku[4, 1] = txt41.Text;
            sudoku[4, 2] = txt42.Text;
            sudoku[4, 3] = txt43.Text;
            sudoku[4, 4] = txt44.Text;
            sudoku[4, 5] = txt45.Text;
            sudoku[4, 6] = txt46.Text;

            sudoku[5, 1] = txt51.Text;
            sudoku[5, 2] = txt52.Text;
            sudoku[5, 3] = txt53.Text;
            sudoku[5, 4] = txt54.Text;
            sudoku[5, 5] = txt55.Text;
            sudoku[5, 6] = txt56.Text;

            sudoku[6, 1] = txt61.Text;
            sudoku[6, 2] = txt62.Text;
            sudoku[6, 3] = txt63.Text;
            sudoku[6, 4] = txt64.Text;
            sudoku[6, 5] = txt65.Text;
            sudoku[6, 6] = txt66.Text;
        }

        public void Filling_Empty()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (sudoku[i, j].Length == 0)
                        sudoku[i, j] = "123456";
                }
            }
        }

        public void Filling_Empty_Square()
        {
            if (txt11.Text.Length == 0)
            {
                txt11.ForeColor = Color.Blue;
                txt11.Text = sudoku[1, 1];
            }
            if (txt12.Text.Length == 0)
            {
                txt12.ForeColor = Color.Blue;
                txt12.Text = sudoku[1, 2];
            }
            if (txt13.Text.Length == 0)
            {
                txt13.ForeColor = Color.Blue;
                txt13.Text = sudoku[1, 3];
            }
            if (txt14.Text.Length == 0)
            {
                txt14.ForeColor = Color.Blue;
                txt14.Text = sudoku[1, 4];
            }
            if (txt15.Text.Length == 0)
            {
                txt15.ForeColor = Color.Blue;
                txt15.Text = sudoku[1, 5];
            }
            if (txt16.Text.Length == 0)
            {
                txt16.ForeColor = Color.Blue;
                txt16.Text = sudoku[1, 6];
            }


            if (txt21.Text.Length == 0)
            {
                txt21.ForeColor = Color.Blue;
                txt21.Text = sudoku[2, 1];
            }
            if (txt22.Text.Length == 0)
            {
                txt22.ForeColor = Color.Blue;
                txt22.Text = sudoku[2, 2];
            }
            if (txt23.Text.Length == 0)
            {
                txt23.ForeColor = Color.Blue;
                txt23.Text = sudoku[2, 3];
            }
            if (txt24.Text.Length == 0)
            {
                txt24.ForeColor = Color.Blue;
                txt24.Text = sudoku[2, 4];
            }
            if (txt25.Text.Length == 0)
            {
                txt25.ForeColor = Color.Blue;
                txt25.Text = sudoku[2, 5];
            }
            if (txt26.Text.Length == 0)
            {
                txt26.ForeColor = Color.Blue;
                txt26.Text = sudoku[2, 6];
            }


            if (txt31.Text.Length == 0)
            {
                txt31.ForeColor = Color.Blue;
                txt31.Text = sudoku[3, 1];
            }
            if (txt32.Text.Length == 0)
            {
                txt32.ForeColor = Color.Blue;
                txt32.Text = sudoku[3, 2];
            }
            if (txt33.Text.Length == 0)
            {
                txt33.ForeColor = Color.Blue;
                txt33.Text = sudoku[3, 3];
            }
            if (txt34.Text.Length == 0)
            {
                txt34.ForeColor = Color.Blue;
                txt34.Text = sudoku[3, 4];
            }
            if (txt35.Text.Length == 0)
            {
                txt35.ForeColor = Color.Blue;
                txt35.Text = sudoku[3, 5];
            }
            if (txt36.Text.Length == 0)
            {
                txt36.ForeColor = Color.Blue;
                txt36.Text = sudoku[3, 6];
            }


            if (txt41.Text.Length == 0)
            {
                txt41.ForeColor = Color.Blue;
                txt41.Text = sudoku[4, 1];
            }
            if (txt42.Text.Length == 0)
            {
                txt42.ForeColor = Color.Blue;
                txt42.Text = sudoku[4, 2];
            }
            if (txt43.Text.Length == 0)
            {
                txt43.ForeColor = Color.Blue;
                txt43.Text = sudoku[4, 3];
            }
            if (txt44.Text.Length == 0)
            {
                txt44.ForeColor = Color.Blue;
                txt44.Text = sudoku[4, 4];
            }
            if (txt45.Text.Length == 0)
            {
                txt45.ForeColor = Color.Blue;
                txt45.Text = sudoku[4, 5];
            }
            if (txt46.Text.Length == 0)
            {
                txt46.ForeColor = Color.Blue;
                txt46.Text = sudoku[4, 6];
            }


            if (txt51.Text.Length == 0)
            {
                txt51.ForeColor = Color.Blue;
                txt51.Text = sudoku[5, 1];
            }
            if (txt52.Text.Length == 0)
            {
                txt52.ForeColor = Color.Blue;
                txt52.Text = sudoku[5, 2];
            }
            if (txt53.Text.Length == 0)
            {
                txt53.ForeColor = Color.Blue;
                txt53.Text = sudoku[5, 3];
            }
            if (txt54.Text.Length == 0)
            {
                txt54.ForeColor = Color.Blue;
                txt54.Text = sudoku[5, 4];
            }
            if (txt55.Text.Length == 0)
            {
                txt55.ForeColor = Color.Blue;
                txt55.Text = sudoku[5, 5];
            }
            if (txt56.Text.Length == 0)
            {
                txt56.ForeColor = Color.Blue;
                txt56.Text = sudoku[5, 6];
            }


            if (txt61.Text.Length == 0)
            {
                txt61.ForeColor = Color.Blue;
                txt61.Text = sudoku[6, 1];
            }
            if (txt62.Text.Length == 0)
            {
                txt62.ForeColor = Color.Blue;
                txt62.Text = sudoku[6, 2];
            }
            if (txt63.Text.Length == 0)
            {
                txt63.ForeColor = Color.Blue;
                txt63.Text = sudoku[6, 3];
            }
            if (txt64.Text.Length == 0)
            {
                txt64.ForeColor = Color.Blue;
                txt64.Text = sudoku[6, 4];
            }
            if (txt65.Text.Length == 0)
            {
                txt65.ForeColor = Color.Blue;
                txt65.Text = sudoku[6, 5];
            }
            if (txt66.Text.Length == 0)
            {
                txt66.ForeColor = Color.Blue;
                txt66.Text = sudoku[6, 6];
            }
        }

        public void Search_Sudoku()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (sudoku[i, j].Length != 1)
                    {
                        Edit_Sudoku(i, j);
                        Edit_Small_Sudoku(i, j);
                    }
                }
            }
        }

        public bool Scanning_Sudoku()
        {
            for(int i=1;i<=6;i++)
            {
                for(int j=1;j<=6;j++)
                {
                    if (sudoku[i, j].Length > 1)
                        test = true;
                }
            }
            return test;
        }

        public void Edit_Sudoku(int n, int m)
        {
            for (int i = 1; i <= 6; i++)
            {
                if (i != n && sudoku[i, m].Length == 1)
                {
                    for (int j = 0; j < sudoku[n, m].Length; j++)
                    {
                        if (sudoku[n, m][j].ToString() == sudoku[i, m])
                        {
                            sudoku[n, m] = sudoku[n, m].Remove(j, 1);
                            break;
                        }
                    }
                }
            }
            for (int i = 1; i <= 6; i++)
            {
                if (i != m && sudoku[n, i].Length == 1)
                {
                    for (int j = 0; j < sudoku[n, m].Length; j++)
                    {
                        if (sudoku[n, m][j].ToString() == sudoku[n, i])
                        {
                            sudoku[n, m] = sudoku[n, m].Remove(j, 1);
                            break;
                        }
                    }
                }
            }
        }

        public void Edit_Small_Sudoku(int n, int m)
        {
            if (n <= 2 && m <= 3)
            {
                for (int i = 1; i <= 2; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                        {
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                        }
                    }
                }
            }
            if (n <= 2 && m >= 4)
            {
                for (int i = 1; i <= 2; i++)
                {
                    for (int j = 4; j <= 6; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                        {
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                        }
                    }
                }
            }
            if (n > 2 && n <= 4 && m <= 3)
            {
                for (int i = 3; i <= 4; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                        {
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                        }
                    }
                }
            }
            if (n > 2 && n <= 4 && m >= 4)
            {
                for (int i = 3; i <= 4; i++)
                {
                    for (int j = 4; j <= 6; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                        {
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                        }
                    }
                }
            }
            if (n >= 5 && m <= 3)
            {
                for (int i = 5; i <= 6; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                        {
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                        }
                    }
                }
            }
            if (n >= 5 && m >= 4)
            {
                for (int i = 5; i <= 6; i++)
                {
                    for (int j = 4; j <= 6; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                        {
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                        }
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Filling_Sudoku();
            Filling_Empty();
            for (int i = 0; i < 6; i++)
                Search_Sudoku();
            if (Scanning_Sudoku())
                MessageBox.Show("This SUDOKU is wrong");
            else
                Filling_Empty_Square();
            btnSubmit.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            test = false;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                        (control as TextBox).ForeColor = Color.Black;
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
