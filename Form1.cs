using System.ComponentModel;
using System.Media;
using System.Windows.Forms;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Diagnostics;
using System.Threading;

namespace AbtiLog
{
    public partial class Form1 : Form
    {
      
        SoundPlayer player = new SoundPlayer();
        Thread ThreadBeeper = new Thread(BipBop);

        record class BeepData(int frequency,int time)
        {

        }
        BeepData beepData = new BeepData(0, 0);

        private static void BipBop(object? obj)
        {
            if(obj is  BeepData beepData)
            {
                Console.Beep(beepData.frequency,beepData.time);
            }
            throw new NotImplementedException();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radius, rectangleSide_A, rectangleSide_B, n, m = 0;
            double koef = 0.01;

            Bitmap bitmap = new Bitmap(pbSideA.Width, pbSideA.Height);

            Graphics g = Graphics.FromImage(bitmap);

            Pen figurePen = new Pen(Color.Black, 1);

            g.Clear(Color.White);

            OutputTable.Rows.Clear();
            dgFoundS.Rows.Clear();
      
            player.Stream = Properties.Resources.zvuk_modema;

            player.Play();
            Thread.Sleep(3500);

            player.Stream = Properties.Resources.wet_beep_fx;

            try
            {

                Radius = float.Parse(tbRadius.Text);
                rectangleSide_A = float.Parse(tbSideA.Text);
                rectangleSide_B = float.Parse(tbSideB.Text);

                pbSideA.Image = bitmap;

                for (int i = 0; i <= 17000; i++)
                {
                    koef += 0.01;
                    //labelKoef.Text = "KOEF " + koef.ToString();

                    n = Math.Round((rectangleSide_A + (Radius * 2)) / (Radius / koef), 2);
                    m = Math.Round((rectangleSide_B + (Radius * 2)) / (Radius / koef), 2);

                    //labelN.Text = "N " + n.ToString();
                    if (n % 1 == 0 && m % 1 == 0 && (n > 0 && m > 0)) //Целое
                    {                    
                        OutputTable.Rows.Add("Этот шаг", (Math.Round((Radius / koef), 3)), n, m);
                    }
                }
                player.Play();

            }
            catch
            {
                MessageBox.Show("Вы ввели ошибочные данные! Повторите ввод, иначе конденКсантор взорветБся!",
                    "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.Radar_Sound;

            player.PlayLooping();

        }


        private void OutputTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double DeltaD = Convert.ToDouble(OutputTable.CurrentRow.Cells[1].Value);
            double R = double.Parse(tbRadius.Text);
            int steps = Convert.ToInt32(OutputTable.CurrentRow.Cells[2].Value);
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)OutputTable.CurrentRow.Cells[0];
            buttonCell.Style.BackColor = Color.Red;
            dgFoundS.Rows.Clear();

           
            buttonCell.FlatStyle = FlatStyle.Popup;
            buttonCell.Style.BackColor = System.Drawing.Color.Red;

            player.Stream = Properties.Resources.zvuk_printera_matrichnyy_printer;

            player.Play();

            Pen axisPen = new Pen(Color.Green, 2);
            Pen gridPen = new Pen(Color.LightGray, 1);

            Brush labelBrush = new SolidBrush(Color.Black);
            Font labelFont = new Font("Arial", 9);

            Bitmap bitmap = new Bitmap(pbSideA.Width, pbSideA.Height);

            Graphics g = Graphics.FromImage(bitmap);

            progressBar1.Maximum = steps;
            progressBar1.Value = 0;

            double[] areas = new double[steps + 1];

            areas[0] = 0;

            for (int n = 1; n <= steps; n ++)
            {
                double d = n + DeltaD;

                double circleCenterX = n * DeltaD - R;
                double circleCenterY = double.Parse(tbSideB.Text) / 2;

                areas[n] = CalculateIntersectionArea(DeltaD,circleCenterX,circleCenterY);
                dgFoundS.Rows.Add(Math.Round(areas[n - 1],3));
                progressBar1.Value = n;
            }
            areas[areas.Length - 1] = 0;
            dgFoundS.Rows.Add(areas[areas.Length - 1]);

            double maxArea = Math.PI * R * R;
            float graphWidth = pbSideA.Width - 40;
            float graphHeight = pbSideA.Height - 40;
            float stepX = graphWidth / steps;
            float stepY = graphHeight / (float)maxArea;

            //   DrawShapes(g, steps, R, double.Parse(tbSideB.Text), double.Parse(tbSideA.Text), DeltaD, stepX, stepY);

            g.TranslateTransform(20, pbSideA.Height - 20);

            // Рисование координатной сетки и осей
            for (int i = 0; i <= steps; i++)
            {
                float x = i * stepX;
                g.DrawLine(gridPen, x, 0, x, -graphHeight);
                g.DrawString((i * Math.Round(DeltaD, 3)).ToString(), labelFont, labelBrush, x - 10, 5);
            }

            for (int i = 0; i <= 10; i++)
            {
                float y = -i * stepY * (float)maxArea / 10;
                g.DrawLine(gridPen, 0, y, graphWidth, y);
                g.DrawString((i * Math.Round(maxArea, 2) / 10).ToString("0.0"), labelFont, labelBrush, -30, y - 5);
            }

            g.DrawLine(axisPen, 0, 0, graphWidth, 0); // X ось
            g.DrawLine(axisPen, 0, 0, 0, -graphHeight); // Y ось

            // Рисование графика
            for (int n = 0; n < steps; n++)
            {
                float x1 = n * stepX;
                float y1 = -(float)areas[n] * stepY;
                float x2 = (n + 1) * stepX;
                float y2 = -(float)areas[n + 1] * stepY;
                g.DrawLine(axisPen, x1, y1, x2, y2);
            }
            pbSideA.Image = bitmap;
            player.Stop();
        }

