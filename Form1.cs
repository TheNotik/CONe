using System;
using System.Net.Http;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MimeKit;
using MailKit.Net.Smtp;

namespace Consumer.App
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text.Trim();
            if (string.IsNullOrEmpty(pin))
            {
                MessageBox.Show("Введите PIN!");
                return;
            }

            var client = new HttpClient();
            try
            {
                var response = await client.GetAsync("http://localhost:5197/person/" + pin);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var person = Newtonsoft.Json.JsonConvert.DeserializeObject<PersonDto>(json);

                    lblName.Text = "ФИО: " + person.Name;
                    lblGender.Text = "Пол: " + (person.Gender == "0" ? "Мужской" : "Женский");
                    lblBirthDate.Text = "Дата рождения: " + person.BirthDate.ToString("dd.MM.yyyy");
                    lblResult.Text = "";
                }
                else
                {
                    lblResult.Text = "Человек не найден";
                    lblName.Text = "";
                    lblGender.Text = "";
                    lblBirthDate.Text = "";
                }
            }
            catch
            {
                lblResult.Text = "Сервер не запущен. Запустите Producer.Api";
            }
        }

        private async void btnSupport_Click(object sender, EventArgs e)
        {
            string userMessage = Microsoft.VisualBasic.Interaction.InputBox(
                "Опишите вашу проблему:", "Обращение в поддержку", "");

            if (string.IsNullOrEmpty(userMessage)) return;

            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress("Пользователь", "likeme2500@gmail.com"));
                emailMessage.To.Add(new MailboxAddress("Поддержка", "likeme2500@gmail.com"));
                emailMessage.Subject = "Обращение в тех поддержку";
                emailMessage.Body = new TextPart("plain") { Text = userMessage };

                var smtp = new SmtpClient();
                await smtp.ConnectAsync("smtp.gmail.com", 587, false);
                await smtp.AuthenticateAsync("likeme2500@gmail.com", "cnmavevovifrrsoq");
                await smtp.SendAsync(emailMessage);
                await smtp.DisconnectAsync(true);

                MessageBox.Show("Сообщение отправлено в поддержку!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnSupport_Click_1(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class PersonDto
    {
        public string Pin { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}