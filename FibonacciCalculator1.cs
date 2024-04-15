using System.Numerics;

namespace FibonacciCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoundary.Text, out int boundary))
            {
                txtResult.Clear();
                await CalculateFibonacciAsync(boundary);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value for the boundary.");
            }
        }

        private async Task CalculateFibonacciAsync(int boundary)
        {
            await Task.Run(() =>
            {
                BigInteger prev = 0;
                BigInteger curr = 1;
                BigInteger next;

                while (prev <= boundary)
                {
                    txtResult.AppendText(prev + Environment.NewLine);
                    next = prev + curr;
                    prev = curr;
                    curr = next;
                }
            });
        }
    }
}