        double CalculateIntersectionArea(double d, double circleCenterX, double circleCenterY)
        {
            int NumSamples = 0;
            try
            {
                Random random = new Random();
                
                int countInside = 0;
                NumSamples = int.Parse(tbTochonst.Text);
                double W = double.Parse(tbSideA.Text);
                double L = double.Parse(tbSideB.Text);
                double R = double.Parse(tbRadius.Text);

                double rectXMin = d - R;
                double rectXMax = d + R;
                double rectYMin = -W / 2;
                double rectYMax = W / 2;

                // Границы прямоугольника в глобальных координатах
                double xMin = Math.Max(rectXMin, -L / 2);
                double xMax = Math.Min(rectXMax, L / 2);
                double yMin = rectYMin;
                double yMax = rectYMax;

                // Если прямоугольник не пересекается с кругом
  
                for (int i = 0; i < NumSamples; i++)
                {
                    double x = random.NextDouble() * W;
                    double y = random.NextDouble() * L;

                    bool insideRectangle = x >= 0 && x <= W && y >= 0 && y <= L;
                    bool insideCircle = Math.Pow(x - circleCenterX, 2) + Math.Pow(y - circleCenterY, 2) <= Math.Pow(R, 2);

                    if (insideRectangle && insideCircle)
                    {
                        countInside++;
                      //  beepData.frequency.Equals(countInside);
                     //   ThreadBeeper.Start(beepData);
                    }
                   
                }
                
                double intersectionArea = ((double)countInside / NumSamples * W * L)/4;
                
                 
                
                return intersectionArea;

            }
            catch(Exception ex)
            {
                player.Stream = Properties.Resources.STALKER_Emission_in_real_life;
                player.PlayLooping();
                MessageBox.Show("Ващ процессор схлопнул вселенную, ПО ПРИЧИНЕ: "+ ex.Message,
                  "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NumSamples = 0;
                throw;

            }

        }
        private void DrawShapes(Graphics g, int steps, double R, double L, double W, double DeltaD, float stepX, float stepY)
        {
            Pen circlePen = new Pen(Color.Red, 1);
            Pen rectPen = new Pen(Color.Green, 1);

            float rectHeight = (float)W * stepY;
            float rectWidth = (float)L * stepX;
            float rectY = pbSideA.Height / 2 - rectHeight / 2;

            for (int n = 0; n <= steps; n++)
            {
                double d = n * DeltaD;
                float circleX = 20 + n * stepX;
                float circleY = pbSideA.Height / 2;

                g.DrawEllipse(circlePen, circleX - (float)R * stepX, circleY - (float)R * stepY, (float)R * 2 * stepX, (float)R * 2 * stepY);
                g.DrawRectangle(rectPen, 20, rectY, rectWidth, rectHeight);

                //  g.Clear(Color.White);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "СОхранить график";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    pbSideA.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Reverse = "";
            Reverse = tbSideA.Text;
            tbSideA.Text = tbSideB.Text;
            tbSideB.Text = Reverse;
        }

    }
}
