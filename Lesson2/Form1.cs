namespace Lesson2
{
    public partial class Form1 : Form
    {
        private int _speed;
        private bool isMoving;
        private int _points;
        private double _catchPercent;
        private bool _isProcessKeyPress { get; set; }
        public Form1()
        {
            _speed = 5;
            _points = 0;
            _catchPercent = 0;
            isMoving = false;
            _isProcessKeyPress = false;
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
                if (pictureBoxMoving.Left > this.Width)
                {
                    pictureBoxMoving.Left = -pictureBoxMoving.Width;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Controls.Remove((Button)sender);
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
            if (e.KeyCode == Keys.Space)
            {
                if (_isProcessKeyPress)
                    return;

                isMoving = false;
                if (pictureBoxMoving.Right < pictureBoxStatic.Left || pictureBoxMoving.Left > pictureBoxStatic.Right)
                {
                    MessageBox.Show("You lost!", "Unluck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Button buttonRestart = new Button();
                    buttonRestart.BackColor = Color.White;
                    buttonRestart.Location = new Point(359, 387);
                    buttonRestart.Name = "buttonRestart";
                    buttonRestart.Size = new Size(164, 33);
                    buttonRestart.TabIndex = 0;
                    buttonRestart.Text = "Restart";
                    buttonRestart.UseVisualStyleBackColor = false;
                    buttonRestart.Click += buttonStart_Click;
                    this.Controls.Add(buttonRestart);
                    return;
                }
                else
                {
                    _isProcessKeyPress = true;
                    timer1.Stop();
                    _catchPercent = ((double)(pictureBoxMoving.Width - Math.Abs(pictureBoxMoving.Left - pictureBoxStatic.Left)) / pictureBoxMoving.Width) * 100;
                    _points++;
                    updatePoints();
                    updateCatchPercent();
                    pictureBoxMoving.Left = 0;
                    _speed += 3;
                    timer1.Start();
                    isMoving = true;
                    _isProcessKeyPress = false;
                }
            }

        }
    }
}