using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanoHafman
{
    public partial class Form1 : Form
    {
        static Dictionary<int, int> dictionary = new Dictionary<int, int>();
        static int sumF = 0;

        public Form1()
        {
            InitializeComponent();
            fanoGridView.RowCount = 3;
            haffmanGridView.RowCount = 8;
            fanoResultGridView.RowCount = 7;
            haffmanResultGridView.RowCount = 7;

            #region alphabet
            alphabetGridView.RowCount = 7;

            alphabetGridView[0, 0].Value = 'a';
            alphabetGridView[0, 1].Value = 'b';
            alphabetGridView[0, 2].Value = 'c';
            alphabetGridView[0, 3].Value = 'd';
            alphabetGridView[0, 4].Value = 'e';
            alphabetGridView[0, 5].Value = 'f';
            alphabetGridView[0, 6].Value = 'g';

            alphabetGridView[1, 0].Value = 35;
            alphabetGridView[1, 1].Value = 35;
            alphabetGridView[1, 2].Value = 10;
            alphabetGridView[1, 3].Value = 8;
            alphabetGridView[1, 4].Value = 5;
            alphabetGridView[1, 5].Value = 5;
            alphabetGridView[1, 6].Value = 2;

            #endregion

        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < alphabetGridView.RowCount; i++)
                {
                    dictionary.Add(i, int.Parse(alphabetGridView[1, i].Value.ToString()));
                    sumF += int.Parse(alphabetGridView[1, i].Value.ToString());
                }

                sumLabel.Text = "" + sumF;
            }
            catch(Exception ex) { }

            if (fanoRadioButton.Checked)
            {
                #region fanoChecked

                int i = 0;
                int j = 2;

                fanoGridView[0, 0].Value = 1;
                fanoGridView[0, 1].Value = 1;
                fanoGridView[1, 0].Value = 1;
                fanoGridView[2, 0].Value = 1;
                fanoGridView[2, 1].Value = alphabetGridView.RowCount;
                fanoGridView[1, 1].Value = int.Parse(fanoGridView[2, 0].Value.ToString()) + 1;

                fanoGridView[3, 0].Value = countSum(0);
                fanoGridView[3, 1].Value = sumF - countSum(0);
                fanoPerebir(0);
                fanoGridView[4, 0].Value = 1;
                fanoGridView[4, 1].Value = 1;
                fanoGridView[5, 0].Value = 1;
                fanoGridView[5, 1].Value = 0;


                while (i != j)
                {
                    if (int.Parse(fanoGridView[1, i].Value.ToString()) == int.Parse(fanoGridView[2, i].Value.ToString()))
                    {
                        fanoResultGridView[0, int.Parse(fanoGridView[1, i].Value.ToString())-1].Value = alphabetGridView[0, int.Parse(fanoGridView[1, i].Value.ToString()) - 1].Value;
                        fanoResultGridView[1, int.Parse(fanoGridView[1, i].Value.ToString())-1].Value = fanoGridView[5, i].Value;
                        i++;
                    }
                    else
                    {
                        fanoGridView.RowCount = fanoGridView.RowCount + 2;
                        fanoGridView[0, j].Value = int.Parse(fanoGridView[0, j - 1].Value.ToString()) + 1;
                        fanoGridView[0, j + 1].Value = fanoGridView[0, j].Value;
                        fanoGridView[1, j].Value = fanoGridView[1, i].Value;
                        fanoGridView[2, j].Value = fanoGridView[1, i].Value;
                        fanoGridView[1, j + 1].Value = int.Parse(fanoGridView[1, i].Value.ToString()) + 1;
                        fanoGridView[2, j + 1].Value = fanoGridView[2, i].Value;
                        fanoGridView[3, j].Value = countSum(j);
                        fanoGridView[3, j + 1].Value = countSum(j + 1);
                        fanoPerebir(j);
                        fanoGridView[4, j].Value = int.Parse(fanoGridView[4, i].Value.ToString()) + 1;
                        fanoGridView[4, j + 1].Value = fanoGridView[4, j].Value;
                        fanoGridView[5, j].Value = fanoGridView[5, i].Value.ToString() + 1;
                        fanoGridView[5, j + 1].Value = fanoGridView[5, i].Value.ToString() + 0;

                        i++;
                        j += 2;
                    }
                }

                #endregion
            }
            else
            {
                #region haffmanChecked

                for (int i = 0; i < dictionary.Count; i++)
                {
                    haffmanGridView[0, i].Value = i+1;
                    haffmanGridView[1, i].Value = i+1;
                    haffmanGridView[2, i].Value = 0;
                    haffmanGridView[3, i].Value = dictionary[i];
                }

                iterationHaffman(dictionary.Count - 1, dictionary.Count-1);
                codeHaffman(haffmanGridView.RowCount-2);
                for (int i = 0; i < dictionary.Count; i++)
                {
                    haffmanResultGridView[0, i].Value = alphabetGridView[0, i].Value;
                    haffmanResultGridView[1, i].Value = haffmanGridView[5, i].Value;
                }

                #endregion
            }
        }

        void iterationHaffman(int ryad, int num)
        {
            int sum = int.Parse(haffmanGridView[3, ryad].Value.ToString()) +
                      int.Parse(haffmanGridView[3, ryad - 1].Value.ToString());
            Boolean b = true;
            for (int i = ryad-num; i < ryad-1; i++)
            {
                if (int.Parse(haffmanGridView[3, i].Value.ToString()) > sum)
                {
                    haffmanGridView.RowCount = haffmanGridView.RowCount + 1;
                    haffmanGridView[0, haffmanGridView.RowCount-2].Value = int.Parse(haffmanGridView[0, haffmanGridView.RowCount - 3].Value.ToString()) + 1;
                    for (int j = 1; j < 4; j++)
                    {
                        haffmanGridView[j, haffmanGridView.RowCount - 2].Value = haffmanGridView[j, i].Value;
                    }
                }
                else
                {
                    if (b)
                    {
                        haffmanGridView.RowCount = haffmanGridView.RowCount + 1;
                        haffmanGridView[0, haffmanGridView.RowCount - 2].Value =
                            int.Parse(haffmanGridView[0, haffmanGridView.RowCount - 3].Value.ToString()) + 1;
                        haffmanGridView[1, haffmanGridView.RowCount - 2].Value = ryad;
                        haffmanGridView[2, haffmanGridView.RowCount - 2].Value = ryad + 1;
                        haffmanGridView[3, haffmanGridView.RowCount - 2].Value = sum;
                        b = false;
                    }
                    haffmanGridView.RowCount = haffmanGridView.RowCount + 1;
                    haffmanGridView[0, haffmanGridView.RowCount - 2].Value = int.Parse(haffmanGridView[0, haffmanGridView.RowCount - 3].Value.ToString()) + 1;
                    for (int j = 1; j < 4; j++)
                    {
                        haffmanGridView[j, haffmanGridView.RowCount - 2].Value = haffmanGridView[j, i].Value;
                    }
                }

                if (b && i == ryad - 2)
                {
                    haffmanGridView.RowCount = haffmanGridView.RowCount + 1;
                    haffmanGridView[0, haffmanGridView.RowCount - 2].Value =
                        int.Parse(haffmanGridView[0, haffmanGridView.RowCount - 3].Value.ToString()) + 1;
                    haffmanGridView[1, haffmanGridView.RowCount - 2].Value = ryad;
                    haffmanGridView[2, haffmanGridView.RowCount - 2].Value = ryad + 1;
                    haffmanGridView[3, haffmanGridView.RowCount - 2].Value = sum;
                    b = false;
                }
            }
            if (num != 1)
                iterationHaffman(ryad + num, num - 1);
            else
            {
                haffmanGridView.RowCount = haffmanGridView.RowCount + 1;
                haffmanGridView[0, haffmanGridView.RowCount - 2].Value =
                    int.Parse(haffmanGridView[0, haffmanGridView.RowCount - 3].Value.ToString()) + 1;
                haffmanGridView[1, haffmanGridView.RowCount - 2].Value = ryad;
                haffmanGridView[2, haffmanGridView.RowCount - 2].Value = ryad + 1;
                haffmanGridView[3, haffmanGridView.RowCount - 2].Value = sum;
            }
        }

        void codeHaffman(int last)
        {
            haffmanGridView[4, last].Value = 0;
            haffmanGridView[4, last-1].Value = 1;
            haffmanGridView[4, last-2].Value = 1;
            haffmanGridView[5, last-1].Value = 0;
            haffmanGridView[5, last-2].Value = 1;

            for (int i = last - 1; i > dictionary.Count - 1; i--)
            {
                if (haffmanGridView[4, i].Value != null)
                {
                    int h = int.Parse(haffmanGridView[1, i].Value.ToString());

                    if (int.Parse(haffmanGridView[2, i].Value.ToString()) == 0)
                    {
                        haffmanGridView[4, h - 1].Value = int.Parse(haffmanGridView[4, i].Value.ToString());
                        haffmanGridView[5, h - 1].Value = haffmanGridView[5, i].Value.ToString();
                    }
                    else
                    {
                        haffmanGridView[4, h - 1].Value = int.Parse(haffmanGridView[4, i].Value.ToString()) + 1;
                        haffmanGridView[5, h - 1].Value = haffmanGridView[5, i].Value.ToString() + 1;
                        h = int.Parse(haffmanGridView[2, i].Value.ToString());
                        haffmanGridView[4, h - 1].Value = int.Parse(haffmanGridView[4, i].Value.ToString()) + 1;
                        haffmanGridView[5, h - 1].Value = haffmanGridView[5, i].Value.ToString() + 0;
                    }
                }

            }
        }

        void fanoPerebir(int ryad)
        {
            int sum1 = int.Parse(fanoGridView[3, ryad].Value.ToString());
            int sum2 = int.Parse(fanoGridView[3, ryad+1].Value.ToString());
            int nowK = int.Parse(fanoGridView[2, ryad].Value.ToString());
            int nowP = int.Parse(fanoGridView[1, ryad+1].Value.ToString());
            int d = Math.Abs(sum1 - sum2);
            int d2 = d - 1;
            int sum3;
            int sum4;

            while (d2 <= d)
            {
                fanoGridView[2, ryad].Value = int.Parse(fanoGridView[2, ryad].Value.ToString()) + 1;
                fanoGridView[1, ryad + 1].Value = int.Parse(fanoGridView[2, ryad].Value.ToString()) + 1;
                sum3 = countSum(ryad);
                sum4 = countSum(ryad + 1);
                d2 = Math.Abs(sum3 - sum4);
                if (d2 < d)
                {
                    fanoGridView[3, ryad].Value = sum3;
                    fanoGridView[3, ryad + 1].Value = sum4;
                    nowK = int.Parse(fanoGridView[2, ryad].Value.ToString());
                    nowP = int.Parse(fanoGridView[1, ryad + 1].Value.ToString());
                    d = d2;
                }
                else
                {
                    fanoGridView[2, ryad].Value = nowK;
                    fanoGridView[1, ryad+1].Value = nowP;
                }
            }

        }

        int countSum(int ryad)
        {
            int sum = 0;

            for (int h = int.Parse(fanoGridView[1, ryad].Value.ToString()) - 1;
                h < int.Parse(fanoGridView[2, ryad].Value.ToString());
                h++)
            {
                sum += dictionary[h];
            }

            return sum;
        }
    }
}
