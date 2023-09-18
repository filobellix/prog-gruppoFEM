using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace prog_gruppoFEM
{

    public partial class Form1 : Form
    {
        string jsonString;

        public class Messaggio
        {
            public string Message { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                          .WithTcpServer("broker.hivemq.com", 1883)
                          .Build();

            await mqttClient.ConnectAsync(options);

            await Task.Run(async () =>
            {

                await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder()
                           .WithTopic("chat")
                           .Build());

                mqttClient.UseDisconnectedHandler(async e =>
                {
                    await Task.Delay(TimeSpan.FromSeconds(2));

                    try
                    {
                        await mqttClient.ConnectAsync(options);
                    }
                    catch
                    {

                    }

                });

                mqttClient.UseApplicationMessageReceivedHandler(async e =>
                {
                    string topic = e.ApplicationMessage.Topic;
                    string payload = e.ApplicationMessage.ConvertPayloadToString();

                    Messaggio message = JsonSerializer.Deserialize<Messaggio>(payload);

                    textBoxRecMessaggio.Invoke((MethodInvoker)(() => textBoxRecMessaggio.Text += message.Message + "\r\n"));

                });
            }); 
        }

        private async void buttonInvia_Click(object sender, EventArgs e)
        {
            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                          .WithTcpServer("broker.hivemq.com", 1883)
                          .Build();

            await mqttClient.ConnectAsync(options);


            Messaggio Message = new Messaggio()
            {
                Message = "Filippo: " + textBoxMessaggio.Text,
            };

            jsonString = JsonSerializer.Serialize(Message);

            var message = new MqttApplicationMessageBuilder()
                          .WithTopic("chat")
                          .WithPayload(jsonString)
                          .Build();

            await mqttClient.PublishAsync(message);

            textBoxMessaggio.Clear();
            
        }

        private void textBoxRecMessaggio_TextChanged(object sender, EventArgs e)
        {
            textBoxRecMessaggio.SelectionStart = textBoxRecMessaggio.Text.Length;
            textBoxRecMessaggio.ScrollToCaret();
        }
    }
}