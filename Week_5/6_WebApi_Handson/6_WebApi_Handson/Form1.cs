using Confluent.Kafka;

namespace _6_WebApi_Handson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void btnSend_Click(object sender, EventArgs e)
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            string message = txtMessage.Text;

            try
            {
                var result = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
                MessageBox.Show($"Delivered to: {result.TopicPartitionOffset}");
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
