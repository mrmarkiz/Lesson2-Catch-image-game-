namespace Lesson2
{
    public partial class Form1 : Form
    {
        private int _speed;
        private bool isMoving;
        private int _points;
        private double _catchPercent;
        public Form1()
        {
            _speed = 3;
            _points = 0;
            _catchPercent = 0;
            isMoving = false;
            InitializeComponent();
            updatePoints();
            updateCatchPercent();
        }

        private void updatePoints()
        {
            labelPoints.Text = $"Points: {_points}";
        }

        private void updateCatchPercent()
        {
            labelCatchPercent.Text = $"Catch percent: {((int)_catchPercent).ToString()}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                pictureBoxMoving.Left += _speed;
                if (pictureBoxMoving.Left > this.Width - pictureBoxMoving.Width)
                {
                    isMoving = false;
                    MessageBox.Show("You lost!", "Unluck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer1.Stop();
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            isMoving = true;
            pictureBoxMoving.Left = 0;
            _speed = 5;
            _points = 0;
            _catchPercent = 0;
            updateCatchPercent();
            updatePoints();
            timer1.Start();
        }

        private void buttonStart_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void buttonStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                isMoving = false;
                if (pictureBoxMoving.Right < pictureBoxStatic.Left || pictureBoxMoving.Left > pictureBoxStatic.Right)
                {
                    MessageBox.Show("You lost!", "Unluck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    timer1.Stop();
                    _catchPercent = ((double)(pictureBoxMoving.Width - Math.Abs(pictureBoxMoving.Left - pictureBoxStatic.Left)) / pictureBoxMoving.Width) * 100;
                    _points++;
                    updatePoints();
                    updateCatchPercent();
                    pictureBoxMoving.Left = 0;
                    _speed += 3;
                    timer1.Start();
                    isMoving = true;
                    MessageBox.Show("You cought!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}